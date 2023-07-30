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
    public partial class GiveFeedback : Form
    {
        public GiveFeedback()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string feedback = txtFeedback.Text;
            user s = new user(name, feedback);
            userDl.AddFeedBack(s);
            MessageBox.Show("SUBMITTED SUCCESSFULLY");
            userDl.storeFeedBackInFile("feedBack.txt");
            clear();
        }
        public void clear()
        {
            txtName.Text = string.Empty;
            txtFeedback.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
