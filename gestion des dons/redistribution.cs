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
    public partial class redistribution : UserControl
    {
        public redistribution()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void redistribution_Load(object sender, EventArgs e)
        {
            try
            {
                this.offreAcceptéTableAdapter.FillBy(this.donsDataSet5.OffreAccepté);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            database.id = metroComboBox3.Text;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroComboBox1.Text == "vente bi-annuelle")
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new ventbi());
            }

            if (metroComboBox1.Text == "dépôt-vente")
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new depotvent());
            }
        }
    }
}
