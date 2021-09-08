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
    public partial class menuadmincs : UserControl
    {
        public menuadmincs()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new listTransp());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ajouteurTransp());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new deletTrans());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new listVeh());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ajouterVehic());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new deletvehi());
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new listusers());
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new deletuser());
        }
    }
}
