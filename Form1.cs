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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (adminDl.readLocationFromFile("location.txt"))
            {
                MessageBox.Show("locations loaded");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signUP = new SignUP();
            signUP.ShowDialog();
            this.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signIn = new SignIn();
            signIn.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginDl.readSignUpData("user.txt");
        }
    }
}
