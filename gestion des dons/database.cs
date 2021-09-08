using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_des_dons
{
    class database
    {

        public static String userid;
        public static String id;
        string connetionString = null;
        SqlConnection cnn;
        public database()
        {
            connetionString = "Data Source=DESKTOP-OCMHTF1;Initial Catalog=Dons;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
        }


        public void adddon(String nom ,String  prenom  , String adresse , String tele ,String type ,String desc , String Qt,String date  )
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[offre] ([Datereception] ,[Quantite] ,[description],[nom] ,[prenom] ,[adresse] ,[tele],[type]) VALUES(@d ,@q ,@desc , @nom ,@p ,@ad ,@tele ,@t)");
                cmd.Connection = cnn;
                cmd.Parameters.Add("@d", sqlDbType: System.Data.SqlDbType.NVarChar).Value = date;
                cmd.Parameters.Add("@q", sqlDbType: System.Data.SqlDbType.NVarChar).Value = Qt;
                cmd.Parameters.Add("@desc", sqlDbType: System.Data.SqlDbType.NVarChar).Value = desc;
                cmd.Parameters.Add("@nom", sqlDbType: System.Data.SqlDbType.NVarChar).Value = nom;
                cmd.Parameters.Add("@p", sqlDbType: System.Data.SqlDbType.NVarChar).Value = prenom;
                cmd.Parameters.Add("@ad", sqlDbType: System.Data.SqlDbType.NVarChar).Value = adresse;
                cmd.Parameters.Add("@tele", sqlDbType: System.Data.SqlDbType.NVarChar).Value = tele;
                cmd.Parameters.Add("@t", sqlDbType: System.Data.SqlDbType.NVarChar).Value = type;

                cmd.ExecuteNonQuery();
              
                cnn.Close();
            }
            catch (Exception ex)
            {
               
            }

        }

        public int checkuser(String nom, String mdp)
        {


            cnn.Open();

            SqlCommand cmd = new SqlCommand("select COUNT (*) FROM [Dons].[dbo].[Membre] WHERE [Nom] = @n and [mdp]= @m");
            cmd.Connection = cnn;
            cmd.Parameters.Add("@n", sqlDbType: System.Data.SqlDbType.NVarChar).Value = nom;

            cmd.Parameters.Add("@m", sqlDbType: System.Data.SqlDbType.NVarChar).Value = mdp;


            string s = cmd.ExecuteScalar().ToString();
            cnn.Close();

            return int.Parse(s);

        }

        public String getuserid(String id)
        {



            cnn.Open();
            SqlCommand cmd = new SqlCommand("select dbo.[Membre].Codemembre from  dbo.[Membre] where Codemembre = @id");
            cmd.Connection = cnn;
            cmd.Parameters.Add("@id", sqlDbType: System.Data.SqlDbType.NVarChar).Value = id;

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            String s = reader.GetValue(0).ToString();


            cnn.Close();
            return s;



        }

        public void addTRonsp(String Nom ,String Prenom)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Transporteur] ([Nom] ,[Prenom]) VALUES(@N , @P )");
            cmd.Connection = cnn;

            cmd.Parameters.Add("@N", sqlDbType: System.Data.SqlDbType.NVarChar).Value = Nom;
            cmd.Parameters.Add("@P", sqlDbType: System.Data.SqlDbType.NVarChar).Value = Prenom;


            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public void addvehic(String Nom, String type ,String Mark)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Vehicule] ([Nom] ,[Type],[Marque]) VALUES(@N , @t,@ma )");
            cmd.Connection = cnn;

            cmd.Parameters.Add("@N", sqlDbType: System.Data.SqlDbType.NVarChar).Value = Nom;
            cmd.Parameters.Add("@t", sqlDbType: System.Data.SqlDbType.NVarChar).Value = type;
            cmd.Parameters.Add("@ma", sqlDbType: System.Data.SqlDbType.NVarChar).Value = Mark;


            cmd.ExecuteNonQuery();

            cnn.Close();
        }




        public void delTrans(String id)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Transporteur] WHERE codeTransporteur = @id");
            cmd.Connection = cnn;

            cmd.Parameters.Add("@id", sqlDbType: System.Data.SqlDbType.Int).Value = id;
            


            cmd.ExecuteNonQuery();

            cnn.Close();
        }


        public void delvig(String id)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand(" DELETE FROM [dbo].[Vehicule] WHERE CodeVehicul = @id");
            cmd.Connection = cnn;

            cmd.Parameters.Add("@id", sqlDbType: System.Data.SqlDbType.Int).Value = id;



            cmd.ExecuteNonQuery();

            cnn.Close();
        }



        public void deluser(String id)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Membre] WHERE Codemembre = @id");
            cmd.Connection = cnn;

            cmd.Parameters.Add("@id", sqlDbType: System.Data.SqlDbType.Int).Value = id;



            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public void addoffracc(String ofre, String mebre, String Dattrens  ,  String trans ,  String vehic,  String lieux, String dateacceptation)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[OffreAccepté] ([refOffre] ,[codemembre]  ,[Datetransport] ,[codetransporteur] ,[codevehicule] ,[lieu],[dateaccept]) VALUES(@of , @mbr,@dattr ,@trans , @vehic , @lieu ,@dateacc )");
            cmd.Connection = cnn;

            cmd.Parameters.Add("@of", sqlDbType: System.Data.SqlDbType.Int).Value = ofre;
            cmd.Parameters.Add("@mbr", sqlDbType: System.Data.SqlDbType.Int).Value = mebre;
            cmd.Parameters.Add("@dattr", sqlDbType: System.Data.SqlDbType.NVarChar).Value = Dattrens;
            cmd.Parameters.Add("@trans", sqlDbType: System.Data.SqlDbType.Int).Value = trans;
            cmd.Parameters.Add("@vehic", sqlDbType: System.Data.SqlDbType.Int).Value = vehic;
            cmd.Parameters.Add("@lieu", sqlDbType: System.Data.SqlDbType.NVarChar).Value = lieux;
            cmd.Parameters.Add("@dateacc", sqlDbType: System.Data.SqlDbType.NVarChar).Value = dateacceptation;

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public String getofferlieux(String id)
        {



            cnn.Open();
            SqlCommand cmd = new SqlCommand("FROM [dbo].[OffreAccepté] where OffreAccepté.codeoffreaccept =  @id");
            cmd.Connection = cnn;
            cmd.Parameters.Add("@id", sqlDbType: System.Data.SqlDbType.Int).Value = id;

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            String s = reader.GetValue(0).ToString();


            cnn.Close();
            return s;



        }

        public void addvent(String idofr, String priest     , String prixvent, String nom   , String prenom , String tele)
        {

         
                cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[vente] ([idoffreacc] ,[prixest] ,[prixvente]  ,[nom] ,[prenom],[tele]) VALUES(@d ,@q ,@desc , @nom ,@p ,@ad )");
                cmd.Connection = cnn;
                cmd.Parameters.Add("@d", sqlDbType: System.Data.SqlDbType.Int).Value = idofr;
                cmd.Parameters.Add("@q", sqlDbType: System.Data.SqlDbType.Float).Value = priest;
                cmd.Parameters.Add("@desc", sqlDbType: System.Data.SqlDbType.Float).Value = prixvent;
                cmd.Parameters.Add("@nom", sqlDbType: System.Data.SqlDbType.NVarChar).Value = nom;
                cmd.Parameters.Add("@p", sqlDbType: System.Data.SqlDbType.NVarChar).Value = prenom;
                cmd.Parameters.Add("@ad", sqlDbType: System.Data.SqlDbType.NVarChar).Value = tele;
                

                cmd.ExecuteNonQuery();

                cnn.Close();
           

        }

        public void addepot(String idofr, String date ,String prixvent, String nom, String prenom, String tele)
        {

              cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[depo] ([iddon]  ,[date]  ,[montant] ,[nom]  ,[prenom] ,[tele]) VALUES(@d ,@q ,@desc , @nom ,@p ,@ad )");
                cmd.Connection = cnn;
                cmd.Parameters.Add("@d", sqlDbType: System.Data.SqlDbType.Int).Value = idofr;
                cmd.Parameters.Add("@q", sqlDbType: System.Data.SqlDbType.NVarChar).Value = date;
                cmd.Parameters.Add("@desc", sqlDbType: System.Data.SqlDbType.Float).Value = prixvent;
                cmd.Parameters.Add("@nom", sqlDbType: System.Data.SqlDbType.NVarChar).Value = nom;
                cmd.Parameters.Add("@p", sqlDbType: System.Data.SqlDbType.NVarChar).Value = prenom;
                cmd.Parameters.Add("@ad", sqlDbType: System.Data.SqlDbType.NVarChar).Value = tele;


                cmd.ExecuteNonQuery();

                cnn.Close();
                 
            

        }


    }
}
