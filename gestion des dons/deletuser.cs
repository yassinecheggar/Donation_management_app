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
    public partial class deletuser : UserControl
    {
        public deletuser()
        {
            InitializeComponent();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void deletuser_Load(object sender, EventArgs e)
        {
            try
            {
                this.membreTableAdapter.FillBy1(this.donsDataSet5.Membre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.deluser(metroComboBox1.Text);
        }
    }
}
