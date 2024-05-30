using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_1_GSB.Data.Models
{
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
        Attente,
        Accepter,
        Refuser,
        RefusPartiel
    }
}


//SELECT DISTINCT * FROM UTILISATEUR

//INNER JOIN role ON utilisateur.id_role = role.id_role 
//INNER JOIN fiche_frais ON fiche_frais.id_utilisateur = utilisateur.id_utilisateur
//INNER JOIN type_etat ON fiche_frais.id_etat = type_etat.id_etat
//INNER JOIN frais_forfait ON fiche_frais.id_fiche_frais = frais_forfait.id_fiche_frais
//INNER JOIN frais_hors_forfait ON fiche_frais.id_fiche_frais = frais_hors_forfait.id_fiche_frais
//INNER JOIN type_frais_forfait ON frais_forfait.id_type_forfait = type_frais_forfait.id_type_forfait
//LEFT JOIN justificatif justificatif_ff ON frais_forfait.id_justificatif = justificatif_ff.id_justificatif
//LEFT JOIN justificatif justificatif_hf ON frais_hors_forfait.id_justificatif = justificatif_hf.id_justificatif

//WHERE identifiant = "nico" AND mdp = "nico"