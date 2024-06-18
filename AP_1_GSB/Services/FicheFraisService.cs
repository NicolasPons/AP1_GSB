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
        public static FicheFrais RecupererDerniereFiche(Utilisateur utilisateur, DateTime dateDebut, DateTime datetFin)
        {
            FicheFrais ficheEnCours = null;
            DateTime now = DateTime.Now;

            if (now.Day >= 11)
            {
                dateDebut = new DateTime(now.Year, now.Month, 11);
                datetFin = new DateTime(now.Year, now.Month + 1, 10);
            }
            else
            {
                dateDebut = new DateTime(now.Year, now.Month - 1, 11);
                datetFin = new DateTime(now.Year, now.Month, 10);
            }

            utilisateur.FichesFrais.ForEach
                (
                    ficheFrais =>
                    {
                        if (ficheFrais.Date >= dateDebut && ficheFrais.Date <= datetFin)
                        {
                            ficheEnCours = ficheFrais;
                        }
                    }
                );

            if (ficheEnCours == null)
            {
                utilisateur = Services.FicheFraisService.CreerFicheFraisMoisEnCours(utilisateur, dateDebut);
                ficheEnCours = utilisateur.FichesFrais.Last();
            }
            return ficheEnCours;
        }


        private static Justificatif CreerJustificatif(MySqlDataReader reader)
        {
            Justificatif justi = null;
            if (reader["id_justificatif"] != DBNull.Value)
            {
                justi = new Justificatif()
                {
                    IdJustificatif = (int)reader["id_justificatif"],
                    FichierBlob = reader["fichier"] == DBNull.Value ? null : (byte[])reader["fichier"],
                };
            }
            return justi;
        }
        public static Utilisateur RecupererFichesFrais(Utilisateur utilisateur)
        {
            Data.SqlConnection.ConnexionSql();
            if (utilisateur != null && (utilisateur.IdUtilisateur) > 0)
            {
                try
                {
                    int idUtilisateur = utilisateur.IdUtilisateur;
                    string RequeteFichesFrais = "Select * FROM fiche_frais " +
                                                "INNER JOIN type_etat ON type_etat.id_etat = fiche_frais.id_etat " +
                                                "WHERE fiche_frais.id_utilisateur = @idUtilisateur";
                    using (MySqlCommand cmd = new MySqlCommand(RequeteFichesFrais, Data.SqlConnection.Connection))
                    {


                        cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<FicheFrais> listeFicheFrais = new List<FicheFrais>();
                            while (reader.Read())
                            {
                                string etat = ((string)reader["nom"]).ToLower();
                                EtatFicheFrais etatFicheFrais;

                                switch (etat)
                                {
                                    case "accepter":
                                        etatFicheFrais = EtatFicheFrais.Accepter;
                                        break;
                                    case "refuser":
                                        etatFicheFrais = EtatFicheFrais.Refuser;
                                        break;
                                    case "refus_partiel":
                                        etatFicheFrais = EtatFicheFrais.RefusPartiel;
                                        break;
                                    case "hors_delai":
                                        etatFicheFrais = EtatFicheFrais.HorsDelai;
                                        break;
                                    default:
                                        etatFicheFrais = EtatFicheFrais.EnCours;
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


        public static Utilisateur RecupererNotesForfait(Utilisateur utilisateur, FicheFrais FicheEnCours)
        {
            Data.SqlConnection.ConnexionSql();
            if (utilisateur != null && (utilisateur.IdUtilisateur) > 0 && FicheEnCours != null)
            {
                try
                {
                    int idFicheFrais = FicheEnCours.IdFicheFrais;
                    string RequeteNotesForfait = "SELECT id_frais_forfait, quantite, date, etat, frais_forfait.id_justificatif, justificatif.fichier," +
                                                "type_frais_forfait.id_type_forfait, type_frais_forfait.nom, type_frais_forfait.montant " +
                                                "FROM `frais_forfait` " +
                                                "LEFT JOIN justificatif ON justificatif.id_justificatif = frais_forfait.id_justificatif " +
                                                "INNER JOIN type_frais_forfait on frais_forfait.id_type_forfait = type_frais_forfait.id_type_forfait " +
                                                "WHERE frais_forfait.id_fiche_frais = @idFicheFrais";
                    using (MySqlCommand cmd = new MySqlCommand(RequeteNotesForfait, Data.SqlConnection.Connection))
                    {
                        cmd.Parameters.AddWithValue("@idFicheFrais", idFicheFrais);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<FraisForfait> listeNotesFrais = new List<FraisForfait>();
                            while (reader.Read())
                            {
                                string etatNoteFrais = ((string)reader["etat"]).ToLower();
                                EtatFraisForfait etatNote;

                                switch (etatNoteFrais)
                                {
                                    case "accepter":
                                        etatNote = EtatFraisForfait.Accepter;
                                        break;
                                    case "refuser":
                                        etatNote = EtatFraisForfait.Refuser;
                                        break;
                                    default:
                                        etatNote = EtatFraisForfait.Attente;
                                        break;
                                }

                                Justificatif justi = CreerJustificatif(reader);

                                //CREER METHODE YA ZEUBI


                                TypeFraisForfait typeFraisForfait = new TypeFraisForfait()
                                {
                                    IdFraisForfait = (int)reader["id_type_forfait"],
                                    Nom = (string)reader["nom"],
                                    Montant = (float)reader["montant"]
                                };

                                if (typeFraisForfait.Nom == "frais_km")
                                {
                                    typeFraisForfait.Nom = "Frais kilométrique";
                                }
                                else if (typeFraisForfait.Nom == "Nuitee")
                                {
                                    typeFraisForfait.Nom = "Nuitée";
                                }

                                FraisForfait noteFrais = new FraisForfait()
                                {
                                    IdFraisForfait = (int)reader["id_frais_forfait"],
                                    Quantite = (int)reader["quantite"],
                                    Date = (DateTime)reader["date"],
                                    Etat = etatNote,
                                    TypeForfait = typeFraisForfait,
                                    justificatif = justi,
                                };
                                listeNotesFrais.Add(noteFrais);
                            }
                            FicheEnCours.FraisForfaits = listeNotesFrais;
                        }
                    }
                    return utilisateur;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des notes de frais forfait : " + ex.Message);
                    return null;
                }

                finally
                {
                    Data.SqlConnection.DeconnexionSql();
                }
            }
            else
            {
                MessageBox.Show("Fiche de frais non trouvé");
                Data.SqlConnection.DeconnexionSql();
                return null;
            }
        }
        public static Utilisateur RecupererNotesHorsForfait(Utilisateur utilisateur, FicheFrais FicheEnCours)
        {
            Data.SqlConnection.ConnexionSql();
            if (utilisateur != null && (utilisateur.IdUtilisateur) > 0 && FicheEnCours != null)
            {
                try
                {
                    int idFicheFrais = FicheEnCours.IdFicheFrais;

                    string RequeteNotesForfait = "SELECT id_hors_forfait, description, frais_hors_forfait.montant, date, frais_hors_forfait.etat, frais_hors_forfait.id_justificatif, justificatif.fichier " +
                                                 "FROM frais_hors_forfait LEFT JOIN justificatif ON justificatif.id_justificatif = frais_hors_forfait.id_justificatif " +
                                                 "WHERE frais_hors_forfait.id_fiche_frais = @idFicheFrais";
                    using (MySqlCommand cmd = new MySqlCommand(RequeteNotesForfait, Data.SqlConnection.Connection))
                    {
                        cmd.Parameters.AddWithValue("@idFicheFrais", idFicheFrais);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<FraisHorsForfait> listeHorsForfait = new List<FraisHorsForfait>();
                            while (reader.Read())
                            {
                                string etatNoteFrais = ((string)reader["etat"]).ToLower();
                                EtatFraisHorsForfait etatNote;

                                switch (etatNoteFrais)
                                {
                                    case "accepter":
                                        etatNote = EtatFraisHorsForfait.Accepter;
                                        break;
                                    case "refuser":
                                        etatNote = EtatFraisHorsForfait.Refuser;
                                        break;
                                    default:
                                        etatNote = EtatFraisHorsForfait.Attente;
                                        break;
                                }

                                Justificatif justi = null;
                                justi = CreerJustificatif(reader);

                                FraisHorsForfait fraisHorsForfait = new FraisHorsForfait()
                                {
                                    IdFraisHorsForfait = (int)reader["id_hors_forfait"],
                                    Description = (string)reader["description"],
                                    Montant = (float)reader["montant"],
                                    Date = (DateTime)reader["date"],
                                    Etat = etatNote,
                                    Justificatif = justi,
                                };
                                listeHorsForfait.Add(fraisHorsForfait);
                            }
                            FicheEnCours.FraisHorsForfaits = listeHorsForfait;
                        }
                    }

                    return utilisateur;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des notes de frais hors forfait : " + ex.Message);
                    return null;
                }
                finally
                {
                    Data.SqlConnection.DeconnexionSql();
                }
            }
            else
            {
                MessageBox.Show("Fiche de frais non trouvé");
                Data.SqlConnection.DeconnexionSql();
                return null;
            }
        }

        public static Utilisateur CreerFicheFraisMoisEnCours(Utilisateur utilisateur, DateTime DateCreationFiche)
        {
            Data.SqlConnection.ConnexionSql();
            int idUtilisateur = utilisateur.IdUtilisateur;

            try
            {
                string RequeteCreationFiche = "INSERT INTO `fiche_frais` (`id_fiche_frais`, `date_fiche`, `id_utilisateur`, `id_etat`) " +
                                                "VALUES (NULL, @date, @idUtilisateur, @idEtat); SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(RequeteCreationFiche, Data.SqlConnection.Connection);
                cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                cmd.Parameters.AddWithValue("@date", DateCreationFiche);
                cmd.Parameters.AddWithValue("idEtat", 2);

                int idFiche = Convert.ToInt32(cmd.ExecuteScalar());

                EtatFicheFrais EtatFiche = EtatFicheFrais.EnCours;

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

        public static float CalculerTotalFiche(FicheFrais ficheEnCours)
        {
            float totalFiche = 0;
            foreach (FraisHorsForfait frais in ficheEnCours.FraisHorsForfaits)
            {
                totalFiche += frais.Montant;
            }

            foreach (FraisForfait frais in ficheEnCours.FraisForfaits)
            {
                totalFiche += frais.Quantite * frais.TypeForfait.Montant;
            }
            return totalFiche;
        }
        public static bool ChangerEtatFiche(FicheFrais ficheEnCours, int idEtat)
        {
            Data.SqlConnection.ConnexionSql();

            int idFiche = ficheEnCours.IdFicheFrais;
            string requete = "UPDATE fiche_frais SET id_etat = @id_etat WHERE id_fiche_frais = @id_Fiche; ";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@id_Fiche", idFiche);
                    cmd.Parameters.AddWithValue("@id_etat", idEtat);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors du changement d'état :" + ex.Message);
                return false;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
            return false;
        }

        public static string EcrireEtat(FicheFrais ficheEnCours)
        {
            string etat = "";
            switch (ficheEnCours.Etat)
            {
                case EtatFicheFrais.EnCours:
                    etat = "En cours";
                    break;
                case EtatFicheFrais.Accepter:
                    etat = "Acceptée";
                    break;
                case EtatFicheFrais.Refuser:
                    etat = "Refusée";
                    break;
                case EtatFicheFrais.RefusPartiel:
                    etat = "Refusée partiellement";
                    break;
                case EtatFicheFrais.HorsDelai:
                    etat = "Hors délai";
                    break;
            }
            return etat;
        }


    }


}