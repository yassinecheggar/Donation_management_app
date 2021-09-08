using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_des_dons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
             panel2.Controls.Add(new menuoffres());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new login());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new Stockdisplaymenu());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
