namespace Multi_LocationsWin
{
    partial class AnnulerPaiementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonSauvergarder = new System.Windows.Forms.Button();
            this.textBoxRaison = new System.Windows.Forms.TextBox();
            this.labelIDPaiement = new System.Windows.Forms.Label();
            this.labelRaison = new System.Windows.Forms.Label();
            this.textBoxIDPaiement = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(287, 199);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(120, 35);
            this.buttonFermer.TabIndex = 53;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonSauvergarder
            // 
            this.buttonSauvergarder.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSauvergarder.Location = new System.Drawing.Point(161, 199);
            this.buttonSauvergarder.Name = "buttonSauvergarder";
            this.buttonSauvergarder.Size = new System.Drawing.Size(120, 35);
            this.buttonSauvergarder.TabIndex = 52;
            this.buttonSauvergarder.Text = "Sauvegarder";
            this.buttonSauvergarder.UseVisualStyleBackColor = false;
            this.buttonSauvergarder.Click += new System.EventHandler(this.buttonSauvergarder_Click);
            // 
            // textBoxRaison
            // 
            this.textBoxRaison.Location = new System.Drawing.Point(179, 78);
            this.textBoxRaison.Name = "textBoxRaison";
            this.textBoxRaison.Size = new System.Drawing.Size(230, 26);
            this.textBoxRaison.TabIndex = 51;
            // 
            // labelIDPaiement
            // 
            this.labelIDPaiement.AutoSize = true;
            this.labelIDPaiement.Location = new System.Drawing.Point(34, 40);
            this.labelIDPaiement.Name = "labelIDPaiement";
            this.labelIDPaiement.Size = new System.Drawing.Size(97, 20);
            this.labelIDPaiement.TabIndex = 46;
            this.labelIDPaiement.Text = "ID Paiement";
            // 
            // labelRaison
            // 
            this.labelRaison.AutoSize = true;
            this.labelRaison.Location = new System.Drawing.Point(34, 84);
            this.labelRaison.Name = "labelRaison";
            this.labelRaison.Size = new System.Drawing.Size(139, 20);
            this.labelRaison.TabIndex = 50;
            this.labelRaison.Text = "Raison Annulation";
            // 
            // textBoxIDPaiement
            // 
            this.textBoxIDPaiement.Location = new System.Drawing.Point(179, 34);
            this.textBoxIDPaiement.Mask = "00000";
            this.textBoxIDPaiement.Name = "textBoxIDPaiement";
            this.textBoxIDPaiement.Size = new System.Drawing.Size(230, 26);
            this.textBoxIDPaiement.TabIndex = 54;
            this.textBoxIDPaiement.ValidatingType = typeof(int);
            // 
            // AnnulerPaiementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 307);
            this.Controls.Add(this.textBoxIDPaiement);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSauvergarder);
            this.Controls.Add(this.textBoxRaison);
            this.Controls.Add(this.labelRaison);
            this.Controls.Add(this.labelIDPaiement);
            this.Name = "AnnulerPaiementForm";
            this.Text = "Annuler paiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonSauvergarder;
        private System.Windows.Forms.TextBox textBoxRaison;
        private System.Windows.Forms.Label labelIDPaiement;
        private System.Windows.Forms.Label labelRaison;
        private System.Windows.Forms.MaskedTextBox textBoxIDPaiement;
    }
}