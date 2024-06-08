using AP_1_GSB.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
