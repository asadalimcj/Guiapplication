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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string path = "user.txt";
            string name = txtName.Text;
            string pass = txtPass.Text;
            string role = txtRole.Text;
            signUp sign = new signUp(name, pass, role);
            loginDl.storeDataInList(sign);
            loginDl.storeSignUpdata(path);
            ClearData();
        }
        public void ClearData()
        {
            txtName.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtRole.Text = string.Empty;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form sign = new Form1();
            sign.ShowDialog();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
