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
    public partial class CheckFare : Form
    {
        public CheckFare()
        {
            InitializeComponent();
            
        }

        private void dtaGridFare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void BindData()
        {
            dtagrdViewFare.Columns.Add("Coumns","locaiton");
            dtagrdViewFare.Columns.Add("columns" , "Fare");
            for(int i=0; i<adminDl.location.Count; i++)
            {
                    dtagrdViewFare.Rows.Add(adminDl.location[i], adminDl.fare[i]);
            }
        }

        private void CheckFare_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
