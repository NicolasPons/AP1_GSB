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
    public class FicheFraisService
    {
        public static Utilisateur RecupererFichesFrais(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();
            if (utilisateur != null && (utilisateur.IdUtilisateur) > 0)
            {
                try
                {
                    int idUtilisateur = utilisateur.IdUtilisateur;
                    string RequeteFichesFrais = "Select * FROM fiche_frais INNER JOIN type_etat ON type_etat.id_etat = fiche_frais.id_etat WHERE fiche_frais.id_utilisateur = @idUtilisateur";
                    MySqlCommand cmd = new MySqlCommand(RequeteFichesFrais, Data.SqlConnection.Connection);
                    cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<FicheFrais> listeFicheFrais = new List<FicheFrais>();
                    while (reader.Read())
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
                            Date = (DateTime)reader["date_fiche"],
                            Etat = etatFicheFrais
                        };
                        listeFicheFrais.Add(fichefrais);
                    }
                    utilisateur.FichesFrais = listeFicheFrais;
                    return utilisateur;
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

        //public static void RecupererFicheFrais(Utilisateur utilisateur)
        //{
        //    Data.SqlConnection.ConnexionSql();

        //    try
        //    {
        //        DateTime Date = DateTime.Now;
        //        int idUtilisateur = utilisateur.IdUtilisateur;
        //        string RequeteFicheFrais = "SELECT * FROM fiche_frais INNER JOIN type_etat ON type_etat.id_etat = fiche_frais.id_etat WHERE fiche_frais.id_utilisateur = @idUtilisateur AND MONTH(fiche_frais.date_fiche) = @mois";
        //        MySqlCommand cmd = new MySqlCommand(RequeteFicheFrais, Data.SqlConnection.Connection);
        //        cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
        //        cmd.Parameters.AddWithValue("@mois", Date.Month);

        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        List<FicheFrais> listeFicheFrais = new List<FicheFrais>();
        //        while (reader.Read())
        //        {
        //            string etat = (string)reader["nom"];
        //            EtatFicheFrais etatFicheFrais;

        //            switch (etat)
        //            {
        //                case "Accepter":
        //                    etatFicheFrais = EtatFicheFrais.Accepter;
        //                    break;
        //                case "Refuser":
        //                    etatFicheFrais = EtatFicheFrais.Refuser;
        //                    break;
        //                case "RefusPartiel":
        //                    etatFicheFrais = EtatFicheFrais.RefusPartiel;
        //                    break;
        //                default:
        //                    etatFicheFrais = EtatFicheFrais.Attente;
        //                    break;
        //            }

        //            FicheFrais fichefrais = new FicheFrais()
        //            {
        //                IdFicheFrais = (int)reader["id_fiche_frais"],
        //                Date = (DateTime)reader["date_fiche"],
        //                Etat = etatFicheFrais
        //            };
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("La requête a échoué : " + ex.Message);
        //    }
        //    finally
        //    {
        //        Data.SqlConnection.DeconnexionSql();
        //    }
        //}

        public static Utilisateur CreerFicheFraisMoisEnCours(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();
            int idUtilisateur = utilisateur.IdUtilisateur;
            DateTime DateCreationFiche = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 11);

            try
            {
                string RequeteCreationFiche = "INSERT INTO `fiche_frais` (`id_fiche_frais`, `date_fiche`, `id_utilisateur`, `id_etat`) VALUES (NULL, @date, @idUtilisateur, @idEtat);";
                MySqlCommand cmd = new MySqlCommand(RequeteCreationFiche, Data.SqlConnection.Connection);
                cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                cmd.Parameters.AddWithValue("@date", DateCreationFiche);
                cmd.Parameters.AddWithValue("idEtat", 1);

                int idFiche = Convert.ToInt32(cmd.ExecuteScalar());
                EtatFicheFrais EtatFiche = EtatFicheFrais.Attente;

                FicheFrais ficheFrais = new FicheFrais()
                {
                    IdFicheFrais = idFiche,
                    Date = DateCreationFiche,
                    Etat = EtatFiche
                };
                utilisateur.FichesFrais.Add(ficheFrais);
                return utilisateur;
            }
            catch (Exception e)
            {
                MessageBox.Show("La génération automatique de la fiche de frais du mois en cour a échoué : " + e.Message);
                return null;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
        }
    }
}

