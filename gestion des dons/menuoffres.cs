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
    public partial class menuoffres : UserControl
    {
        public menuoffres()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(new listageP());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)

        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Ajouter());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new action());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
