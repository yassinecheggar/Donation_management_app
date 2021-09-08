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
    public partial class Stockdisplaymenu : UserControl
    {
        public Stockdisplaymenu()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new menuStock());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new redistribution());
        }
    }
}
