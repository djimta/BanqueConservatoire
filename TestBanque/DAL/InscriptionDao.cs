using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBanque.Model;
using MySql.Data.MySqlClient;



namespace TestBanque.DAL
{
    class InscriptionDao
    {
        private ConnectionSql maConnectionSql;
        private MySqlCommand Ocom;
        public List<Inscritption> GetInscritptions(int idAdhérent)
        {
            List<Inscritption> L_inscr = new List<Inscritption>();
            try
            {
                maConnectionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);
                maConnectionSql.openConnection();

                Ocom = maConnectionSql.reqExec("Select idCours, cours.jourDate, inscription.paye from inscription INNER JOIN cours On cours.id = inscription.idCours WHERE idStudent = "+ idAdhérent+";");


                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {

                    int idP = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);

                    Inscritption a = new Inscription(idP, nom, prenom);

                    L_inscr.Add(a);
                }
                reader.Close();
                maConnexionSql.closeConnection();
            }
            catch (Exception e)
            {
                throw (new Exception("" + e));
            }
            return L_inscr;
        }
    }
}