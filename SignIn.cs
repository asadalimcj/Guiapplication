using GuiAplication.bl;
using GuiAplication.dl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiAplication
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSIgnIn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPass.Text;
            parentLog s = new parentLog(name, password);
            if(s != null)
            {
                s = loginDl.SignIn(s);
                if(s == null)
                {
                    MessageBox.Show("invalid user:");
                }
                else if(s.isAdmin())
                {
                    MessageBox.Show("LogIn successfully:");
                    this.Hide();
                    Form admin = new AdminForm();
                    admin.ShowDialog();
                    this.Close();
                }
                else if(s.isAdmin() == false && (s.getRole() == "user" || s.getRole() == "User"))
                {
                    MessageBox.Show("LogIn Successfully");
                    this.Hide();
                    Form user = new UserForm();
                    user.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("INVALID CREDENTILAS");
                }

            }
            ClearData();
        }
        public void ClearData()
        {
            txtName.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
