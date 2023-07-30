using System;
using GuiAplication.bl;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuiAplication.dl;

namespace GuiAplication
{
    public partial class AddStation : Form
    {
        public AddStation()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;
            string fare = txtFare.Text;
            if(validation.StringCon(fare))
            {
                orangeLine add = new orangeLine(station, int.Parse(fare));
                adminDl.AddDistination(add);
                adminDl.StoreLocationInfile("location.txt");
                MessageBox.Show("Station  am added");
                //dataBind();
            }
            else
            {
                MessageBox.Show("invalid fare");
            }
        }

        private void AddStation_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFare_Click(object sender, EventArgs e)
        {

        }

        //void dataBind()
        //{
        //    gridAddstation.DataSource = null;
        //    gridAddstation.DataSource = adminDl.fare;
        //    gridAddstation.Refresh();
        //}
    }
}
