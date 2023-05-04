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
        Toonation,
        Admin
    }

    public enum Type
    {
        Add,
        Sub
    }

    public class Donate
    {
        public string id;
        public string nickname;
        public int amount;
        public string comment;

        public Platform platform;
        public Type type;
    }

    public class Option
    {
        public int selectedIndex;
        public int minFromWon;
        public bool addChecked;
        public bool subChecked;
    }
}
