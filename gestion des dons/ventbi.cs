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
    public partial class ventbi : UserControl
    {
        public ventbi()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();
           db.addvent(database.id, metroTextBox3.Text, metroTextBox4.Text, metroTextBox1.Text, metroTextBox2.Text, metroTextBox5.Text);
           
        }
    }
}
