using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    //Attributs de la classe FraisForfait et ses annotations qui définissent les règles de validation dans le forme dont le FraisForfait est le DataSource
    public class FraisForfait
    {
        public int IdFraisForfait { get; set; }
        [Required]
        [Range(1, 5000)]
        public int Quantite { get; set; }
        public DateTime Date { get; set; }
        public EtatFraisForfait Etat { get; set; }
        public TypeFraisForfait TypeForfait { get; set; }
        public Justificatif justificatif { get; set; }
    }
    public enum EtatFraisForfait
    
    {
        Attente,
        Accepter,
        Refuser,
    }
}
