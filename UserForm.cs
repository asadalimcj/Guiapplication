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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form booking = new bookseat();
            booking.ShowDialog();
            this.Show();
        }

        private void btnSuggestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form feedBack = new GiveFeedback();
            feedBack.ShowDialog();
            this.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form companyinfo = new ViewCompanyInfo();
            companyinfo.ShowDialog();
            this.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form pay = new PayBill();
            pay.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fare = new CheckFare();
            fare.ShowDialog();
            this.Hide();
        }
    }
}
