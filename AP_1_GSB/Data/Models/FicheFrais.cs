using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
    //Attributs de la classe FicheFrais
    public class FicheFrais
    {
        public int IdFicheFrais { get; set; }
        public DateTime Date { get; set; }
        public EtatFicheFrais Etat { get; set; }
        public List<FraisForfait> FraisForfaits { get; set; }
        public List<FraisHorsForfait> FraisHorsForfaits { get; set; }
    

    }
    public enum EtatFicheFrais
    {
        EnCours,
        Accepter,
        Refuser,
        Attente,
        RefusPartiel
    }
}
