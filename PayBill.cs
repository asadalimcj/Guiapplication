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
    public partial class PayBill : Form
    {
        orangeLine s;
        public PayBill()
        {
            InitializeComponent();
            s = ExtraDL.s1;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string money = txtmoney.Text;
            if (validation.StringCon(money))
            {
               if(int.Parse(money) > s.GetFareAmount())
               {
                    MessageBox.Show("YOU HAVE ENTER " + money + " AND YOUR BILL IS " + s.GetFareAmount() );
               }
               else
               {
                    MessageBox.Show("YOU LACK MONEY:");
               }
            }
            else
            {
                MessageBox.Show("INVALID AMOUT ENTERED:");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
