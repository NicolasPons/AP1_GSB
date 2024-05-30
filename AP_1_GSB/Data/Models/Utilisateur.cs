using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    public class Utilisateur
    {
        public int IdUtilisateur { get; set; }

        public string Identifiant { get; set; }
        public string Mdp { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public UtilisateurRole Role { get; set; }
        public List<FicheFrais> FichesFrais { get; set; }

    }
    public enum UtilisateurRole
    {
        Visiteur,
        Comptable,
        Administrateur
    }
}
