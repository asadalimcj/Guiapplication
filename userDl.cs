using GuiAplication.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiAplication.dl
{
    class userDl
    {
        public static List<user> FeedBack = new List<user>();
        public static void AddFeedBack(user s)
        {
            FeedBack.Add(s);
        }
        public static void storeFeedBackInFile(string path)
        {
            StreamWriter f = new StreamWriter(path, true);
            for (int idx = 0; idx < FeedBack.Count(); idx++)
            {
                f.WriteLine(FeedBack[idx].GetFeedBacker() + "," + FeedBack[idx].GetComment());
            }
            f.Close();
        }
        public static bool readLFeedBackFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string comment = splittedRecord[1];
                    user n = new user(name, comment);
                    FeedBack.Add(n);
                }
                f.Close();
                return true;
            }
            return false;
        }


        public static bool Pay_bill(int amount, user s)
        {
            bool flag = false;
            Console.WriteLine(s.GetFareAmount());
            amount = amount - s.GetFareAmount();
            if (amount >= 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
