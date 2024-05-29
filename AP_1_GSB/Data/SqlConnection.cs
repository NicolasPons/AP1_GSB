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

        public static void Connect()
        {
            try
            {
                Connection = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=ap1_winforms");
                Connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("dégouté la team la team");
            }
        }
    }
}
