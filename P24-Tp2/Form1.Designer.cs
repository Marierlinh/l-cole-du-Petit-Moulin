
namespace P24_Tp2
{
    partial class FrmMdi
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionEtudiants = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListeEtudiant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparateur1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApropos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNomEcole = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.aideToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1415, 28);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            this.mnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuPrincipal_ItemClicked);
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestionEtudiants,
            this.mnuListeEtudiant,
            this.mnuSeparateur1,
            this.mnuQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(66, 24);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuGestionEtudiants
            // 
            this.mnuGestionEtudiants.Name = "mnuGestionEtudiants";
            this.mnuGestionEtudiants.Size = new System.Drawing.Size(224, 26);
            this.mnuGestionEtudiants.Text = "Gestion Étudiants";
            this.mnuGestionEtudiants.Click += new System.EventHandler(this.mnuGestionEtudiants_Click);
            // 
            // mnuListeEtudiant
            // 
            this.mnuListeEtudiant.Name = "mnuListeEtudiant";
            this.mnuListeEtudiant.Size = new System.Drawing.Size(224, 26);
            this.mnuListeEtudiant.Text = "Liste Étudiants";
            this.mnuListeEtudiant.Click += new System.EventHandler(this.mnuListeEtudiant_Click);
            // 
            // mnuSeparateur1
            // 
            this.mnuSeparateur1.Name = "mnuSeparateur1";
            this.mnuSeparateur1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.Size = new System.Drawing.Size(224, 26);
            this.mnuQuitter.Text = "Quitter";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuApropos});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // mnuApropos
            // 
            this.mnuApropos.Name = "mnuApropos";
            this.mnuApropos.Size = new System.Drawing.Size(153, 26);
            this.mnuApropos.Text = "À propos";
            this.mnuApropos.Click += new System.EventHandler(this.mnuApropos_Click);
            // 
            // lblNomEcole
            // 
            this.lblNomEcole.AutoSize = true;
            this.lblNomEcole.Location = new System.Drawing.Point(296, 322);
            this.lblNomEcole.Name = "lblNomEcole";
            this.lblNomEcole.Size = new System.Drawing.Size(0, 22);
            this.lblNomEcole.TabIndex = 3;
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 843);
            this.Controls.Add(this.lblNomEcole);
            this.Controls.Add(this.mnuPrincipal);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMdi";
            this.Text = "École Petit Moulin";
            this.Load += new System.EventHandler(this.FrmMdi_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionEtudiants;
        private System.Windows.Forms.ToolStripMenuItem mnuListeEtudiant;
        private System.Windows.Forms.ToolStripSeparator mnuSeparateur1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuApropos;
        private System.Windows.Forms.Label lblNomEcole;
    }
}

