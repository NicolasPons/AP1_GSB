using System;
using System.Collections.Generic;
using AP_1_GSB.Data.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AP_1_GSB.Services
{
    internal class UtilisateurService
    {
        public static List<Utilisateur> RecupererVisiteurs()
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

        public static List<Utilisateur> RecupererUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            Data.SqlConnection.ConnexionSql();

            try
            {
                string requete = "Select * FROM Utilisateur INNER JOIN role ON role.id_role = utilisateur.id_role";
                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader.GetString(8);
                            UtilisateurRole roleUtilisateur = UtilisateurRole.Visiteur;

                            switch (role)
                            {
                                case "visiteur":
                                    roleUtilisateur = UtilisateurRole.Visiteur;
                                    break;
                                case "comptable":
                                    roleUtilisateur = UtilisateurRole.Comptable;
                                    break;
                                case "administrateur":
                                    roleUtilisateur = UtilisateurRole.Administrateur;
                                    break;
                            }

                            Utilisateur visiteur = new Utilisateur()
                            {
                                IdUtilisateur = (int)reader["id_utilisateur"],
                                Identifiant = (string)reader["identifiant"],
                                Nom = (string)reader["nom"],
                                Prenom = (string)reader["prenom"],
                                Email = (string)reader["email"],
                                Role = roleUtilisateur
                            };
                            utilisateurs.Add(visiteur);
                        }
                    }
                }

                return utilisateurs;
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

        public static bool CreerUtilisateur(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();

            int role = (int)utilisateur.Role + 1;

            try
            {
                string requete = "INSERT INTO Utilisateur (identifiant, mdp, nom, prenom, email, id_role) VALUES (@identifiant, @mdp, @nom, @prenom, @email, @role)";
                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@identifiant", utilisateur.Identifiant);
                    cmd.Parameters.AddWithValue("@mdp", utilisateur.Mdp);
                    cmd.Parameters.AddWithValue("@nom", utilisateur.Nom);
                    cmd.Parameters.AddWithValue("@prenom", utilisateur.Prenom);
                    cmd.Parameters.AddWithValue("@email", utilisateur.Email);
                    cmd.Parameters.AddWithValue("@role", role);
                    if (cmd.ExecuteNonQuery() >0)
                       return true;    
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur lors de la création de l'utilisateur : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
            return false;
        }

        public static bool ModifierUtilisateur(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();
            int role = (int)utilisateur.Role + 1;

            try
            {
                string requete = "UPDATE Utilisateur SET identifiant = @identifiant, mdp = @mdp, nom = @nom, prenom = @prenom, email = @email, id_role = @role WHERE id_utilisateur = @id";
                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@identifiant", utilisateur.Identifiant);
                    cmd.Parameters.AddWithValue("@mdp", utilisateur.Mdp);
                    cmd.Parameters.AddWithValue("@nom", utilisateur.Nom);
                    cmd.Parameters.AddWithValue("@prenom", utilisateur.Prenom);
                    cmd.Parameters.AddWithValue("@email", utilisateur.Email);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", utilisateur.IdUtilisateur);
                    if (cmd.ExecuteNonQuery() >0)
                       return true;    
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur lors de la modification de l'utilisateur : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
            return false;
        }


        public static bool SupprimerUtilisateur(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();

            try
            {
                string requete = "DELETE FROM Utilisateur WHERE id_utilisateur = @id";
                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", utilisateur.IdUtilisateur);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur lors de la suppression de l'utilisateur : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
        }
    }
}
