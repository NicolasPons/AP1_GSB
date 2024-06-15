using AP_1_GSB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Visiteur
{
    public partial class AffichageHistorique : Form
    {
        Utilisateur utilisateur;
        public AffichageHistorique(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            utilisateur = Services.FicheFraisService.RecupererFichesFrais(utilisateur);
        }
    }
}
