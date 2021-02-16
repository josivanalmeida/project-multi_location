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
    public partial class LoginForm : Form
    {
        private int essaiLogin = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom.Text) || string.IsNullOrEmpty(textBoxMot.Text))
            {
                MessageBox.Show("Le nom d'utilisateur et un mot de passe sont obligatoire.", "Attention", MessageBoxButtons.OK);
                textBoxNom.Focus();
            }
            else
            {
                MultiLocationsDAL dal = new MultiLocationsDAL();

                if(dal.ValidateUtilisateur(textBoxNom.Text.ToLower(), textBoxMot.Text))
                //if (textBoxNom.Text.ToUpper() == "ADMIN" && textBoxMot.Text == "admin")
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Visible = true;
                    mainForm.Activate();

                    this.Visible = false;
                }
                else
                {
                    essaiLogin++;

                    if (essaiLogin > 3)
                    {
                        MessageBox.Show("Vous avez dépassé la limite de tentatives!", "Attention", MessageBoxButtons.OK);
                        Application.Exit();
                    }

                    MessageBox.Show("Le nom d'utilisateur et le mot de passe sont incorrects.", "Attention", MessageBoxButtons.OK);
                    textBoxNom.Focus();
                }
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
