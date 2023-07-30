using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAplication.bl
{
    class signUp : parentLog
    {
        private string Role;
        public signUp(string name, string password, string role) : base(name, password)
        {
            this.Role = role;
        }
        
        public override bool isAdmin()
        {
            if (Role == "admin")
            {
                return true;
            }
            return false;
        }
        public override string getRole()
        {
            return Role;
        }
    }
}
