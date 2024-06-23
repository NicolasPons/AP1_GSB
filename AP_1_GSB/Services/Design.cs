using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_1_GSB.Services
{
    internal class Design
    {

        public void MiseEnFormeBoutons(Button BoutonSender)
        {
            Control ControlParent = BoutonSender.Parent;

            foreach (Control control in ControlParent.Controls)
            {
                if (control is Button Bouton)
                {
                    Bouton.Font = new Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Bouton.BackColor = Color.FromArgb(45, 45, 61);
                }
            }
        }

        public void MiseEnFormeBoutonActif(Button BoutonSender)
        {
            MiseEnFormeBoutons(BoutonSender);
            BoutonSender.BackColor = Color.FromArgb(255, 183, 77);
            BoutonSender.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void Btn_EntrerCurseur(object sender, EventArgs e)
        {
            Button BoutonSender = sender as Button;
            if (BoutonSender != null)
            {
                MiseEnFormeBoutonActif(BoutonSender);
            }
        }

        public void Btn_SortirCurseur(object sender, EventArgs e)
        {
            Button BoutonSender = sender as Button;
            if (BoutonSender != null)
            {
                MiseEnFormeBoutons(BoutonSender);
            }
        }
    }
}
