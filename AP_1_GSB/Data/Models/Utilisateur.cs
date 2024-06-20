using AP_1_GSB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    public class Utilisateur
    {
        public int IdUtilisateur { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "L'identifiant ne doit contenir que des lettres.")]
        public string Identifiant { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Le mot de passe doit contenir au moins une lettre et un chiffre.")]
        public string Mdp { get; set; }


        [Required]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s'-]+$", ErrorMessage = "Nom invalide.")]
        public string Nom { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s'-]+$", ErrorMessage = "Prénom invalide.")]
        public string Prenom { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email invalide.")]
        public string Email { get; set; }

        [Required]
        public UtilisateurRole Role { get; set; }

        public List<FicheFrais> FichesFrais { get; set; } = new List<FicheFrais>();
    }
    public enum UtilisateurRole
    {
        Visiteur,
        Comptable,
        Administrateur
    }
}


