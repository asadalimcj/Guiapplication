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
    public partial class updateInfo : Form
    {
        Manager s = new Manager();
        public updateInfo(Manager s)
        {
            InitializeComponent();
            this.s = s;
            MessageBox.Show(s.GetDes());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int count = Manager.contactValidation(txtContact.Text);
            int count1 = Manager.emailValidation(txtEmail.Text);

            if (count == 11 && count1 ==1)
            {
                Manager.description = txtAboutUs.Text;
                Manager.contact = txtContact.Text;
                Manager.email = txtEmail.Text;
                MessageBox.Show("UPDATED");
            }
            else
            {
                MessageBox.Show("INVALID CREDENTIAL");
            }
            //if(count1 == 1)
            // {
              //  MessageBox.Show("EMAIL UPDATED");
            //}
            //else
            //{
              //  MessageBox.Show("INVALID EMAIL");
            //}
            Manager.storeinfoInFile("info.txt");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
