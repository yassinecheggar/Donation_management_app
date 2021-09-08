using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestion_des_dons
{
    public partial class menuStock : UserControl
    {
        private string connetionString;
        private SqlConnection cnn;

        public menuStock()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            metroGrid1.Controls.Clear();
            try
            {
                this.offreTableAdapter.FillBy(this.donsDataSet5.offre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                metroGrid1.Controls.Clear();
                this.offreTableAdapter.FillBy4(this.donsDataSet5.offre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
