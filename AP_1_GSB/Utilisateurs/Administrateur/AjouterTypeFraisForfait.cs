﻿using AP_1_GSB.Data.Models;
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
    public partial class AjouterTypeFraisForfait : Form
    {
        TypeFraisForfait typeFraisForfaitAModifier;
        public event Action TypeFraisForfaitEvenement;
        string version;
        public AjouterTypeFraisForfait(string version)
        {
            InitializeComponent();
            lblModifierType.Visible = false;
            this.version = version;
            typeFraisForfaitBindingSource.DataSource = new TypeFraisForfait();
        }

        //applique le design sur les boutons
        private void MiseEnFormeBtn()
        {
            Design design = new Design();
            btnValider.MouseEnter += design.Btn_EntrerCurseur;
            btnValider.MouseLeave += design.Btn_SortirCurseur;
            design.MiseEnFormeBoutons(btnValider);
        }

        //Charge le combobox en se basant sur le data source : typeFraisForfaitAModifier
        private void ChargerComposants()
        {
            nomTextBox.DataBindings.Clear();
            montantNumericUpDown.DataBindings.Clear();

            nomTextBox.DataBindings.Add("Text", typeFraisForfaitBindingSource, "Nom", true, DataSourceUpdateMode.OnPropertyChanged);
            montantNumericUpDown.DataBindings.Add("Value", typeFraisForfaitBindingSource, "Montant", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        //Méthode de validation de la saisie utilisateur et renvoie un message d'erreur en cas de saisie incorecte
        //Sinon création ou modification d'un type de frais
        private void BtnValider_Click(object sender, EventArgs e)
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
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
