using AP_1_GSB.Data.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Services
{
    internal class AuthentificationService
    {
        public static Utilisateur VerificationUtilisateur(string utilisateur, string mdp)
        {
            Data.SqlConnection.ConnexionSql();

            if (!string.IsNullOrEmpty(utilisateur) && !string.IsNullOrEmpty(mdp))
            {
                try
                {
                    string RequeteIdMdp = "SELECT id_utilisateur, identifiant, mdp, utilisateur.nom, prenom, email, role.nom FROM UTILISATEUR INNER JOIN role ON utilisateur.id_role = role.id_role WHERE identifiant = @utilisateur AND mdp = @mdp";

                    MySqlCommand cmd = new MySqlCommand(RequeteIdMdp, Data.SqlConnection.Connection);

                    cmd.Parameters.AddWithValue("@Utilisateur", utilisateur);
                    cmd.Parameters.AddWithValue("@mdp", mdp);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = (string)reader["nom"];
                        UtilisateurRole utilisateurRole = UtilisateurRole.Visiteur;

                        switch (role)
                        {
                            case "visiteur":
                                utilisateurRole = UtilisateurRole.Visiteur;
                                break;
                            case "comptable":
                                utilisateurRole = UtilisateurRole.Comptable;
                                break;
                            case "administrateur":
                                utilisateurRole = UtilisateurRole.Administrateur;
                                break;
                        }

                        Utilisateur nouvelUtilisateur = new Utilisateur()
                        {
                            IdUtilisateur = (int)reader["id_utilisateur"],
                            Identifiant = (string)reader["identifiant"],
                            Mdp = (string)reader["mdp"],
                            Nom = (string)reader["nom"],
                            Prenom = (string)reader["prenom"],
                            Email = (string)reader["email"],
                            Role = utilisateurRole
                        };
                        return nouvelUtilisateur;
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                catch (MySqlException e)
                {
                    MessageBox.Show("Erreur lors de la connexion : " + e.Message);
                    return null;
                }
                finally
                {
                    Data.SqlConnection.DeconnexionSql();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Data.SqlConnection.DeconnexionSql();
                return null;
            }
            Data.SqlConnection.DeconnexionSql();
            return null;
        }
    }
}
