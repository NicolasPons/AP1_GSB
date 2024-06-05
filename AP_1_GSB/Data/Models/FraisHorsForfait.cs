using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    public class FraisHorsForfait
    {
        public int IdFraisForfait { get; set; }
        public string Description { get; set; }
        public float Montant { get; set; }
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
