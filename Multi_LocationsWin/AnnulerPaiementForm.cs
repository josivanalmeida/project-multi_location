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
    public partial class AnnulerPaiementForm : Form
    {
        public AnnulerPaiementForm()
        {
            InitializeComponent();
        }

        private void buttonSauvergarder_Click(object sender, EventArgs e)
        {
            MultiLocationsDAL dal = new MultiLocationsDAL();
            dal.AnnulerPaiement(Convert.ToInt32(textBoxIDPaiement.Text), textBoxRaison.Text);

            MessageBox.Show(dal.message);
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
