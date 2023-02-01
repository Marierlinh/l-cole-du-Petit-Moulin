
namespace P24_Tp2
{
    partial class frmConnexion
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
            this.components = new System.ComponentModel.Container();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotpass = new System.Windows.Forms.TextBox();
            this.cmdConnexion = new System.Windows.Forms.Button();
            this.lblNomdUtilisateur = new System.Windows.Forms.Label();
            this.lblMotdepasse = new System.Windows.Forms.Label();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ckbmontrerMotPasse = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnomecole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(310, 107);
            this.txtUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txtUtilisateur.MaxLength = 30;
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(276, 28);
            this.txtUtilisateur.TabIndex = 0;
            // 
            // txtMotpass
            // 
            this.txtMotpass.Location = new System.Drawing.Point(310, 162);
            this.txtMotpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotpass.MaxLength = 30;
            this.txtMotpass.Name = "txtMotpass";
            this.txtMotpass.Size = new System.Drawing.Size(276, 28);
            this.txtMotpass.TabIndex = 1;
            this.txtMotpass.UseSystemPasswordChar = true;
            this.txtMotpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotpass_KeyPress);
            // 
            // cmdConnexion
            // 
            this.cmdConnexion.Location = new System.Drawing.Point(310, 271);
            this.cmdConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConnexion.Name = "cmdConnexion";
            this.cmdConnexion.Size = new System.Drawing.Size(129, 36);
            this.cmdConnexion.TabIndex = 2;
            this.cmdConnexion.Text = "Connexion";
            this.cmdConnexion.UseVisualStyleBackColor = true;
            this.cmdConnexion.Click += new System.EventHandler(this.cmdConnexion_Click);
            // 
            // lblNomdUtilisateur
            // 
            this.lblNomdUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomdUtilisateur.Location = new System.Drawing.Point(82, 106);
            this.lblNomdUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomdUtilisateur.Name = "lblNomdUtilisateur";
            this.lblNomdUtilisateur.Size = new System.Drawing.Size(189, 29);
            this.lblNomdUtilisateur.TabIndex = 3;
            this.lblNomdUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // lblMotdepasse
            // 
            this.lblMotdepasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMotdepasse.Location = new System.Drawing.Point(82, 164);
            this.lblMotdepasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotdepasse.Name = "lblMotdepasse";
            this.lblMotdepasse.Size = new System.Drawing.Size(189, 28);
            this.lblMotdepasse.TabIndex = 4;
            this.lblMotdepasse.Text = "Mot de passe :";
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(458, 271);
            this.cmdAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(127, 36);
            this.cmdAnnuler.TabIndex = 5;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // ckbmontrerMotPasse
            // 
            this.ckbmontrerMotPasse.BackColor = System.Drawing.Color.Transparent;
            this.ckbmontrerMotPasse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbmontrerMotPasse.Location = new System.Drawing.Point(310, 197);
            this.ckbmontrerMotPasse.Name = "ckbmontrerMotPasse";
            this.ckbmontrerMotPasse.Size = new System.Drawing.Size(173, 30);
            this.ckbmontrerMotPasse.TabIndex = 6;
            this.ckbmontrerMotPasse.Text = "montrer le mot de passe";
            this.ckbmontrerMotPasse.UseVisualStyleBackColor = false;
            this.ckbmontrerMotPasse.CheckedChanged += new System.EventHandler(this.ckbmontrerMotPasse_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::P24_Tp2.Properties.Resources.logo10_1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 92);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblnomecole
            // 
            this.lblnomecole.AutoSize = true;
            this.lblnomecole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnomecole.Location = new System.Drawing.Point(101, 43);
            this.lblnomecole.Name = "lblnomecole";
            this.lblnomecole.Size = new System.Drawing.Size(221, 22);
            this.lblnomecole.TabIndex = 8;
            this.lblnomecole.Text = "L’école du Petit Moulin ";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 320);
            this.Controls.Add(this.lblnomecole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbmontrerMotPasse);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.lblMotdepasse);
            this.Controls.Add(this.lblNomdUtilisateur);
            this.Controls.Add(this.cmdConnexion);
            this.Controls.Add(this.txtMotpass);
            this.Controls.Add(this.txtUtilisateur);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConnexion";
            this.Text = "frmConnexion";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.TextBox txtMotpass;
        private System.Windows.Forms.Button cmdConnexion;
        private System.Windows.Forms.Label lblNomdUtilisateur;
        private System.Windows.Forms.Label lblMotdepasse;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.CheckBox ckbmontrerMotPasse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnomecole;
    }
}