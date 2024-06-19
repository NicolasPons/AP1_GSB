using System;
using System.Collections.Generic;
using AP_1_GSB.Data.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AP_1_GSB.Services
{
    internal class VisiteurService
    {
        public static List<Utilisateur> RecupererVisiteur()
        {
            List<Utilisateur> visiteurs = new List<Utilisateur>();

            Data.SqlConnection.ConnexionSql();

            try
            {
                string requete = "Select * FROM Utilisateur WHERE id_role = '1'";
                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Utilisateur visiteur = new Utilisateur()
                            {
                                IdUtilisateur = (int)reader["id_utilisateur"],
                                Identifiant = (string)reader["identifiant"],
                                Nom = (string)reader["nom"],
                                Prenom = (string)reader["prenom"],
                                Email = (string)reader["email"]
                            };
                            visiteurs.Add(visiteur);
                        }
                    }
                }

                return visiteurs;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
        }
    }
}
