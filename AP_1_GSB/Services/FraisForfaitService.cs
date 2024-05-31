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
            if( frais != null && frais.IdFraisForfait > 0)
            {
                //Ta query ici

                //Si delete OK
                //if (cmd.ExecuteNonQuery() > 0)
                //{
                //    return true;
                //}

                //Si delete KO
                return false; 
            }

            return false;
        }
    }
}

