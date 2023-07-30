using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiAplication.bl
{
    public partial class UpdateCompanyInfo : Form
    {
        Manager s = new Manager();
        public UpdateCompanyInfo()
        {
            InitializeComponent();
        }

        

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            Form update = new updateInfo(s);
            update.ShowDialog();
        }

        private void UpdateCompanyInfo_Load_1(object sender, EventArgs e)
        {
            txtAboutUs.Text = s.GetDes();
            txtContact.Text = s.getContact();
            txtEmail.Text = s.getEmail();
        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void txtAboutUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioNo_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
