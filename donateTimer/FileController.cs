using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donateTimer
{
    internal class FileController
    {
        public static string accountPath = Application.StartupPath + "/Save/accounts.txt";
        public static string optionPath = Application.StartupPath + "/Save/options.txt";

        public static string[] LoadAccountData()
        {
            return System.IO.File.ReadAllLines(accountPath);
        }

        public static Option LoadOptionData()
        {
            string[] data = System.IO.File.ReadAllLines(optionPath);
            Option option = new Option();
            option.selectedIndex = int.Parse(data[0]);
            option.minFromWon = int.Parse(data[1]);
            option.addChecked = bool.Parse(data[2]);
            option.subChecked = bool.Parse(data[3]);

            return option;
        }

        public static void SaveAccountData(string[] strings)
        {
            File.WriteAllLines(accountPath, strings);
        }

        public static void SaveOptionData(Option option)
        {
            string[] data = { option.selectedIndex.ToString(), option.minFromWon.ToString(), option.addChecked.ToString(), option.subChecked.ToString() };
            File.WriteAllLines(optionPath, data);
            TimeController.GetInstance().option = option;
        }
    }
}
