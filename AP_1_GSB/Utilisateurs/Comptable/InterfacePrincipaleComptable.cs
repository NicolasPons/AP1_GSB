using AP_1_GSB.Data.Models;
using AP_1_GSB.Services;
using AP_1_GSB.Visiteur;
using iText.Layout.Splitting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Comptable
{
    public partial class InterfacePrincipaleComptable : Form
    {
        Utilisateur visiteur;
        List<Utilisateur> visiteurs;
        int IdFicheAModifier;
        public InterfacePrincipaleComptable()
        {
            InitializeComponent();
            ChargerDataGrid();
        }

        //Affiche la liste des utilisateurs dans le data grid 
        public void ChargerDataGrid()
        {
            visiteurs = new List<Utilisateur>();
            visiteurs = Services.UtilisateurService.RecupererVisiteurs();
            DataGridVisiteur.Rows.Clear();
            DataGridVisiteur.Columns["IdVisiteur"].Visible = false;
            DataGridFiche.Columns["IdFiche"].Visible = false;

            foreach (Utilisateur visiteur in visiteurs)
            {

                string[] row = new string[]
                {
                    visiteur.Nom,
                    visiteur.Prenom,
                    visiteur.Email,
                    visiteur.IdUtilisateur.ToString(),

                };

                DataGridVisiteur.Rows.Add(row);
            }
            DataGridVisiteur.ClearSelection();
        }

        //Met à jour le data Grid des fiches en fonction de l'utilisateur sélectionné dans le data grid utilisateur
        public void MettreAJourDataGridFiche()
        {
            int idVisiteurSelectionne = int.Parse(DataGridVisiteur.SelectedRows[0].Cells[3].Value.ToString());
            visiteur = visiteurs.FirstOrDefault(v => v.IdUtilisateur == idVisiteurSelectionne);
            if (visiteur != null)
            {
                visiteur = FicheFraisService.RecupererFichesFrais(visiteur);

                if(visiteur.FichesFrais.Count == 0)
                {

                }

                DataGridFiche.Rows.Clear();
                List<string[]> listRow = FicheFraisService.HistoriqueFiches(visiteur);
                foreach (string[] row in listRow)
                {
                    DataGridFiche.Rows.Add(row);
                }
            }
        }

        // Méthode appelé lors du clique sur le bouton dans le formulaire dashboard;
        // Retourne un tuple avec un objet FicheFrais et un objet Utilisateur 
        public (FicheFrais, Utilisateur) SelectionnerFiche()
        {
            FicheFrais fiche;
            if (DataGridFiche.SelectedRows.Count > 0)
            {
                IdFicheAModifier = int.Parse(DataGridFiche.SelectedRows[0].Cells[3].Value.ToString());
                fiche = visiteur.FichesFrais.FirstOrDefault(f => f.IdFicheFrais == IdFicheAModifier);
                if (fiche != null)
                {
                    return (fiche, visiteur);
                }
                else
                {
                    MessageBox.Show("Fiche non trouvée.");
                    return (null, null);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une fiche");
                return (null, null);
            }
        }


        //Evenement pour mettre à jour le data grid fiche lors de la sélection d'un utilisateur 
        private void DataGridVisiteur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && DataGridVisiteur.SelectedRows.Count > 0)
            {
                MettreAJourDataGridFiche();
            }

        }

        //Clear le data grid fiche au clique sur le datagrid visiteur 
        private void DataGridVisiteur_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridFiche.ClearSelection();
        }

    }
}
