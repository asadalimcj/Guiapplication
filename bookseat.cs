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
    public partial class bookseat : Form
    {
        user s2 = new user();
        user s1;
        public bookseat()
        {
            InitializeComponent();
            s1 = ExtraDL.s1;
            user s2 = ExtraDL.User;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;
            string day = txtDay.Text;
            string seat = txtSeat.Text;
            if(validation.StringCon(seat))
            {
                orangeLine s = new orangeLine(day, int.Parse(seat), station);
                int bill = user.BookSeat(s1, s);
                ExtraDL.s1.SetFareAmount(bill);
                if(bill > 0)
                {
                    MessageBox.Show(Convert.ToString( s1.getRemSeat()));
                   // MessageBox.Show(Convert.ToString( s2.GetFareAmount()));
                    MessageBox.Show("SEAT BOOK AND BILL IS:", Convert.ToString(bill));
                }
            }
            else
            {
                MessageBox.Show("INVALID SEAT ENTERED:");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
