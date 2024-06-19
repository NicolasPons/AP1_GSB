using AP_1_GSB.Data.Models;
using AP_1_GSB.Services;
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
        public event Action degriserBouton;
        public AffichageHistorique(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            AfficherFicheFrais(utilisateur);
        }

        public void AfficherFicheFrais (Utilisateur utilisateur)
        {
            string etat = "";
            
            foreach (FicheFrais fiche in utilisateur.FichesFrais)
            {
                float montant = FicheFraisService.CalculerTotalFiche(fiche);

                DateTime dtFin = DateFin(fiche);
                ListViewItem item = new ListViewItem("Du " +fiche.Date.ToString("dd MMMM yyyy")+ " au " + dtFin.ToString("dd MMMM yyyy"));
                item.SubItems.Add(montant.ToString("F2") + "€");
                item.SubItems.Add(etat = Services.FicheFraisService.EcrireEtatFiche(fiche));
                listViewFicheFrais.Items.Add(item);
            }
        }
        public DateTime DateFin(FicheFrais fiche)
        {
            DateTime dtFin = new DateTime(fiche.Date.Year, fiche.Date.Month + 1, 10);
            return dtFin;
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            degriserBouton?.Invoke();
            this.SendToBack();
        }
    }
}
