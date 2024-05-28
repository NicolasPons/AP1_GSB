using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace AP_1_GSB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Data.Sql.Connect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Data.Sql.Connection.Close();
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {


            //Sur le click du LOGIN

            //Co sur la BDD MySQL.
            Data.Sql.Connect();
            //Vérification des informations du login. (username / password)
            string nomUtilisateur = username_textbox.Text;
            string motDePasse = password_textbox.Text;

            string RequeteIdMdp = "SELECT * FROM UTILISATEUR WHERE identifiant = @nomUtilisateur AND mdp = @motDePasse";
            MySqlCommand cmd = new MySqlCommand(RequeteIdMdp, Data.Sql.Connection);
            cmd.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
            cmd.Parameters.AddWithValue("@motDePasse", motDePasse);
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                int role = (int)reader["id_role"];

                switch (role)
                {
                    case 1:
                        MessageBox.Show("visiteur");
                        break;

                    case 2:
                        MessageBox.Show("comptable");
                        break;

                    case 3:
                        MessageBox.Show("administrateur");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
