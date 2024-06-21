using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_1_GSB.Services;
using AP_1_GSB.Data.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace AP_1_GSB
{
    public partial class Login : Form
    {
        public TextBox SaisieUtilisateur => this.saisieUtilisateur;
        public TextBox SaisieMdp => this.saisieMdp;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnQuitterAppCiquer(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSeConnecterCliquer(object sender, EventArgs e)
        {
            Utilisateur utilisateur = Services.AuthentificationService.VerificationUtilisateur(saisieUtilisateur.Text, saisieMdp.Text);
            
            if (utilisateur != null)
            {
                switch (utilisateur.Role)
                {
                    case UtilisateurRole.Visiteur:
                        TableauBord TableauBordUtilisateur = new TableauBord(utilisateur, this);
                        TableauBordUtilisateur.Show();
                        break;

                    case UtilisateurRole.Comptable:
                        TableauBord TableauBordComptable = new TableauBord(utilisateur, this);
                        TableauBordComptable.Show();
                        break;

                    case UtilisateurRole.Administrateur:
                        TableauBord TableauBordAdministrateur = new TableauBord(utilisateur, this);
                        TableauBordAdministrateur.Show();
                        break; 
                }
            }
            else
            {
                return;
            }
            this.Hide();
        }
    }
}
