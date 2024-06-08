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
    }
}

                //Ta query ici

                //Si delete OK
                //if (cmd.ExecuteNonQuery() > 0)
                //{
                //    return true;
                //}

                //Si delete KO
