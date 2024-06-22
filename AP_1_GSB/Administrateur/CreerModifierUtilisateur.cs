using System;
using AP_1_GSB.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_1_GSB.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace AP_1_GSB.Administrateur
{
    public partial class CreerModifierUtilisateur : Form
    {
        string version;
        Utilisateur utilisateurAModifier;
        public event Action UtilisateurEvenement;
        public CreerModifierUtilisateur(string version)
        {
            InitializeComponent();
            lblModifierUtilisateur.Visible = false;
            this.version = version;
            utilisateurBindingSource.DataSource = new Utilisateur();
        }

        public CreerModifierUtilisateur(string version, Utilisateur utilisateurAModifier)
        {
            InitializeComponent();
            lblCreerUtilisateur.Visible = false;
            ChargerComposants();
            this.version = version;
            this.utilisateurAModifier = utilisateurAModifier;
            utilisateurBindingSource.DataSource = utilisateurAModifier;
        }

        private void ChargerComposants()
        {
            identifiantTextBox.DataBindings.Clear();
            mdpTextBox.DataBindings.Clear();
            nomTextBox.DataBindings.Clear();
            prenomTextBox.DataBindings.Clear();
            emailTextBox.DataBindings.Clear();
            roleComboBox.DataBindings.Clear();

            identifiantTextBox.DataBindings.Add("Text", utilisateurBindingSource, "Identifiant", true, DataSourceUpdateMode.OnPropertyChanged);
            mdpTextBox.DataBindings.Add("Text", utilisateurBindingSource, "Mdp", true, DataSourceUpdateMode.OnPropertyChanged);
            nomTextBox.DataBindings.Add("Text", utilisateurBindingSource, "Nom", true, DataSourceUpdateMode.OnPropertyChanged);
            prenomTextBox.DataBindings.Add("Text", utilisateurBindingSource, "Prenom", true, DataSourceUpdateMode.OnPropertyChanged);
            emailTextBox.DataBindings.Add("Text", utilisateurBindingSource, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            roleComboBox.DataBindings.Add("SelectedItem", utilisateurBindingSource, "Role", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (version == "ajouter")
            {
                utilisateurBindingSource.EndEdit();
                Utilisateur utilisateur = utilisateurBindingSource.Current as Utilisateur;
                if (utilisateur != null)
                {
                    ValidationContext context = new ValidationContext(utilisateur, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(utilisateur, context, errors, true))
                    {
                        if (errors.Count > 1)
                        {
                            MessageBox.Show("Plusieurs saisies sont incorrects. Veuillez recommencer s'il vous plait.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            foreach (ValidationResult validationResult in errors)
                            {
                                MessageBox.Show(validationResult.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        if (Services.UtilisateurService.CreerUtilisateur(utilisateur))
                            MessageBox.Show("Utilisateur créé avec succés");
                        UtilisateurEvenement?.Invoke();
                        this.Close();
                    }
                }
            }
            else
            {
                Utilisateur utilisateurModifie = utilisateurBindingSource.Current as Utilisateur;
                if (utilisateurModifie != null)
                {
                    ValidationContext context = new ValidationContext(utilisateurModifie, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(utilisateurModifie, context, errors, true))
                    {
                        if (errors.Count > 1)
                        {
                            MessageBox.Show("Plusieurs saisies sont incorrects. Veuillez recommencer s'il vous plait", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            foreach (ValidationResult validationResult in errors)
                            {
                                MessageBox.Show(validationResult.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        utilisateurModifie.IdUtilisateur = utilisateurAModifier.IdUtilisateur;
                        if (Services.UtilisateurService.ModifierUtilisateur(utilisateurModifie))
                        {
                            MessageBox.Show("Utilisateur modifié avec succés");
                            UtilisateurEvenement?.Invoke();
                            this.Close();
                        }
                    }

                }

            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
