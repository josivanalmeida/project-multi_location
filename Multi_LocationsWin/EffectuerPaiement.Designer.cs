namespace Multi_LocationsWin
{
    partial class EffectuerPaiement
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
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.labelMontant_Mensuel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDateLocation = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonSauvergarder = new System.Windows.Forms.Button();
            this.textBoxIDLocation = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDateLocation = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(173, 89);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(230, 26);
            this.textBoxMontant.TabIndex = 36;
            // 
            // labelMontant_Mensuel
            // 
            this.labelMontant_Mensuel.AutoSize = true;
            this.labelMontant_Mensuel.Location = new System.Drawing.Point(30, 95);
            this.labelMontant_Mensuel.Name = "labelMontant_Mensuel";
            this.labelMontant_Mensuel.Size = new System.Drawing.Size(68, 20);
            this.labelMontant_Mensuel.TabIndex = 35;
            this.labelMontant_Mensuel.Text = "Montant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Date Location";
            // 
            // labelDateLocation
            // 
            this.labelDateLocation.AutoSize = true;
            this.labelDateLocation.Location = new System.Drawing.Point(30, 149);
            this.labelDateLocation.Name = "labelDateLocation";
            this.labelDateLocation.Size = new System.Drawing.Size(91, 20);
            this.labelDateLocation.TabIndex = 31;
            this.labelDateLocation.Text = "ID Location";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(283, 210);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(120, 35);
            this.buttonFermer.TabIndex = 45;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonSauvergarder
            // 
            this.buttonSauvergarder.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSauvergarder.Location = new System.Drawing.Point(157, 210);
            this.buttonSauvergarder.Name = "buttonSauvergarder";
            this.buttonSauvergarder.Size = new System.Drawing.Size(120, 35);
            this.buttonSauvergarder.TabIndex = 44;
            this.buttonSauvergarder.Text = "Sauvegarder";
            this.buttonSauvergarder.UseVisualStyleBackColor = false;
            this.buttonSauvergarder.Click += new System.EventHandler(this.buttonSauvergarder_Click);
            // 
            // textBoxIDLocation
            // 
            this.textBoxIDLocation.Location = new System.Drawing.Point(173, 149);
            this.textBoxIDLocation.Mask = "00000";
            this.textBoxIDLocation.Name = "textBoxIDLocation";
            this.textBoxIDLocation.Size = new System.Drawing.Size(230, 26);
            this.textBoxIDLocation.TabIndex = 51;
            this.textBoxIDLocation.ValidatingType = typeof(int);
            // 
            // textBoxDateLocation
            // 
            this.textBoxDateLocation.Location = new System.Drawing.Point(173, 42);
            this.textBoxDateLocation.Mask = "00/00/0000";
            this.textBoxDateLocation.Name = "textBoxDateLocation";
            this.textBoxDateLocation.Size = new System.Drawing.Size(230, 26);
            this.textBoxDateLocation.TabIndex = 52;
            this.textBoxDateLocation.ValidatingType = typeof(System.DateTime);
            // 
            // EffectuerPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 307);
            this.Controls.Add(this.textBoxDateLocation);
            this.Controls.Add(this.textBoxIDLocation);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSauvergarder);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labelMontant_Mensuel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDateLocation);
            this.Name = "EffectuerPaiement";
            this.Text = "Effectuer paiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.Label labelMontant_Mensuel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDateLocation;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonSauvergarder;
        private System.Windows.Forms.MaskedTextBox textBoxIDLocation;
        private System.Windows.Forms.MaskedTextBox textBoxDateLocation;
    }
}