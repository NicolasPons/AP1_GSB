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
        public AffichageHistorique(Utilisateur utilisateur, FicheFrais ficheEnCours)
        {
            InitializeComponent();
            MiseEnFormeBtn();
            this.utilisateur = utilisateur;
            AfficherFicheFrais(utilisateur);
        }

        private void MiseEnFormeBtn()
        {
            Design design = new Design();
            BtnRetour.MouseEnter += design.Btn_EntrerCurseur;
            BtnRetour.MouseLeave += design.Btn_SortirCurseur;
            design.MiseEnFormeBoutons(BtnRetour);
        }

        public void AfficherFicheFrais(Utilisateur utilisateur)
        {
            DataGridHistorique.Columns["IdFiche"].Visible = false;
            DataGridHistorique.Rows.Clear();
            List<string[]> listRow = FicheFraisService.HistoriqueFiches(utilisateur);
            foreach (string[] row in listRow)
            {
                DataGridHistorique.Rows.Add(row);
            }
        }
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            degriserBouton?.Invoke();
            this.SendToBack();
        }
    }
}

