using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donateTimer
{
    public enum Platform
    {
        Twip,
        Toonation
    }

    public class Donate
    {
        public string id;
        public string nickname;
        public int amount;
        public string comment;

        public Platform platform;
    }
}
