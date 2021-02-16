using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_LocationsWin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ajouterLocationMenuItem_Click(object sender, EventArgs e)
        {
            AjouterLocationForm ajouterLocation = new AjouterLocationForm();
            ajouterLocation.Visible = true;
            ajouterLocation.Activate();
        }

        private void modifierLocationMenuItem_Click(object sender, EventArgs e)
        {
            ModifierLocationForm modifierLocation = new ModifierLocationForm();
            modifierLocation.Visible = true;
            modifierLocation.Activate();

        }

        private void effectuerPaiementMenuItem_Click(object sender, EventArgs e)
        {
            EffectuerPaiement effectuerPaiement = new EffectuerPaiement();
            effectuerPaiement.Visible = true;
            effectuerPaiement.Activate();
        }

        private void annulerPaiementMenuItem_Click(object sender, EventArgs e)
        {
            AnnulerPaiementForm annulerPaiement = new AnnulerPaiementForm();
            annulerPaiement.Visible = true;
            annulerPaiement.Activate();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
