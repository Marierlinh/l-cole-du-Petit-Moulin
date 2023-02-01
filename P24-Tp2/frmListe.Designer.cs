
namespace P24_Tp2
{
    partial class frmListe
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
            this.lvEtudiants = new System.Windows.Forms.ListView();
            this.cmdStatisques = new System.Windows.Forms.Button();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.cmdAfficherTous = new System.Windows.Forms.Button();
            this.lslListedEtudiants = new System.Windows.Forms.Label();
            this.lblnomecole = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdVider = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codePermanentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisquesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEtudiants
            // 
            this.lvEtudiants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEtudiants.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvEtudiants.FullRowSelect = true;
            this.lvEtudiants.GridLines = true;
            this.lvEtudiants.HideSelection = false;
            this.lvEtudiants.Location = new System.Drawing.Point(23, 159);
            this.lvEtudiants.Name = "lvEtudiants";
            this.lvEtudiants.Size = new System.Drawing.Size(1135, 423);
            this.lvEtudiants.TabIndex = 0;
            this.lvEtudiants.UseCompatibleStateImageBehavior = false;
            this.lvEtudiants.View = System.Windows.Forms.View.Details;
            this.lvEtudiants.SelectedIndexChanged += new System.EventHandler(this.lvEtudiants_SelectedIndexChanged);
            // 
            // cmdStatisques
            // 
            this.cmdStatisques.AutoSize = true;
            this.cmdStatisques.Location = new System.Drawing.Point(995, 32);
            this.cmdStatisques.Name = "cmdStatisques";
            this.cmdStatisques.Size = new System.Drawing.Size(151, 43);
            this.cmdStatisques.TabIndex = 1;
            this.cmdStatisques.Text = "Statisques";
            this.cmdStatisques.UseVisualStyleBackColor = true;
            this.cmdStatisques.Click += new System.EventHandler(this.cmdStatisques_Click);
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.AutoSize = true;
            this.cmdRechercher.Location = new System.Drawing.Point(747, 95);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(149, 43);
            this.cmdRechercher.TabIndex = 2;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // cmdAfficherTous
            // 
            this.cmdAfficherTous.Location = new System.Drawing.Point(747, 29);
            this.cmdAfficherTous.Name = "cmdAfficherTous";
            this.cmdAfficherTous.Size = new System.Drawing.Size(149, 43);
            this.cmdAfficherTous.TabIndex = 3;
            this.cmdAfficherTous.Text = "Afficher Tous";
            this.cmdAfficherTous.UseVisualStyleBackColor = true;
            this.cmdAfficherTous.Click += new System.EventHandler(this.cmdAfficherTous_Click);
            // 
            // lslListedEtudiants
            // 
            this.lslListedEtudiants.AutoSize = true;
            this.lslListedEtudiants.Location = new System.Drawing.Point(119, 134);
            this.lslListedEtudiants.Name = "lslListedEtudiants";
            this.lslListedEtudiants.Size = new System.Drawing.Size(161, 22);
            this.lslListedEtudiants.TabIndex = 4;
            this.lslListedEtudiants.Text = "Liste d\'étudiants";
            this.lslListedEtudiants.Click += new System.EventHandler(this.lslListedEtudiants_Click);
            // 
            // lblnomecole
            // 
            this.lblnomecole.AutoSize = true;
            this.lblnomecole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnomecole.Location = new System.Drawing.Point(119, 68);
            this.lblnomecole.Name = "lblnomecole";
            this.lblnomecole.Size = new System.Drawing.Size(221, 22);
            this.lblnomecole.TabIndex = 6;
            this.lblnomecole.Text = "L’école du Petit Moulin ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P24_Tp2.Properties.Resources.logo10_1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmdVider
            // 
            this.cmdVider.Location = new System.Drawing.Point(995, 95);
            this.cmdVider.Name = "cmdVider";
            this.cmdVider.Size = new System.Drawing.Size(151, 43);
            this.cmdVider.TabIndex = 7;
            this.cmdVider.Text = "Vider";
            this.cmdVider.UseVisualStyleBackColor = true;
            this.cmdVider.Click += new System.EventHandler(this.cmdEffacer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem,
            this.statisquesToolStripMenuItem,
            this.statisquesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherTousToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.afficherToolStripMenuItem.Text = "Afficher ";
            // 
            // afficherTousToolStripMenuItem
            // 
            this.afficherTousToolStripMenuItem.Name = "afficherTousToolStripMenuItem";
            this.afficherTousToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.afficherTousToolStripMenuItem.Text = "Afficher Tous";
            // 
            // statisquesToolStripMenuItem
            // 
            this.statisquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codePermanentToolStripMenuItem,
            this.nomToolStripMenuItem,
            this.prenomToolStripMenuItem});
            this.statisquesToolStripMenuItem.Name = "statisquesToolStripMenuItem";
            this.statisquesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.statisquesToolStripMenuItem.Text = "Rechercher";
            // 
            // codePermanentToolStripMenuItem
            // 
            this.codePermanentToolStripMenuItem.Name = "codePermanentToolStripMenuItem";
            this.codePermanentToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.codePermanentToolStripMenuItem.Text = "Code Permanent";
            // 
            // nomToolStripMenuItem
            // 
            this.nomToolStripMenuItem.Name = "nomToolStripMenuItem";
            this.nomToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.nomToolStripMenuItem.Text = "Nom";
            // 
            // prenomToolStripMenuItem
            // 
            this.prenomToolStripMenuItem.Name = "prenomToolStripMenuItem";
            this.prenomToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.prenomToolStripMenuItem.Text = "Prenom";
            // 
            // statisquesToolStripMenuItem1
            // 
            this.statisquesToolStripMenuItem1.Name = "statisquesToolStripMenuItem1";
            this.statisquesToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.statisquesToolStripMenuItem1.Text = "Statisques";
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1182, 647);
            this.Controls.Add(this.cmdVider);
            this.Controls.Add(this.lblnomecole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvEtudiants);
            this.Controls.Add(this.lslListedEtudiants);
            this.Controls.Add(this.cmdAfficherTous);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.cmdStatisques);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Liste d\'étudiants";
            this.Load += new System.EventHandler(this.frmListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtudiants;
        private System.Windows.Forms.Button cmdStatisques;
        private System.Windows.Forms.Button cmdRechercher;
        private System.Windows.Forms.Button cmdAfficherTous;
        private System.Windows.Forms.Label lslListedEtudiants;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnomecole;
        private System.Windows.Forms.Button cmdVider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherTousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codePermanentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisquesToolStripMenuItem1;
    }
}