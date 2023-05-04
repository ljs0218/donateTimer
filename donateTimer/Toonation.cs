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
    class Toonation
    {
        private WebsocketClient socket;

        /*
            onConnectSuccess : 트윕과 처음으로 연결되었을 때
            onConnectFailed : 연결 실패했을 때
            onDonate : 후원, 영상후원, 슬롯머신(룰렛)
            onSubscribe : 구독
         */

        public event EventHandler onConnectSuccess;
        public event EventHandler onConnectFailed;
        public event EventHandler<Donate> onDonate;
        public event EventHandler onSubscribe;

        public async Task Init(string key)
        {
            /* Get version and token information */
            Document doc = HttpConnection.Connect($"https://toon.at/widget/alertbox/{key}").Get();
            Elements scripts = doc.GetElementsByTag("script");
            string script = scripts.ToString();

            string payload = ParsePayload(script);

            if (payload == null)
            {
                Console.WriteLine("오류 : [페이로드 찾을 수 없음]");
                if (onConnectFailed != null)
                {
                    onConnectFailed(null, null);
                    return;
                }
            }

            /* Create URI for websocket connection */
            string uriString = $"wss://toon.at:8071/" + payload;
            Uri uri = new Uri(uriString);

            /* Initialize Websocket client */
            socket = new WebsocketClient(uri);
            socket.ReconnectTimeout = null;
            socket.DisconnectionHappened.Subscribe(OnDisconnected);
            socket.ReconnectionHappened.Subscribe(OnReconnecting);
            socket.MessageReceived.Subscribe(OnMessageReceived);

            if (onConnectSuccess != null)
            {
                onConnectSuccess(null, null);
            }

            /* Start */
            await socket.Start();
        }

        private void OnDisconnected(DisconnectionInfo info)
        {
            Console.WriteLine($"[Toonation Disconnected. Reason: {(info.Exception != null ? info.Exception.Message : "(None)")}]");
        }
        private void OnReconnecting(ReconnectionInfo info)
        {
            Console.WriteLine($"[Toonation Re-connecting... Type: {info.Type}]");
        }
        private void OnMessageReceived(ResponseMessage message)
        {
            Console.WriteLine($"[Toonation Received Message] \n\tType:{message.MessageType}\n\tContent > {message.Text}");
            Parse(message.Text);
        }

        private void Parse(string msg)
        {
            if (onDonate != null)
            {
                if (msg.StartsWith("{\"code\":101"))
                {
                    Donate donate = new Donate();
                    var donateObj = JObject.Parse(msg);
                    donate.id = (string)donateObj["content"]["account"];
                    donate.nickname = (string)donateObj["content"]["name"];
                    donate.comment = (string)donateObj["content"]["message"];
                    donate.amount = (int)donateObj["content"]["amount"];
                    donate.platform = Platform.Toonation;

                    onDonate(this, donate);
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

        private static string ParsePayload(string inputHTML)
        {

            string pattern = "\"payload\":\"(.*)\",";
            return RegexMatchFromString(inputHTML, pattern);
        }

        private static string EncodeURIComponent(string s)
        {
            return System.Web.HttpUtility.UrlEncode(s, Encoding.UTF8);
        }
    }

}