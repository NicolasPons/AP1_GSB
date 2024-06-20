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

namespace AP_1_GSB.Administrateur
{
    public partial class InterfacePrincipaleAdmin : Form
    {
        public InterfacePrincipaleAdmin()
        {
            InitializeComponent();
            MettreAJourListViewAdmin();
        }

        public void MettreAJourListViewAdmin()
        {
            listViewTypeFraisForfait.Items.Clear();
            listViewUtilisateur.Items.Clear();

            List<TypeFraisForfait> TypesFraisForfait = new List<TypeFraisForfait>();
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            TypesFraisForfait = Services.TypeFraisForfaitService.RecupererTypeFraisForfait();
            utilisateurs = Services.UtilisateurService.RecupererUtilisateurs();

            foreach (TypeFraisForfait type in  TypesFraisForfait)
            {
                ListViewItem item = new ListViewItem(type.Nom);
                item.SubItems.Add(type.Montant.ToString());
                item.Tag = type.IdFraisForfait;
                listViewTypeFraisForfait.Items.Add(item);
            }

            foreach (Utilisateur utilisateur in utilisateurs)
            {
                ListViewItem item = new ListViewItem(utilisateur.Nom);
                item.SubItems.Add(utilisateur.Prenom);
                item.SubItems.Add(utilisateur.Identifiant);
                item.SubItems.Add(utilisateur.Role.ToString());
                item.Tag = utilisateur.IdUtilisateur;
                listViewUtilisateur.Items.Add(item);
            }
        }
    }
}
