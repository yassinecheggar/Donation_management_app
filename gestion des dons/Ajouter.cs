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
    public partial class Ajouter : UserControl
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.adddon(bunifuCustomTextbox1.Text, bunifuCustomTextbox2.Text, bunifuCustomTextbox3.Text, bunifuCustomTextbox4.Text, bunifuCustomTextbox5.Text, bunifuCustomTextbox6.Text, bunifuCustomTextbox7.Text, bunifuDatepicker1.Value.ToShortTimeString());
            bunifuCustomTextbox1.Text = "";
            bunifuCustomTextbox2.Text = "";
            bunifuCustomTextbox3.Text = "";
            bunifuCustomTextbox4.Text = "";
            bunifuCustomTextbox5.Text = "";
            bunifuCustomTextbox6.Text = "";
            bunifuCustomTextbox7.Text = ""; 

        }
    }
}
