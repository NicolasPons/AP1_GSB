using AP_1_GSB.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Services
{
    internal class LoginService
    {
        public Utilisateur VerificationUtilisateur(string utilisateur, string mdp)
        {
            Data.SqlConnection.Connect();

            if (!string.IsNullOrEmpty(utilisateur) && !string.IsNullOrEmpty(mdp))
            {
                try
                {
                    string RequeteIdMdp = "SELECT id_utilisateur, identifiant, mdp, role.id_role, role.nom FROM UTILISATEUR INNER JOIN role ON utilisateur.id_role = role.id_role WHERE identifiant = @nomUtilisateur AND mdp = @motDePasse";

                    MySqlCommand cmd = new MySqlCommand(RequeteIdMdp, Data.SqlConnection.Connection);

                    cmd.Parameters.AddWithValue("@nomUtilisateur", utilisateur);
                    cmd.Parameters.AddWithValue("@motDePasse", mdp);

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

                        Utilisateur newUtilisateur = new Utilisateur()
                        {
                            IdUtilisateur = (int)reader["id_utilisateur"],
                            Identifiant = (string)reader["identifiant"],
                            Mdp = (string)reader["mdp"],
                            Role = utilisateurRole
                        };

                        return newUtilisateur;
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch 
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            return null;
        }
    }
}