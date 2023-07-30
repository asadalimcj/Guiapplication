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
    public partial class UpdateFare : Form
    {
        string path = "location.txt";
        public UpdateFare()
        {
            InitializeComponent();
        }

        private void UpdateFare_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;
            string fare = txtFare.Text;
            if(validation.StringCon(fare))
            {
                orangeLine s = new orangeLine(station, int.Parse(fare));
                int index = adminDl.SetFare(s);
                if(index != -1)
                {
                    adminDl.UpdateFare(int.Parse(fare), index);
                    adminDl.StoreLocationInfile("location.txt");
                    MessageBox.Show("FARE UPDATED");
                }
                else
                {
                    MessageBox.Show("INVALID LOCATION");
                }

            }
            else
            {
                MessageBox.Show("invalid fare");
            }
            clear();
        }
        public void clear()
        {
            txtFare.Text = string.Empty;
            txtStation.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
