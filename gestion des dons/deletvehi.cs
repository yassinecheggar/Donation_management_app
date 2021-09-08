using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_des_dons
{
    public partial class deletvehi : UserControl
    {
        public deletvehi()
        {
            InitializeComponent();
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillBy2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deletvehi_Load(object sender, EventArgs e)
        {
            try
            {
                this.vehiculeTableAdapter.FillBy2(this.donsDataSet5.Vehicule);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();
           
            db.delvig(metroComboBox1.Text);
        }
    }
}
