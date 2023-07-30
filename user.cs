using GuiAplication.dl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAplication.bl
{
    public class user : orangeLine
    {
        private string Name;
        private string Comment;
        private int Amount;
        public string Name1 { get => Name; set => Name = value; }
        public string Comment1 { get => Comment; set => Comment = value; }

        public user()
        {

        }
        public static void CheckFare(List<string> city, List<int> fare)
        {
           for (int idx = 0; idx < city.Count; idx++)
           {
               Console.WriteLine("{0}" + "." + city[idx] + "::" + fare[idx], idx + 1);
           }
        }
        public override int GetFareAmount()
        {
            return Amount;
        }
        public override void SetFareAmount(int money)
        {
            this.Amount = money;
        }
        public user(string name, string comment)
        {
            this.Name1 = name;
            this.Comment1 = comment;
        }
        public void SetFeedBacker(string name)
        {
            this.Name1 = name;
        }
        public void SetComment(string comment)
        {
            this.Comment1 = comment;
        }
        public override string GetFeedBacker()
        {
            return Name1;
        }
        public override string GetComment()
        {
            return Comment1;
        }
        public static int BookSeat(orangeLine s1,orangeLine s)
        {
            int bill = 0;
            if(s.GetSeat() >= 0 && s.GetSeat() <= s1.getRemSeat())
            {
                bill = adminDl.BillPrep(s);
                int seat = s1.getRemSeat() - s.GetSeat();
                s1.setRemSeat(seat);
            }
            return bill;
        }
        //public static bool Pay_bill(int amount)
        //{
        //    bool flag = false;
        //    user s = new user();
        //    Console.WriteLine(s.GetFareAmount());
        //    amount = amount - s.GetFareAmount();
        //    if(amount >=0)
        //    {
        //        flag = true;
        //    }
        //    return flag;
        //}


    }
}
