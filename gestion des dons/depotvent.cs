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
    public partial class depotvent : UserControl
    {
        public depotvent()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            database db = new database();
            MessageBox.Show(database.id);
            db.addepot(database.id, bunifuDatepicker2.Value.ToLongDateString(), metroTextBox2.Text, metroTextBox3.Text, metroTextBox1.Text, metroTextBox5.Text);
        }
    }
}
