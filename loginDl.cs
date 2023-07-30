using GuiAplication.bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiAplication.dl
{
    class loginDl
    {
        public static List<parentLog> user = new List<parentLog>();
        public static void storeDataInList(parentLog user1)
        {
            user.Add(user1);
        }
        public static void storeSignUpdata(string path)
        {
            StreamWriter f = new StreamWriter(path, true);
            for (int idx = 0; idx < user.Count(); idx++)
            {
                f.WriteLine(user[idx].getName() + "," + user[idx].getPassword() + "," + user[idx].getRole());
            }
            f.Close();
        }
        public static bool readSignUpData(string path)
        {
            string record;
            if(File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    signUp n = new signUp(name, password, role);
                    user.Add(n);
                }
                f.Close();
                return true;
            }
            return false;
        }
        public static parentLog SignIn(parentLog user1)
        {
            foreach(parentLog storedUser in user)
            {
                if(user1.getName() == storedUser.getName() && user1.getPassword() == storedUser.getPassword())
                {
                    return storedUser;
                }
            }
            return null;
        }
        
        
    }
}
