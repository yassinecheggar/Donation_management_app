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
    public partial class listageP : UserControl
    {
        public listageP()
        {
            InitializeComponent();
        }

       

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.offreTableAdapter1.FillBy(this.donsDataSet1.offre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listageP_Load(object sender, EventArgs e)
        {
            
        }
    }
}
