using Websocket.Client;
using Websocket.Client.Models;
using NSoup.Helper;
using NSoup.Nodes;
using NSoup.Select;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace donateTimer
{
    class Twip
    {
        private WebsocketClient socket;

        /*
            onConnectReady : 트윕과 처음으로 연결되었을 때
            onDonate : 후원, 영상후원, 슬롯머신(룰렛)
            onSubscribe : 구독
         */

        public event EventHandler onConnectReady;
        public event EventHandler<Donate> onDonate;
        public event EventHandler onSubscribe;

        public async Task Init(string key)
        {
            /* Get version and token information */
            Document doc = HttpConnection.Connect($"https://twip.kr/widgets/alertbox/{key}").Get();
            Elements scripts = doc.GetElementsByTag("script");
            string script = scripts.ToString();

            string version = GetTwipVersion(script);
            string token = GetTwipToken(script);

            if (version == null)
            {
                Console.WriteLine("오류 : [버전 찾을 수 없음]");
            }
            if (token == null)
            {
                Console.WriteLine("오류 : [토큰 찾을 수 없음]");
            }

            /* Create URI for websocket connection */
            string uriString = $"wss://io.mytwip.net/socket.io/?" +
                $"alertbox_key={key}&" +
                $"version={version}&" +
                $"token={EncodeURIComponent(token)}&" +
                $"EIO=3&" +
                $"transport=websocket";
            Uri uri = new Uri(uriString);

            /* Initialize Websocket client */
            socket = new WebsocketClient(uri);
            socket.ReconnectTimeout = null;
            socket.DisconnectionHappened.Subscribe(OnDisconnected);
            socket.ReconnectionHappened.Subscribe(OnReconnecting);
            socket.MessageReceived.Subscribe(OnMessageReceived);

            /* Start */
            await socket.Start();
        }

        private void OnDisconnected(DisconnectionInfo info)
        {
            Console.WriteLine($"[Disconnected. Reason: {(info.Exception != null ? info.Exception.Message : "(None)")}]");
        }
        private void OnReconnecting(ReconnectionInfo info)
        {
            Console.WriteLine($"[Re-connecting... Type: {info.Type}]");
        }
        private void OnMessageReceived(ResponseMessage message)
        {
            Console.WriteLine($"[Received Message] \n\tType:{message.MessageType}\n\tContent > {message.Text}");
            Parse(message.Text);
        }

        private void Parse(string msg)
        {
            // 이벤트 핸들러 호출

            if (onDonate != null)
            {
                if (msg.StartsWith("42[\"new donate\""))
                {
                    msg = msg.Substring(2);
                    Donate donate = new Donate();

                    var donateObj = JArray.Parse(msg);
                    donate.id = (string)donateObj[1]["_id"];
                    donate.nickname = (string)donateObj[1]["nickname"];
                    donate.amount = (int)donateObj[1]["amount"];
                    donate.comment = (string)donateObj[1]["comment"];
                    donate.platform = Platform.Twip;

                    onDonate(null, donate);
                }
            }

        }

        private static string RegexMatchFromString(string input, string pattern)
        {
            Match m = Regex.Match(input, pattern);
            if (m.Success)
            {
                return m.Groups[1].Value;
            }
            return null;
        }

        private static string GetTwipVersion(string inputHTML)
        {
            string pattern = @"version: '(.*)'";
            return RegexMatchFromString(inputHTML, pattern);
        }

        private static string GetTwipToken(string inputHTML)
        {
            string pattern = @"window.__TOKEN__ = '(.*)'";
            return RegexMatchFromString(inputHTML, pattern);
        }

        private static string EncodeURIComponent(string s)
        {
            return System.Web.HttpUtility.UrlEncode(s, Encoding.UTF8);
        }
    }

}