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
            AuthentificationService loginService = new AuthentificationService();

            Utilisateur utilisateur = loginService.VerificationUtilisateur(saisieUtilisateur.Text, saisieMdp.Text);

            if (utilisateur != null)
            {
                switch (utilisateur.Role)
                {
                    case UtilisateurRole.Visiteur:
                        DashBoardVisiteur dashBoardVisiteur = new DashBoardVisiteur();
                        
                        dashBoardVisiteur.Show();
                        break;

                    case UtilisateurRole.Comptable:
                        MessageBox.Show("comptable");
                        break;

                    case UtilisateurRole.Administrateur:
                        MessageBox.Show("administrateur");
                        break;
                }
            }
        }
    }
}
