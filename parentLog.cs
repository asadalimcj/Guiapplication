using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAplication.bl
{
    class parentLog
    {
        protected string Name;
        protected string Password;
        public parentLog()
        {

        }
        public parentLog(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public string getName()
        {
            return Name;
        }
        public string getPassword()
        {
            return Password;
        }
        public virtual bool isAdmin()
        {
            return false;
        }
        public virtual string getRole()
        {
            return "";
        }
    }
}
