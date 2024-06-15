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
            
            AfficherFicheFrais(utilisateur);
        }

        public void AfficherFicheFrais (Utilisateur utilisateur)
        {
            foreach (FicheFrais fiche in utilisateur.FichesFrais)
            {
                DateTime dtFin = DateFin(fiche);
                ListViewItem item = new ListViewItem("Du " +fiche.Date.ToString("dd MMMM yyyy")+ " au " + dtFin.ToString("dd MMMM yyyy"));
                item.SubItems.Add("montant");
                item.SubItems.Add(fiche.Etat.ToString());
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
            this.SendToBack();
        }
    }
}
