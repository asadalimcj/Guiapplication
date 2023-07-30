using System;
using GuiAplication.dl;
using GuiAplication.bl;
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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;
            string day = txtDay.Text;
            string seat = txtSeat.Text;
            if(validation.StringCon(seat))
            {
                orangeLine s = new orangeLine(day, int.Parse(seat), station);
                int result = adminDl.BillPrep(s);
                if(result == 0)
                {
                    MessageBox.Show("INVALID DAY");
                }
                else
                {
                    MessageBox.Show("YOUR BILL: {0}", Convert.ToString(result));
                }
            }
            else
            {
                MessageBox.Show("INVALID SEAT");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
