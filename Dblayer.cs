using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Eksamen1
{
    public class Dblayer
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        public List<Bobjects> GetAllElevDataFromElevByJoin()
        {
            try
            {
                List<Bobjects> ElevData = new List<Bobjects>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn, Etternavn, Adresse, Poststeder.PostNr, Poststed, Fagnavn, Klassenavn FROM Elev INNER JOIN FagElev ON FagElev.ElevID = Elev.ElevID INNER JOIN Fag ON Fag.FagKode = FagElev.FagKode INNER JOIN Klasse ON Klasse.KlasseID = Elev.KlasseID INNER JOIN Poststeder ON Poststeder.PostNr = Elev.PostNr ORDER BY Fornavn", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bobjects ed = new Bobjects();
                    ed.Fornavn = (string)reader["Fornavn"];
                    ed.Etternavn = (string)reader["Etternavn"];
                    ed.Adresse = (string)reader["Adresse"];
                    ed.PostNr = (int)reader["PostNr"];
                    ed.Poststed = (string)reader["Poststed"];
                    ed.Klassenavn = (string)reader["Klassenavn"];
                    ed.Fagnavn = (string)reader["Fagnavn"];
                    ElevData.Add(ed);
                }
                reader.Close();
                conn.Close();

                return ElevData;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}