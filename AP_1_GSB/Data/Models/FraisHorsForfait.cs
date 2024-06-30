using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    //Attributs de la classe FraisHorsForfait et ses annotations qui définissent les règles de validation dans le forme dont le FraisHorsForfait est le DataSource
    public class FraisHorsForfait
    {
        public int IdFraisHorsForfait { get; set; }
        [Required]
        [MaxLength(300)]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "La description doit contenir uniquement des lettres et des chiffres")]
        public string Description { get; set; }
        [Required]
        [Range(0, 5000)]
        public float Montant { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public EtatFraisHorsForfait Etat { get; set; }
        public Justificatif Justificatif { get; set; }
    }
    public enum EtatFraisHorsForfait
    {
        Attente,
        Accepter,
        Refuser,
    }
}
