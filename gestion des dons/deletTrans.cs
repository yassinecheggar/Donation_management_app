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
    public partial class deletTrans : UserControl
    {
        public deletTrans()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void deletTrans_Load(object sender, EventArgs e)
        {
            try
            {
                this.transporteurTableAdapter.Fill(this.donsDataSet3.Transporteur);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();

            db.delTrans(metroComboBox1.Text);
        }
    }
}
