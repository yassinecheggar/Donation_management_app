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
    public partial class listusers : UserControl
    {
        public listusers()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void listusers_Load(object sender, EventArgs e)
        {
            try
            {
                this.membreTableAdapter.FillBy(this.donsDataSet5.Membre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
