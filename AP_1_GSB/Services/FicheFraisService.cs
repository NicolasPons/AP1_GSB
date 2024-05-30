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
                    string RequeteFicheFrais = "Select * FROM fiche_frais INNER JOIN type_etat ON type_etat.id_etat = fiche_frais.id_etat WHERE fiche_frais.id_utilisateur = @idUtilisateur";
                    MySqlCommand cmd = new MySqlCommand(RequeteFicheFrais, Data.SqlConnection.Connection);
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

        //public static void CreerFicheFraisMoisEnCours()
        //{
        //    Data.SqlConnection.ConnexionSql();

        //    try
        //    {

        //    }

        //}
    }
}

        //public static void CreationFicheEncours()
        //{
        //    Data.SqlConnection.ConnexionSql();
        //    try
        //    {
        //        string RequeteCreationFiche = "INSERT INTO fiche_frais (date, id_utilisateur, id_etat) VALUES (@date, @idUtilisateur, @idEtat)";
        //        MySqlCommand cmd = new MySqlCommand(RequeteCreationFiche, Data.SqlConnection.Connection);
        //        cmd.Parameters.AddWithValue("@date", DateTime.Now);
        //        cmd.Parameters.AddWithValue("@idUtilisateur", 1);
        //        cmd.Parameters.AddWithValue("@idEtat", 1);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur lors de la création de la fiche de frais : " + ex.Message);
        //    }
        //    finally
        //    {
        //        Data.SqlConnection.DeconnexionSql();
        //    }
        //}