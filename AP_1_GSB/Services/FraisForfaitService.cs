using AP_1_GSB.Data.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
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
    public class FraisForfaitService
    {
        public static bool SupprimerFraisForfait(FraisForfait frais)
        {
            int IdFrais= frais.IdFraisForfait;

            if( frais != null && frais.IdFraisForfait > 0)
            {
                Data.SqlConnection.ConnexionSql();

                string requete = "DELETE FROM frais_forfait WHERE id_frais_forfait = @IdFraisForfait";

                using (MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@IdFraisForfait", IdFrais);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                return false; 
            }
            return false;
        }

        public static bool AjouterFraisForfait(int IdFiche, int typeForfait, DateTime date, int quantite, byte[] justificatif)
        {
            int idJustificatif = 0;
            if (justificatif != null )
            {
            Justificatif justi;
            justi = Services.JustificatifService.AjouterJustificatif(justificatif); 
            idJustificatif = justi.IdJustificatif;
            }

            Data.SqlConnection.ConnexionSql();

            string RequeteCreationFraisForfait = "INSERT INTO frais_forfait (quantite, date, etat, id_type_forfait, id_fiche_frais, id_justificatif) " +
                                                "VALUES (@quantite, @Date, @etat, @id_type_forfait, @id_fiche_frais, @id_justificatif)";

            try
            {
                using(MySqlCommand cmd = new MySqlCommand(RequeteCreationFraisForfait, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@quantite", quantite);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@etat", "ATTENTE");
                    cmd.Parameters.AddWithValue("@id_type_forfait", typeForfait);
                    cmd.Parameters.AddWithValue("@id_fiche_frais", IdFiche);
                    cmd.Parameters.AddWithValue("@id_Justificatif", idJustificatif == 0 ? (object)DBNull.Value : idJustificatif);

                    if (cmd.ExecuteNonQuery() > 0) 
                        { return true; }
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de donné : " + e.Message);
                return false;
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
            return false;
        }

        public static bool ModifierFraisForfait(int IdFrais, int typeForfait, DateTime date, int quantite, byte[] justificatif)
        {
            int idJustificatif = 0;
            if (justificatif != null)
            {
                Justificatif justi;
                justi = Services.JustificatifService.AjouterJustificatif(justificatif);
                idJustificatif = justi.IdJustificatif;
            }

            Data.SqlConnection.ConnexionSql();

            string RequeteModificationFraisForfait = "UPDATE frais_forfait SET quantite = @quantite, date = @Date, etat = @etat, id_type_forfait = @id_type_forfait, id_justificatif = @id_justificatif" +
                " WHERE id_frais_forfait = @IdFraisForfait";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(RequeteModificationFraisForfait, Data.SqlConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@quantite", quantite);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@etat", "ATTENTE");
                    cmd.Parameters.AddWithValue("@id_type_forfait", typeForfait);
                    cmd.Parameters.AddWithValue("@id_justificatif", idJustificatif == 0 ? (object)DBNull.Value : idJustificatif);
                    cmd.Parameters.AddWithValue("@IdFraisForfait", IdFrais);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de donné : " + e.Message);
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

               
