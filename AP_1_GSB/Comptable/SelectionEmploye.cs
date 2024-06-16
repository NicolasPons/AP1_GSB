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

namespace AP_1_GSB.Comptable
{
    public partial class SelectionEmploye : Form
    {
        public SelectionEmploye()
        {
            InitializeComponent();
            ChargerListView();
        }

        private void ChargerListView()
        {
            List<Utilisateur> visiteurs = new List<Utilisateur>();
            visiteurs = Services.VisiteurService.RecupererVisiteur();

            foreach (Utilisateur visisteur in visiteurs)
            {
                ListViewItem item = new ListViewItem(visisteur.Nom);
                item.SubItems.Add(visisteur.Prenom);
                item.SubItems.Add(visisteur.Email);
                item.Tag = visisteur.IdUtilisateur;
                listViewAffichageUtilisateurs.Items.Add(item);
            }
        }

        public void SelectionnerEmploye()
        {
            if (listViewAffichageUtilisateurs.SelectedItems.Count > 0)
            {
                int IdEmploye = (int)listViewAffichageUtilisateurs.SelectedItems[0].Tag;

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un employé");
            }
        }
    }
}
