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
    public partial class listVeh : UserControl
    {
        public listVeh()
        {
            InitializeComponent();
        }


        private void listVeh_Load(object sender, EventArgs e)
        {
            try
            {
                this.vehiculeTableAdapter1.Fill(this.donsDataSet5.Vehicule);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}
