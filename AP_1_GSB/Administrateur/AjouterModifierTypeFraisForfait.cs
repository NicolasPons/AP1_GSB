using AP_1_GSB.Data.Models;
using AP_1_GSB.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Administrateur
{
    public partial class AjouterModifierTypeFraisForfait : Form
    {
        TypeFraisForfait typeFraisForfaitAModifier;
        public event Action TypeFraisForfaitEvenement;
        string version;
        public AjouterModifierTypeFraisForfait(string version)
        {
            InitializeComponent();
            lblModifierType.Visible = false;
            this.version = version;
            typeFraisForfaitBindingSource.DataSource = new TypeFraisForfait();
        }
        public AjouterModifierTypeFraisForfait(string version, TypeFraisForfait typeFraisForfaitAModifier)
        {
            InitializeComponent();
            MiseEnFormeBtn();
            lblCreer.Visible = false;
            this.typeFraisForfaitAModifier = typeFraisForfaitAModifier;
            this.version = version;
            typeFraisForfaitBindingSource.DataSource = typeFraisForfaitAModifier;
            ChargerComposants(typeFraisForfaitAModifier);
        }

        private void MiseEnFormeBtn()
        {
            Design design = new Design();
            btnValider.MouseEnter += design.Btn_EntrerCurseur;
            btnValider.MouseLeave += design.Btn_SortirCurseur;
            design.MiseEnFormeBoutons(btnValider);
        }

        private void ChargerComposants(TypeFraisForfait type)
        {
            nomTextBox.DataBindings.Clear();
            montantNumericUpDown.DataBindings.Clear();

            nomTextBox.DataBindings.Add("Text", typeFraisForfaitBindingSource, "Nom", true, DataSourceUpdateMode.OnPropertyChanged);
            montantNumericUpDown.DataBindings.Add("Value", typeFraisForfaitBindingSource, "Montant", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (version == "ajouter")
            {
                typeFraisForfaitBindingSource.EndEdit();

                TypeFraisForfait typeFraisForfait = typeFraisForfaitBindingSource.Current as TypeFraisForfait;
                if (typeFraisForfait != null)
                {
                    ValidationContext context = new ValidationContext(typeFraisForfait, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(typeFraisForfait, context, errors, true))
                    {
                        foreach (ValidationResult validationResult in errors)
                        {
                            MessageBox.Show(validationResult.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                          
                        if (Services.TypeFraisForfaitService.CreerTypeFraisForfait(typeFraisForfait))
                            MessageBox.Show("Type de frais forfait créé avec succés");
                        TypeFraisForfaitEvenement?.Invoke();
                        this.Close();
                    }
                }
            }
            else
            {
                typeFraisForfaitBindingSource.EndEdit();

                TypeFraisForfait typeFraisForfaitModifie = typeFraisForfaitBindingSource.Current as TypeFraisForfait;
                if (typeFraisForfaitModifie != null)
                {
                    ValidationContext context = new ValidationContext(typeFraisForfaitModifie, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(typeFraisForfaitModifie, context, errors, true))
                    {
                        foreach (ValidationResult validationResult in errors)
                        {
                            MessageBox.Show(validationResult.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        typeFraisForfaitModifie.IdFraisForfait = typeFraisForfaitAModifier.IdFraisForfait;
                        if (Services.TypeFraisForfaitService.ModifierTypeFraisForfait(typeFraisForfaitModifie))
                            MessageBox.Show("Type de frais forfait modifié avec succés");
                        TypeFraisForfaitEvenement?.Invoke();
                        this.Close();
                    }
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
