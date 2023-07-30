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
    public partial class viewFeedback : Form
    {
        public viewFeedback()
        {
            InitializeComponent();
            BindData();
        }

        private void dtagrdViewFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void BindData()
        {
            dtagrdViewFeedback.DataSource = null;
            dtagrdViewFeedback.DataSource = userDl.FeedBack;
            dtagrdViewFeedback.Refresh();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
