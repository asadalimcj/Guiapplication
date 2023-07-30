using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiAplication.bl
{
    public class Manager : orangeLine
    {
        public static string description="travel and enjoy with us";
        public static string contact="923029614436";
        public static string email="orangelinelahore@gmail.com";
        public Manager()
        {
            /*description = "Travel and Enjoy with us";
            contact = "0428969431";
            email = "orangelinelahore@gmail.com";*/
        }
        /*public Manager(string des, string number, string mail)
        {
            this.description = des;
            this.contact = number;
            this.email = mail;
        }*/
        public string GetDes()
        {
            return description;
        }
        public string getContact()
        {
            return contact;
        }
        public string getEmail()
        {
            return email;
        }

        /*public void SetDes(string description)
        {
            this.description = description;
        }
        public void SetContact(string contact)
        {
            this.contact = contact;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }*/
        public static int contactValidation(string number)
        {
            int count = 0;
            int length = number.Length;
            if(length == 11)
            {
                for(int idx = 0; idx < length; idx++)
                {
                    int value = number[idx] - '0';
                    if (value >= 0 && value < 10)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int emailValidation(string mail)
        {
            int count = 0;
            int length = mail.Length;
            for(int idx = 0; idx <length; idx++)
            {
                if(mail[idx] == '@')
                {
                    count++;
                }
            }
            return count;
        }
        public static void storeinfoInFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            f.WriteLine(description + ',' + contact + ',' + email);
            f.Close();
        }
        public static void readInfofromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path, true);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    description = splittedRecord[0];
                    contact = splittedRecord[1];
                    email = splittedRecord[2];
                }
                f.Close();
            }
        }
    }
}
