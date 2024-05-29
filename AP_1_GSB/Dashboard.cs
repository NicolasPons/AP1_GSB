using AP_1_GSB.Visiteur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB
{
    public partial class Dashboard : Form
    {
        public Dashboard(int id, string nom, string prenom)
        {
            InitializeComponent();
        }

        private void BtnAjouterNoteFrais(object sender, EventArgs e)
        {
            AjouterNoteFrais ajouterNoteFrais = new AjouterNoteFrais();
            ajouterNoteFrais.TopLevel = false;
            myPanel.Controls.Add(ajouterNoteFrais);
            ajouterNoteFrais.FormBorderStyle = FormBorderStyle.None;
            ajouterNoteFrais.Dock = DockStyle.Fill;
            ajouterNoteFrais.Show();

        }
    }
}
