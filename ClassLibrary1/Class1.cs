using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Client
    {
            public int IDClient { get; set; }
            public string NomClient { get; set; }
            public double CoefClient { get; set; }
            public int IDContactClient { get; set; }

    }
    public class ClientDAO
    {
        SqlConnection _connect;
        public ClientDAO(string chaine)
        {
            _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
        }
        public void Insert(Client cli)
        {
            SqlCommand requete = new SqlCommand("insert into Client(NomClient, CoefClient, IDContactClient) values(@NomClient, @CoefClient, @IDContactClient)", _connect);
            requete.Parameters.AddWithValue("@NomClient", cli.NomClient);
            requete.Parameters.AddWithValue("@CoefClient", cli.CoefClient);
            requete.Parameters.AddWithValue("@IDContactClient", cli.IDContactClient);
            requete.ExecuteNonQuery();
            SqlCommand requete2 = new SqlCommand("select max(IDClient) from Client", _connect);
            int ID_Client = (int)requete2.ExecuteScalar();
            cli.IDClient = ID_Client;
        }
        public void Update(Client cli)
        {
            SqlCommand requete = new SqlCommand("update into Client(NomClient, CoefClient, IDContactClient) values(@NomClient, @CoefClient, @IDContactClient)", _connect);
            requete.Parameters.AddWithValue("@NomClient", cli.NomClient);
            requete.Parameters.AddWithValue("@CoefClient", cli.CoefClient);
            requete.Parameters.AddWithValue("@IDContactClient", cli.IDContactClient);
            requete.ExecuteNonQuery();
           /* SqlCommand requete2 = new SqlCommand("update max(IDClient) from Client", _connect);
            int ID_Client = (int)requete2.ExecuteScalar();
            cli.IDClient = ID_Client;*/
        }
        public void Delete(Client cli)
        {
            SqlCommand requete = new SqlCommand("delete into Client(IDClient, NomClient, CoefClient, IDContactClient) values(@NomClient, @CoefClient, @IDContactClient)", _connect);
            requete.Parameters.Remove(cli.IDClient);
            requete.Parameters.Remove(cli.NomClient);
            requete.Parameters.Remove(cli.CoefClient);
            requete.Parameters.Remove(cli.IDContactClient);
            requete.ExecuteNonQuery();
            /*SqlCommand requete2 = new SqlCommand("select max(IDClient) from Client", _connect);
            int ID_Client = (int)requete2.ExecuteScalar();
            cli.IDClient = ID_Client;*/
        }
       /* public Client Find(int IDClient)
        {

        }*/
        public List<Client> Liste()
        {
            SqlConnection _connect;
             _connect = new SqlConnection("server=(local); integrated security = true; database = Fil_Rouge");
            _connect.Open();
            List<Client> resultat = new List<Client>();
            SqlCommand requete = new SqlCommand("select * from Client", _connect);
           
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Client c = new Client();
                c.IDClient = Convert.ToInt32(lecture["IDClient"]);
                c.NomClient = Convert.ToString(lecture["NomClient"]); 
                c.CoefClient = Convert.ToDouble(lecture["CoefClient"]);
                c.IDContactClient = Convert.ToInt32(lecture["IDContactClient"]);
                resultat.Add(c);
                
            }
            //Form1.listBox1.DataSource = Form1.repo.Liste();
            _connect.Close();
            return resultat;
        }
    }
}
