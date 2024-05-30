using AP_1_GSB.Data.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Pqc.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Services
{
    public class RecuperationFicheFrais
    {

        public FicheFrais RecupererFicheFrais(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();
            if (utilisateur != null && (utilisateur.IdUtilisateur) > 0)
            {
                try
                {
                    int idUtilisateur = utilisateur.IdUtilisateur;
                    string RequeteFicheFrais = "Select * FROM fiche_frais INNER JOIN type_etat ON type_etat.id_etat = fiche_frais.id_eta WHERE fiche_frais.id_utilisateur = @idUtilisateur";
                    MySqlCommand cmd = new MySqlCommand(RequeteFicheFrais, Data.SqlConnection.Connection);
                    cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string etat = (string)reader["nom"];
                        EtatFicheFrais etatFicheFrais;

                        switch (etat)
                        {
                            case "Accepter":
                                etatFicheFrais = EtatFicheFrais.Accepter;
                                break;
                            case "Refuser":
                                etatFicheFrais = EtatFicheFrais.Refuser;
                                break;
                            case "RefusPartiel":
                                etatFicheFrais = EtatFicheFrais.RefusPartiel;
                                break;
                            default:
                                etatFicheFrais = EtatFicheFrais.Attente;
                                break;
                        }

                        FicheFrais fichefrais = new FicheFrais()
                        {
                            IdFicheFrais = (int)reader["id_fiche_frais"],
                            Date = (DateTime)reader["date"],
                            Etat = etatFicheFrais
                        };

                        return fichefrais;
                    }
                    else
                    {
                        MessageBox.Show("Aucune fiche de frais n'a été trouvée pour cet utilisateur");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de la fiche de frais : " + ex.Message);
                    return null;
                }
                finally
                {
                    Data.SqlConnection.DeconnexionSql();
                }
            }
            else
            {
                MessageBox.Show("Utilisateur non trouvé");
                Data.SqlConnection.DeconnexionSql();
                return null;
            }
        }
    }
}
