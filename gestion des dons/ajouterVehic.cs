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
    public partial class ajouterVehic : UserControl
    {
        public ajouterVehic()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();

            db.addvehic(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text);
           
        }
    }
}
