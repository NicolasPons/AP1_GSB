using System;
using System.Collections.Generic;
using AP_1_GSB.Data.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AP_1_GSB.Services
{
    internal class TypeFraisForfaitService
    {
        public static List<TypeFraisForfait> RecupererTypeFraisForfait()
        {
            Data.SqlConnection.ConnexionSql();
            List<TypeFraisForfait> listeFrais = new List<TypeFraisForfait>();
            string requete = "SELECT * FROM type_frais_forfait";    
            try
            {
                using(MySqlCommand cmd = new MySqlCommand(requete, Data.SqlConnection.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TypeFraisForfait Typefrais = new TypeFraisForfait();
                            Typefrais.IdFraisForfait = reader.GetInt32(0);
                            Typefrais.Nom = reader.GetString(1);
                            Typefrais.Montant = reader.GetFloat(2);

                            if (Typefrais.Nom == "frais_km")
                            {
                                Typefrais.Nom = "Frais kilométrique";
                            }
                            else if (Typefrais.Nom == "Nuitee")
                            {
                                Typefrais.Nom = "Nuitée";
                            }
                            listeFrais.Add(Typefrais);
                        }
                    }
                }
                return listeFrais;
            }
            catch (SqlException ex)
            { 
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
            finally
            {
                Data.SqlConnection.DeconnexionSql();
            }
        }
    }
}
