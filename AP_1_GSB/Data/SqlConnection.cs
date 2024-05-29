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

        public static void ConnexionSql()
        {
            try
            {
                Connection = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=gsb_ap1");
                Connection.Open();
                MessageBox.Show("Connexion à la base de donnée réussie", "Connexion réussie");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "La connexion à la base de donnée a échoué");
            }
        }

        public static void DeconnexionSql()
        {
            Connection.Close();
        }
    }
}
