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
    public partial class AdminForm : Form
    {
        orangeLine s = new orangeLine();
        public AdminForm()
        {
            InitializeComponent();
            s = ExtraDL.s1;
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form station = new AddStation();
            station.ShowDialog();
            this.Show();
        }

        private void btnFare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fare = new UpdateFare();
            fare.ShowDialog();
            this.Show();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form bill = new Bills();
            bill.ShowDialog();
            this.Show();
        }

        private void btnSeatrecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THE REMAINING SEATS ARE:" + Convert.ToString(s.getRemSeat()));
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form view = new viewFeedback();
            view.ShowDialog();
            this.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form info = new UpdateCompanyInfo();
            info.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
