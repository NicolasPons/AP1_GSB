using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Data
{
    internal class SqlConnection
    {
        public static MySqlConnection Connection;

        //Ouvre la connexion SQL 
        public static void ConnexionSql()
        {
            try
            {
                Connection = new MySqlConnection("server=127.0.0.1;port=3307;uid=root;pwd=root;database=gsb1");
                Connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "La connexion à la base de donnée a échoué"); 
            }
        }
        //Ferme la connexion SQL 
        public static void DeconnexionSql()
        {
            Connection.Close();
        }
    }
}
