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
    internal class FraisHorsForfaitService
    {
        public static bool SupprimerFraisHorsForfait(FraisHorsForfait frais)
        {
            int IdFrais = frais.IdFraisHorsForfait;

            if (frais != null && frais.IdFraisHorsForfait > 0)
            {
                Data.SqlConnection.ConnexionSql();

                string requete = "DELETE FROM frais_hors_forfait  WHERE id_hors_forfait = @IdFraisHorsForfait";

                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@IdFraisHorsForfait", IdFrais);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public static bool AjouterFraisHorsForfait(int IdFiche, string description, DateTime dateFrais, int montant, byte[] FichierBinaire)
        {
            int idJustificatif = 0;
            if (FichierBinaire != null)
            {
                Justificatif justi = JustificatifService.AjouterJustificatif(FichierBinaire);
                idJustificatif = justi.IdJustificatif;
            }

            Data.SqlConnection.ConnexionSql();

            string RequeteCreationFraisHorsForfait = "INSERT INTO `frais_hors_forfait` (`description`, `montant`, `date`, `etat`, `id_fiche_frais`, `id_justificatif`) " +
                                                     "VALUES (@description, @montant, @date, @etat, @IdFiche, @idJustificatif)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(RequeteCreationFraisHorsForfait, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@montant", montant);
                    cmd.Parameters.AddWithValue("@date", dateFrais);
                    cmd.Parameters.AddWithValue("@etat", "ATTENTE");
                    cmd.Parameters.AddWithValue("@IdFiche", IdFiche);
                    cmd.Parameters.AddWithValue("@idJustificatif", idJustificatif == 0 ? (object)DBNull.Value : idJustificatif);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + e.Message);
                return false;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }

            return false;
        }

    }
}
