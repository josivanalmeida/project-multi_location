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
    public partial class AjouterLocationForm : Form
    {
        public AjouterLocationForm()
        {
            InitializeComponent();
        }

        private void buttonSauvergarder_Click(object sender, EventArgs e)
        {
            LocationModel location = new LocationModel();
            location.DateLocation = !string.IsNullOrWhiteSpace(textBoxDateLocation.Text) ? Convert.ToDateTime(textBoxDateLocation.Text): DateTime.Now;
            location.DatePaiement = !string.IsNullOrWhiteSpace(textBoxDatePaiement.Text) ? Convert.ToDateTime(textBoxDatePaiement.Text) : DateTime.MinValue;
            location.MontantMensuel = !string.IsNullOrWhiteSpace(textBoxMontantMensuel.Text) ? Convert.ToDecimal(textBoxMontantMensuel.Text): 0;
            location.NombrePaiment = !string.IsNullOrWhiteSpace(textBoxNombrePaiement.Text) ?  Convert.ToInt32(textBoxNombrePaiement.Text) : 0;
            location.IDVehicule = !string.IsNullOrWhiteSpace(textBoxIDVehicule.Text) ? Convert.ToInt32(textBoxIDVehicule.Text) : 0;
            location.IDClient = !string.IsNullOrWhiteSpace(textBoxIDClient.Text) ? Convert.ToInt32(textBoxIDClient.Text) : 0;
            location.IDTerme = !string.IsNullOrWhiteSpace(textBoxIDTerme.Text) ? Convert.ToInt32(textBoxIDTerme.Text) : 0;
            location.KmInitial = !string.IsNullOrWhiteSpace(textBoxkmInitial.Text) ? Convert.ToDecimal(textBoxkmInitial.Text) : 0;
            location.KmFinal = !string.IsNullOrWhiteSpace(textBoxKmFinal.Text) ? Convert.ToDecimal(textBoxKmFinal.Text) : 0;

            MultiLocationsDAL dal = new MultiLocationsDAL();
            dal.AjouterLocation(location);

            if (!string.IsNullOrEmpty(dal.message))
                MessageBox.Show(dal.message);
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
