
namespace P24_Tp2
{
    partial class frmRechercher
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
            this.grpRechercherEtudiant = new System.Windows.Forms.GroupBox();
            this.txtCodePermanentRecherche = new System.Windows.Forms.TextBox();
            this.txtPrenomRecherche = new System.Windows.Forms.TextBox();
            this.txtNomRecherche = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCodePermanent = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.grpOptionsRechercher = new System.Windows.Forms.GroupBox();
            this.optCodePermanent = new System.Windows.Forms.RadioButton();
            this.optPrenom = new System.Windows.Forms.RadioButton();
            this.optNom = new System.Windows.Forms.RadioButton();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.cmdChoisir = new System.Windows.Forms.Button();
            this.cmdProchain = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnomecole = new System.Windows.Forms.Label();
            this.lblEtudiantTrouver = new System.Windows.Forms.Label();
            this.grpRechercherEtudiant.SuspendLayout();
            this.grpOptionsRechercher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRechercherEtudiant
            // 
            this.grpRechercherEtudiant.Controls.Add(this.txtCodePermanentRecherche);
            this.grpRechercherEtudiant.Controls.Add(this.txtPrenomRecherche);
            this.grpRechercherEtudiant.Controls.Add(this.txtNomRecherche);
            this.grpRechercherEtudiant.Controls.Add(this.lblNom);
            this.grpRechercherEtudiant.Controls.Add(this.lblCodePermanent);
            this.grpRechercherEtudiant.Controls.Add(this.lblPrenom);
            this.grpRechercherEtudiant.Location = new System.Drawing.Point(348, 183);
            this.grpRechercherEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.grpRechercherEtudiant.Name = "grpRechercherEtudiant";
            this.grpRechercherEtudiant.Padding = new System.Windows.Forms.Padding(4);
            this.grpRechercherEtudiant.Size = new System.Drawing.Size(583, 251);
            this.grpRechercherEtudiant.TabIndex = 3;
            this.grpRechercherEtudiant.TabStop = false;
            this.grpRechercherEtudiant.Text = "Étudiant";
            // 
            // txtCodePermanentRecherche
            // 
            this.txtCodePermanentRecherche.Location = new System.Drawing.Point(202, 185);
            this.txtCodePermanentRecherche.Name = "txtCodePermanentRecherche";
            this.txtCodePermanentRecherche.ReadOnly = true;
            this.txtCodePermanentRecherche.Size = new System.Drawing.Size(340, 28);
            this.txtCodePermanentRecherche.TabIndex = 5;
            // 
            // txtPrenomRecherche
            // 
            this.txtPrenomRecherche.Location = new System.Drawing.Point(202, 124);
            this.txtPrenomRecherche.Name = "txtPrenomRecherche";
            this.txtPrenomRecherche.ReadOnly = true;
            this.txtPrenomRecherche.Size = new System.Drawing.Size(340, 28);
            this.txtPrenomRecherche.TabIndex = 3;
            // 
            // txtNomRecherche
            // 
            this.txtNomRecherche.Location = new System.Drawing.Point(202, 60);
            this.txtNomRecherche.Name = "txtNomRecherche";
            this.txtNomRecherche.ReadOnly = true;
            this.txtNomRecherche.Size = new System.Drawing.Size(340, 28);
            this.txtNomRecherche.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Location = new System.Drawing.Point(7, 60);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(173, 28);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblCodePermanent
            // 
            this.lblCodePermanent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodePermanent.Location = new System.Drawing.Point(7, 185);
            this.lblCodePermanent.Name = "lblCodePermanent";
            this.lblCodePermanent.Size = new System.Drawing.Size(173, 28);
            this.lblCodePermanent.TabIndex = 4;
            this.lblCodePermanent.Text = "Code Permanent :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrenom.Location = new System.Drawing.Point(7, 124);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(173, 28);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblRechercher
            // 
            this.lblRechercher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRechercher.Location = new System.Drawing.Point(368, 55);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(136, 26);
            this.lblRechercher.TabIndex = 1;
            this.lblRechercher.Text = "Rechercher :";
            // 
            // grpOptionsRechercher
            // 
            this.grpOptionsRechercher.Controls.Add(this.optCodePermanent);
            this.grpOptionsRechercher.Controls.Add(this.optPrenom);
            this.grpOptionsRechercher.Controls.Add(this.optNom);
            this.grpOptionsRechercher.Location = new System.Drawing.Point(38, 183);
            this.grpOptionsRechercher.Name = "grpOptionsRechercher";
            this.grpOptionsRechercher.Size = new System.Drawing.Size(266, 226);
            this.grpOptionsRechercher.TabIndex = 0;
            this.grpOptionsRechercher.TabStop = false;
            this.grpOptionsRechercher.Text = "Options de recherche";
            // 
            // optCodePermanent
            // 
            this.optCodePermanent.AutoSize = true;
            this.optCodePermanent.Location = new System.Drawing.Point(26, 156);
            this.optCodePermanent.Name = "optCodePermanent";
            this.optCodePermanent.Size = new System.Drawing.Size(184, 26);
            this.optCodePermanent.TabIndex = 2;
            this.optCodePermanent.TabStop = true;
            this.optCodePermanent.Text = "Code Permanent";
            this.optCodePermanent.UseVisualStyleBackColor = true;
            // 
            // optPrenom
            // 
            this.optPrenom.AutoSize = true;
            this.optPrenom.Location = new System.Drawing.Point(26, 111);
            this.optPrenom.Name = "optPrenom";
            this.optPrenom.Size = new System.Drawing.Size(102, 26);
            this.optPrenom.TabIndex = 1;
            this.optPrenom.TabStop = true;
            this.optPrenom.Text = "Prénom";
            this.optPrenom.UseVisualStyleBackColor = true;
            // 
            // optNom
            // 
            this.optNom.AutoSize = true;
            this.optNom.Location = new System.Drawing.Point(26, 68);
            this.optNom.Name = "optNom";
            this.optNom.Size = new System.Drawing.Size(73, 26);
            this.optNom.TabIndex = 0;
            this.optNom.TabStop = true;
            this.optNom.Text = "Nom";
            this.optNom.UseVisualStyleBackColor = true;
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(554, 55);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(390, 28);
            this.txtRechercher.TabIndex = 2;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // cmdChoisir
            // 
            this.cmdChoisir.Location = new System.Drawing.Point(355, 466);
            this.cmdChoisir.Name = "cmdChoisir";
            this.cmdChoisir.Size = new System.Drawing.Size(149, 44);
            this.cmdChoisir.TabIndex = 4;
            this.cmdChoisir.Text = "Choisir";
            this.cmdChoisir.UseVisualStyleBackColor = true;
            this.cmdChoisir.Click += new System.EventHandler(this.cmdChoisir_Click);
            // 
            // cmdProchain
            // 
            this.cmdProchain.Location = new System.Drawing.Point(550, 466);
            this.cmdProchain.Name = "cmdProchain";
            this.cmdProchain.Size = new System.Drawing.Size(149, 44);
            this.cmdProchain.TabIndex = 5;
            this.cmdProchain.Text = "Prochain";
            this.cmdProchain.UseVisualStyleBackColor = true;
            this.cmdProchain.Click += new System.EventHandler(this.cmdProchain_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.Location = new System.Drawing.Point(741, 466);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(149, 44);
            this.cmdFermer.TabIndex = 6;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P24_Tp2.Properties.Resources.logo10_1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblnomecole
            // 
            this.lblnomecole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnomecole.Location = new System.Drawing.Point(126, 55);
            this.lblnomecole.Name = "lblnomecole";
            this.lblnomecole.Size = new System.Drawing.Size(216, 21);
            this.lblnomecole.TabIndex = 11;
            this.lblnomecole.Text = "L’école du Petit Moulin ";
            // 
            // lblEtudiantTrouver
            // 
            this.lblEtudiantTrouver.AutoSize = true;
            this.lblEtudiantTrouver.Location = new System.Drawing.Point(550, 118);
            this.lblEtudiantTrouver.Name = "lblEtudiantTrouver";
            this.lblEtudiantTrouver.Size = new System.Drawing.Size(0, 22);
            this.lblEtudiantTrouver.TabIndex = 12;
            // 
            // frmRechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1054, 603);
            this.Controls.Add(this.lblEtudiantTrouver);
            this.Controls.Add(this.lblnomecole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdProchain);
            this.Controls.Add(this.cmdChoisir);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.grpOptionsRechercher);
            this.Controls.Add(this.lblRechercher);
            this.Controls.Add(this.grpRechercherEtudiant);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRechercher";
            this.Text = "frmRechercher";
            this.Load += new System.EventHandler(this.frmRechercher_Load);
            this.grpRechercherEtudiant.ResumeLayout(false);
            this.grpRechercherEtudiant.PerformLayout();
            this.grpOptionsRechercher.ResumeLayout(false);
            this.grpOptionsRechercher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRechercherEtudiant;
        private System.Windows.Forms.TextBox txtCodePermanentRecherche;
        private System.Windows.Forms.TextBox txtPrenomRecherche;
        private System.Windows.Forms.TextBox txtNomRecherche;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCodePermanent;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.GroupBox grpOptionsRechercher;
        private System.Windows.Forms.RadioButton optNom;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.RadioButton optCodePermanent;
        private System.Windows.Forms.RadioButton optPrenom;
        private System.Windows.Forms.Button cmdChoisir;
        private System.Windows.Forms.Button cmdProchain;
        private System.Windows.Forms.Button cmdFermer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnomecole;
        private System.Windows.Forms.Label lblEtudiantTrouver;
    }
}