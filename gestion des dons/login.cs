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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }
      
        private void login_Load(object sender, EventArgs e)
        {
            bunifuTextbox2.BackgroundImageLayout = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            database db = new database();


            int OBJ = db.checkuser(bunifuTextbox1.text, bunifuTextbox2.text);
           
            if (OBJ > 0)
            {



                database.userid = db.getuserid(OBJ.ToString());

                if (bunifuTextbox1.text == "yassine" && bunifuTextbox2.text == "yassine")
                {
                    bunifuFlatButton2.Visible = true;
                    MessageBox.Show("Bonjour monsieur" + bunifuTextbox1.text);

                }
                else
                {
                    MessageBox.Show("Bonjour monsieur" + bunifuTextbox1.text);
                }
            }
            else
            {
                label1.Text = "Invalid username or password";
                label1.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
          
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            panel1.Controls.Add(new menuadmincs());
        }
    }
}
