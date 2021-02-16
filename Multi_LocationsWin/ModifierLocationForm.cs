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
    public partial class ModifierLocationForm : Form
    {
        public ModifierLocationForm()
        {
            InitializeComponent();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDLocation.Text))
            {
                MessageBox.Show("L'ID location est obligatoire.", "Erreur", MessageBoxButtons.OK);
                textBoxIDLocation.Focus();
                return;
            }
             

            MultiLocationsDAL dal = new MultiLocationsDAL();
            LocationModel location = dal.GetLocation(Convert.ToInt32(textBoxIDLocation.Text));

            textBoxIDLocation.Text = location.Id.ToString();
            textBoxDateLocation.Text = location.DateLocation.ToString();
            textBoxDatePaiement.Text = location.DatePaiement.ToString();
            textBoxMontantMensuel.Text = location.MontantMensuel.ToString();
            textBoxNombrePaiement.Text = location.NombrePaiment.ToString();
            textBoxIDVehicule.Text = location.IDVehicule.ToString();
            textBoxIDClient.Text = location.IDClient.ToString();
            textBoxIDTerme.Text = location.IDTerme.ToString();
            textBoxkmInitial.Text = location.KmInitial.ToString();
            textBoxKmFinal.Text = location.KmFinal.ToString();

            if(!string.IsNullOrWhiteSpace(dal.message))
                MessageBox.Show(dal.message);
        }

        private void buttonSauvergarder_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxIDLocation.Text))
            {
                MessageBox.Show("L'ID location est obligatoire.", "Attention", MessageBoxButtons.OK);
                textBoxIDLocation.Focus();

                return;
            }

            MultiLocationsDAL dal = new MultiLocationsDAL();
            LocationModel location = dal.GetLocation(Convert.ToInt32(textBoxIDLocation.Text));
            location.Id = Convert.ToInt32(textBoxIDLocation.Text);
            location.DateLocation = !string.IsNullOrWhiteSpace(textBoxDateLocation.Text) ? Convert.ToDateTime(textBoxDateLocation.Text) : DateTime.Now;
            location.DatePaiement = !string.IsNullOrWhiteSpace(textBoxDatePaiement.Text) ? Convert.ToDateTime(textBoxDatePaiement.Text) : DateTime.MinValue;
            location.MontantMensuel = !string.IsNullOrWhiteSpace(textBoxMontantMensuel.Text) ? Convert.ToDecimal(textBoxMontantMensuel.Text) : 0;
            location.NombrePaiment = !string.IsNullOrWhiteSpace(textBoxNombrePaiement.Text) ? Convert.ToInt32(textBoxNombrePaiement.Text) : 0;
            location.IDVehicule = !string.IsNullOrWhiteSpace(textBoxIDVehicule.Text) ? Convert.ToInt32(textBoxIDVehicule.Text) : 0;
            location.IDClient = !string.IsNullOrWhiteSpace(textBoxIDClient.Text) ? Convert.ToInt32(textBoxIDClient.Text) : 0;
            location.IDTerme = !string.IsNullOrWhiteSpace(textBoxIDTerme.Text) ? Convert.ToInt32(textBoxIDTerme.Text) : 0;
            location.KmInitial = !string.IsNullOrWhiteSpace(textBoxkmInitial.Text) ? Convert.ToDecimal(textBoxkmInitial.Text) : 0;
            location.KmFinal = !string.IsNullOrWhiteSpace(textBoxKmFinal.Text) ? Convert.ToDecimal(textBoxKmFinal.Text) : 0;

            dal.ModifierLocation(location);

            MessageBox.Show(dal.message);
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
