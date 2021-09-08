using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestion_des_dons
{
    public partial class action : UserControl
    {
        private string connetionString;
        private SqlConnection cnn;

        public action()
        {
            InitializeComponent();
        }

        private void action_Load(object sender, EventArgs e)
        {
            ini();
        }

        void ini()
        {


            connetionString = "Data Source=DESKTOP-OCMHTF1;Initial Catalog=Dons;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            cnn.Open();



            SqlCommand cmd = new SqlCommand("select Reference from offre");
            cmd.Connection = cnn;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                metroComboBox1.Items.Add(reader[0].ToString());

            }

            try
            {
                this.vehiculeTableAdapter.FillBy3(this.donsDataSet5.Vehicule);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                this.transporteurTableAdapter.FillBy(this.donsDataSet5.Transporteur);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.addoffracc(metroComboBox1.Text, database.userid, bunifuDatepicker2.Value.ToLongDateString(), metroComboBox2.Text, metroComboBox3.Text, metroComboBox4.Text, DateTime.Now.ToLongDateString());
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}
