namespace Multi_LocationsWin
{
    partial class LoginForm
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
            this.titre = new System.Windows.Forms.Label();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.LabelMot = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxMot = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(87, 23);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(150, 85);
            this.titre.TabIndex = 2;
            this.titre.Text = "Bienvenue \nà Multi Location";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(179, 228);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(70, 25);
            this.buttonQuitter.TabIndex = 18;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(79, 228);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 25);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // LabelMot
            // 
            this.LabelMot.AutoSize = true;
            this.LabelMot.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMot.Location = new System.Drawing.Point(59, 174);
            this.LabelMot.Name = "LabelMot";
            this.LabelMot.Size = new System.Drawing.Size(72, 14);
            this.LabelMot.TabIndex = 16;
            this.LabelMot.Text = "Mot de passe";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(59, 138);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(85, 14);
            this.labelNom.TabIndex = 15;
            this.labelNom.Text = "Nom d\'utilisateur";
            // 
            // textBoxMot
            // 
            this.textBoxMot.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMot.Location = new System.Drawing.Point(159, 174);
            this.textBoxMot.Name = "textBoxMot";
            this.textBoxMot.PasswordChar = '*';
            this.textBoxMot.Size = new System.Drawing.Size(125, 20);
            this.textBoxMot.TabIndex = 14;
            this.textBoxMot.TextChanged += new System.EventHandler(this.textBoxMot_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(159, 133);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(125, 20);
            this.textBoxNom.TabIndex = 13;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 326);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.LabelMot);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxMot);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.titre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Système de gestion Multi Locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label LabelMot;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxMot;
        private System.Windows.Forms.TextBox textBoxNom;
    }
}

