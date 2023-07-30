using GuiAplication.bl;
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
    public partial class ViewCompanyInfo : Form
    {
        public ViewCompanyInfo()
        {
            InitializeComponent();
        }

        private void ViewCompanyInfo_Load(object sender, EventArgs e)
        {
            txtcontact.Text = Manager.contact;
            txtDes.Text = Manager.description;
            txtemail.Text = Manager.email;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}