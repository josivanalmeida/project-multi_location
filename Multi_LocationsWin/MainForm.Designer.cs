namespace Multi_LocationsWin
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.paiementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerPaiementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerPaiementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationMenuItem,
            this.toolStripSeparator,
            this.paiementMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "&Menu";
            // 
            // locationMenuItem
            // 
            this.locationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterLocationMenuItem,
            this.modifierLocationMenuItem});
            this.locationMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.locationMenuItem.Name = "locationMenuItem";
            this.locationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.locationMenuItem.Size = new System.Drawing.Size(252, 30);
            this.locationMenuItem.Text = "&Location";
            // 
            // ajouterLocationMenuItem
            // 
            this.ajouterLocationMenuItem.Name = "ajouterLocationMenuItem";
            this.ajouterLocationMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ajouterLocationMenuItem.Text = "Ajouter Location";
            this.ajouterLocationMenuItem.Click += new System.EventHandler(this.ajouterLocationMenuItem_Click);
            // 
            // modifierLocationMenuItem
            // 
            this.modifierLocationMenuItem.Name = "modifierLocationMenuItem";
            this.modifierLocationMenuItem.Size = new System.Drawing.Size(252, 30);
            this.modifierLocationMenuItem.Text = "Modifier Location";
            this.modifierLocationMenuItem.Click += new System.EventHandler(this.modifierLocationMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(249, 6);
            // 
            // paiementMenuItem
            // 
            this.paiementMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectuerPaiementMenuItem,
            this.annulerPaiementMenuItem});
            this.paiementMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paiementMenuItem.Name = "paiementMenuItem";
            this.paiementMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.paiementMenuItem.Size = new System.Drawing.Size(252, 30);
            this.paiementMenuItem.Text = "&Paiement";
            // 
            // effectuerPaiementMenuItem
            // 
            this.effectuerPaiementMenuItem.Name = "effectuerPaiementMenuItem";
            this.effectuerPaiementMenuItem.Size = new System.Drawing.Size(252, 30);
            this.effectuerPaiementMenuItem.Text = "Effectuer Paiement";
            this.effectuerPaiementMenuItem.Click += new System.EventHandler(this.effectuerPaiementMenuItem_Click);
            // 
            // annulerPaiementMenuItem
            // 
            this.annulerPaiementMenuItem.Name = "annulerPaiementMenuItem";
            this.annulerPaiementMenuItem.Size = new System.Drawing.Size(252, 30);
            this.annulerPaiementMenuItem.Text = "Annuler Paiement";
            this.annulerPaiementMenuItem.Click += new System.EventHandler(this.annulerPaiementMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitMenuItem.Text = "&Quitter";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Système de gestion Multi Locations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLocationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLocationMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem paiementMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectuerPaiementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerPaiementMenuItem;
    }
}