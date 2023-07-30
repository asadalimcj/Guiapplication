using GuiAplication.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiAplication.dl
{
    class adminDl
    {
        public static List<string> location = new List<string>();
        public static List<int> fare = new List<int>();
        public static void  AddDistination(orangeLine s)
        {
            location.Add(s.getCity());
            fare.Add(s.getFare());
        }
        public static void StoreLocationInfile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            for(int idx = 0; idx<location.Count(); idx ++)
            {
                f.WriteLine(location[idx] + "," + fare[idx]);
            }
            f.Close();
        }
        public static bool readLocationFromFile(string path)
        {
            string record;
            if(File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string locate = splittedRecord[0];
                    int money = int.Parse(splittedRecord[1]);
                    location.Add(locate);
                    fare.Add(money);
                }
                f.Close();
                return true;
            }
            return false;
        }
        public static int SetFare(orangeLine s)
        {
            int index = -1;
            for (int idx = 0; idx < location.Count; idx++)
            {
                if (s.getCity() == location[idx])
                {
                    index = idx;
                }
            }
            return index;
           
        }

        public static void UpdateFare(int price,int index)
        {
            fare[index] = price;
        }
        public static int BillPrep(orangeLine s)
        {
            int bill;
            if ((s.getDay() == "sunday" || s.getDay() == "Sunday") || (s.getDay() == "saturday" || s.getDay() == "Saturday"))
            {
                for (int idx = 0; idx < location.Count; idx++)
                {
                    if (s.getCity() == location[idx])
                    {
                        bill = ((s.GetSeat() * fare[idx]) - (s.getDiscount() * s.GetSeat() * fare[idx]) / 100);
                        return bill;
                    }
                }
            }
            else if ((s.getDay() == "monday" || s.getDay() == "Monday") || (s.getDay() == "tuesday" || s.getDay() == "Tuesday") || (s.getDay() == "wednesday" || s.getDay() == "Wednesday") || (s.getDay() == "thursday" || s.getDay() == "Thursday") || (s.getDay() == "friday" || s.getDay() == "Friday"))
            {
                for (int idx = 0; idx < location.Count; idx++)
                {
                    if (s.getCity() == location[idx])
                    {
                        bill = s.GetSeat() * fare[idx];
                        return bill;
                    }
                }
            }
            return bill = 0;

        }
    }
}
