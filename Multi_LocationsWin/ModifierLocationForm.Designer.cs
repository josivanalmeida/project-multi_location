namespace Multi_LocationsWin
{
    partial class ModifierLocationForm
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
            this.labelDateLocation = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxKmFinal = new System.Windows.Forms.TextBox();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonSauvergarder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxkmInitial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombrePaiement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMontantMensuel = new System.Windows.Forms.TextBox();
            this.labelMontant_Mensuel = new System.Windows.Forms.Label();
            this.labelDate_Paiement = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDatePaiement = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDateLocation = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIDTerme = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIDClient = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIDVehicule = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIDLocation = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelDateLocation
            // 
            this.labelDateLocation.AutoSize = true;
            this.labelDateLocation.Location = new System.Drawing.Point(24, 31);
            this.labelDateLocation.Name = "labelDateLocation";
            this.labelDateLocation.Size = new System.Drawing.Size(91, 20);
            this.labelDateLocation.TabIndex = 6;
            this.labelDateLocation.Text = "ID Location";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(417, 21);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(120, 35);
            this.buttonRechercher.TabIndex = 24;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxKmFinal
            // 
            this.textBoxKmFinal.Location = new System.Drawing.Point(325, 386);
            this.textBoxKmFinal.Name = "textBoxKmFinal";
            this.textBoxKmFinal.Size = new System.Drawing.Size(69, 26);
            this.textBoxKmFinal.TabIndex = 44;
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(274, 431);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(120, 35);
            this.buttonFermer.TabIndex = 43;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonSauvergarder
            // 
            this.buttonSauvergarder.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSauvergarder.Location = new System.Drawing.Point(113, 431);
            this.buttonSauvergarder.Name = "buttonSauvergarder";
            this.buttonSauvergarder.Size = new System.Drawing.Size(120, 35);
            this.buttonSauvergarder.TabIndex = 42;
            this.buttonSauvergarder.Text = "Sauvegarder";
            this.buttonSauvergarder.UseVisualStyleBackColor = false;
            this.buttonSauvergarder.Click += new System.EventHandler(this.buttonSauvergarder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Km Final";
            // 
            // textBoxkmInitial
            // 
            this.textBoxkmInitial.Location = new System.Drawing.Point(164, 386);
            this.textBoxkmInitial.Name = "textBoxkmInitial";
            this.textBoxkmInitial.Size = new System.Drawing.Size(69, 26);
            this.textBoxkmInitial.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Km Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID Terme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID Client ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID Vehicule ";
            // 
            // textBoxNombrePaiement
            // 
            this.textBoxNombrePaiement.Location = new System.Drawing.Point(164, 212);
            this.textBoxNombrePaiement.Name = "textBoxNombrePaiement";
            this.textBoxNombrePaiement.Size = new System.Drawing.Size(230, 26);
            this.textBoxNombrePaiement.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre Paiement";
            // 
            // textBoxMontantMensuel
            // 
            this.textBoxMontantMensuel.Location = new System.Drawing.Point(164, 168);
            this.textBoxMontantMensuel.Name = "textBoxMontantMensuel";
            this.textBoxMontantMensuel.Size = new System.Drawing.Size(230, 26);
            this.textBoxMontantMensuel.TabIndex = 30;
            // 
            // labelMontant_Mensuel
            // 
            this.labelMontant_Mensuel.AutoSize = true;
            this.labelMontant_Mensuel.Location = new System.Drawing.Point(24, 171);
            this.labelMontant_Mensuel.Name = "labelMontant_Mensuel";
            this.labelMontant_Mensuel.Size = new System.Drawing.Size(132, 20);
            this.labelMontant_Mensuel.TabIndex = 29;
            this.labelMontant_Mensuel.Text = "Montant Mensuel";
            // 
            // labelDate_Paiement
            // 
            this.labelDate_Paiement.AutoSize = true;
            this.labelDate_Paiement.Location = new System.Drawing.Point(24, 130);
            this.labelDate_Paiement.Name = "labelDate_Paiement";
            this.labelDate_Paiement.Size = new System.Drawing.Size(115, 20);
            this.labelDate_Paiement.TabIndex = 27;
            this.labelDate_Paiement.Text = "Date Paiement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date Location";
            // 
            // textBoxDatePaiement
            // 
            this.textBoxDatePaiement.Location = new System.Drawing.Point(164, 124);
            this.textBoxDatePaiement.Mask = "00/00/0000";
            this.textBoxDatePaiement.Name = "textBoxDatePaiement";
            this.textBoxDatePaiement.Size = new System.Drawing.Size(230, 26);
            this.textBoxDatePaiement.TabIndex = 46;
            this.textBoxDatePaiement.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxDateLocation
            // 
            this.textBoxDateLocation.Location = new System.Drawing.Point(164, 76);
            this.textBoxDateLocation.Mask = "00/00/0000";
            this.textBoxDateLocation.Name = "textBoxDateLocation";
            this.textBoxDateLocation.Size = new System.Drawing.Size(230, 26);
            this.textBoxDateLocation.TabIndex = 45;
            this.textBoxDateLocation.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxIDTerme
            // 
            this.textBoxIDTerme.Location = new System.Drawing.Point(164, 345);
            this.textBoxIDTerme.Mask = "00000";
            this.textBoxIDTerme.Name = "textBoxIDTerme";
            this.textBoxIDTerme.Size = new System.Drawing.Size(230, 26);
            this.textBoxIDTerme.TabIndex = 49;
            this.textBoxIDTerme.ValidatingType = typeof(int);
            // 
            // textBoxIDClient
            // 
            this.textBoxIDClient.Location = new System.Drawing.Point(164, 304);
            this.textBoxIDClient.Mask = "00000";
            this.textBoxIDClient.Name = "textBoxIDClient";
            this.textBoxIDClient.Size = new System.Drawing.Size(230, 26);
            this.textBoxIDClient.TabIndex = 48;
            this.textBoxIDClient.ValidatingType = typeof(int);
            // 
            // textBoxIDVehicule
            // 
            this.textBoxIDVehicule.Location = new System.Drawing.Point(164, 260);
            this.textBoxIDVehicule.Mask = "00000";
            this.textBoxIDVehicule.Name = "textBoxIDVehicule";
            this.textBoxIDVehicule.Size = new System.Drawing.Size(230, 26);
            this.textBoxIDVehicule.TabIndex = 47;
            this.textBoxIDVehicule.ValidatingType = typeof(int);
            // 
            // textBoxIDLocation
            // 
            this.textBoxIDLocation.Location = new System.Drawing.Point(164, 31);
            this.textBoxIDLocation.Mask = "00000";
            this.textBoxIDLocation.Name = "textBoxIDLocation";
            this.textBoxIDLocation.Size = new System.Drawing.Size(230, 26);
            this.textBoxIDLocation.TabIndex = 50;
            this.textBoxIDLocation.ValidatingType = typeof(int);
            // 
            // ModifierLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 529);
            this.Controls.Add(this.textBoxIDLocation);
            this.Controls.Add(this.textBoxIDTerme);
            this.Controls.Add(this.textBoxIDClient);
            this.Controls.Add(this.textBoxIDVehicule);
            this.Controls.Add(this.textBoxDatePaiement);
            this.Controls.Add(this.textBoxDateLocation);
            this.Controls.Add(this.textBoxKmFinal);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSauvergarder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxkmInitial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombrePaiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMontantMensuel);
            this.Controls.Add(this.labelMontant_Mensuel);
            this.Controls.Add(this.labelDate_Paiement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.labelDateLocation);
            this.Name = "ModifierLocationForm";
            this.Text = "Modifier Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDateLocation;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxKmFinal;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonSauvergarder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxkmInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombrePaiement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMontantMensuel;
        private System.Windows.Forms.Label labelMontant_Mensuel;
        private System.Windows.Forms.Label labelDate_Paiement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textBoxDatePaiement;
        private System.Windows.Forms.MaskedTextBox textBoxDateLocation;
        private System.Windows.Forms.MaskedTextBox textBoxIDTerme;
        private System.Windows.Forms.MaskedTextBox textBoxIDClient;
        private System.Windows.Forms.MaskedTextBox textBoxIDVehicule;
        private System.Windows.Forms.MaskedTextBox textBoxIDLocation;
    }
}