using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    public class FraisForfait
    {
        public int IdFraisForfait { get; set; }
        public int Quantite { get; set; }
        public DateTime Date { get; set; }
        public EtatFraisForfait Etat { get; set; }
        public TypeFraisForfait TypeForfait { get; set; }
        public Justificatif Justificatif { get; set; }
    }
    public enum EtatFraisForfait
    
    {
        Attente,
        Accepter,
        Refuser,
    }
}
