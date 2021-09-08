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
    public partial class ajouteurTransp : UserControl
    {
        public ajouteurTransp()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.addTRonsp(metroTextBox1.Text, metroTextBox2.Text);
        }

        private void ajouteurTransp_Load(object sender, EventArgs e)
        {

        }
    }
}
