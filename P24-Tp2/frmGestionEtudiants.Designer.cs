
namespace P24_Tp2
{
    partial class frmGestionEtudiants
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
            this.grpEtudiant = new System.Windows.Forms.GroupBox();
            this.mskNodi = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.mskCodePermanent = new System.Windows.Forms.MaskedTextBox();
            this.lblCodePermanent = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.grpSexe = new System.Windows.Forms.GroupBox();
            this.optMasculin = new System.Windows.Forms.RadioButton();
            this.optFeminin = new System.Windows.Forms.RadioButton();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNoid = new System.Windows.Forms.Label();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.cmdSuivant = new System.Windows.Forms.Button();
            this.cmdPrecedent = new System.Windows.Forms.Button();
            this.cmdDernier = new System.Windows.Forms.Button();
            this.cmdPremier = new System.Windows.Forms.Button();
            this.grpResultats = new System.Windows.Forms.GroupBox();
            this.numTp2 = new System.Windows.Forms.NumericUpDown();
            this.numTp1 = new System.Windows.Forms.NumericUpDown();
            this.numFinal = new System.Windows.Forms.NumericUpDown();
            this.numIntra = new System.Windows.Forms.NumericUpDown();
            this.lblTp2 = new System.Windows.Forms.Label();
            this.lblTp1 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblIntra = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdEnlever = new System.Windows.Forms.Button();
            this.cmdInscrire = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picEcole = new System.Windows.Forms.PictureBox();
            this.lblNomEcole = new System.Windows.Forms.Label();
            this.grpEtudiant.SuspendLayout();
            this.grpSexe.SuspendLayout();
            this.grpNavigation.SuspendLayout();
            this.grpResultats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEcole)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEtudiant
            // 
            this.grpEtudiant.Controls.Add(this.mskNodi);
            this.grpEtudiant.Controls.Add(this.dtpDateNaissance);
            this.grpEtudiant.Controls.Add(this.mskTel);
            this.grpEtudiant.Controls.Add(this.mskCodePostal);
            this.grpEtudiant.Controls.Add(this.txtVille);
            this.grpEtudiant.Controls.Add(this.txtAdresse);
            this.grpEtudiant.Controls.Add(this.txtNom);
            this.grpEtudiant.Controls.Add(this.txtPrenom);
            this.grpEtudiant.Controls.Add(this.mskCodePermanent);
            this.grpEtudiant.Controls.Add(this.lblCodePermanent);
            this.grpEtudiant.Controls.Add(this.lblTel);
            this.grpEtudiant.Controls.Add(this.lblCodePostal);
            this.grpEtudiant.Controls.Add(this.lblVille);
            this.grpEtudiant.Controls.Add(this.grpSexe);
            this.grpEtudiant.Controls.Add(this.lblPrenom);
            this.grpEtudiant.Controls.Add(this.lblNom);
            this.grpEtudiant.Controls.Add(this.lblDateNaissance);
            this.grpEtudiant.Controls.Add(this.lblAdresse);
            this.grpEtudiant.Controls.Add(this.lblNoid);
            this.grpEtudiant.Enabled = false;
            this.grpEtudiant.Location = new System.Drawing.Point(12, 86);
            this.grpEtudiant.Name = "grpEtudiant";
            this.grpEtudiant.Size = new System.Drawing.Size(501, 487);
            this.grpEtudiant.TabIndex = 0;
            this.grpEtudiant.TabStop = false;
            this.grpEtudiant.Text = "Étudiant";
            // 
            // mskNodi
            // 
            this.mskNodi.Location = new System.Drawing.Point(200, 37);
            this.mskNodi.Mask = "LLLL0";
            this.mskNodi.Name = "mskNodi";
            this.mskNodi.ReadOnly = true;
            this.mskNodi.Size = new System.Drawing.Size(79, 28);
            this.mskNodi.TabIndex = 18;
            this.mskNodi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.CausesValidation = false;
            this.dtpDateNaissance.Checked = false;
            this.dtpDateNaissance.CustomFormat = "DD-MM-YYYY";
            this.dtpDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNaissance.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpDateNaissance.Location = new System.Drawing.Point(201, 158);
            this.dtpDateNaissance.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpDateNaissance.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.ShowCheckBox = true;
            this.dtpDateNaissance.ShowUpDown = true;
            this.dtpDateNaissance.Size = new System.Drawing.Size(238, 28);
            this.dtpDateNaissance.TabIndex = 5;
            this.dtpDateNaissance.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(200, 409);
            this.mskTel.Mask = "(000) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(128, 28);
            this.mskTel.TabIndex = 14;
            this.mskTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskCodePostal
            // 
            this.mskCodePostal.Location = new System.Drawing.Point(200, 377);
            this.mskCodePostal.Mask = "L0L-0L0";
            this.mskCodePostal.Name = "mskCodePostal";
            this.mskCodePostal.Size = new System.Drawing.Size(79, 28);
            this.mskCodePostal.TabIndex = 12;
            this.mskCodePostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVille
            // 
            this.txtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVille.Location = new System.Drawing.Point(200, 342);
            this.txtVille.MaxLength = 30;
            this.txtVille.Multiline = true;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(281, 28);
            this.txtVille.TabIndex = 10;
            // 
            // txtAdresse
            // 
            this.txtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdresse.Location = new System.Drawing.Point(200, 311);
            this.txtAdresse.MaxLength = 30;
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(281, 28);
            this.txtAdresse.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Location = new System.Drawing.Point(200, 120);
            this.txtNom.MaxLength = 20;
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(281, 28);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valider_Chaine);
            // 
            // txtPrenom
            // 
            this.txtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrenom.Location = new System.Drawing.Point(200, 80);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(281, 28);
            this.txtPrenom.TabIndex = 1;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valider_Chaine);
            // 
            // mskCodePermanent
            // 
            this.mskCodePermanent.Location = new System.Drawing.Point(200, 445);
            this.mskCodePermanent.Mask = "LLLL00000000";
            this.mskCodePermanent.Name = "mskCodePermanent";
            this.mskCodePermanent.Size = new System.Drawing.Size(128, 28);
            this.mskCodePermanent.TabIndex = 16;
            this.mskCodePermanent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodePermanent
            // 
            this.lblCodePermanent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodePermanent.Location = new System.Drawing.Point(20, 447);
            this.lblCodePermanent.Name = "lblCodePermanent";
            this.lblCodePermanent.Size = new System.Drawing.Size(174, 26);
            this.lblCodePermanent.TabIndex = 15;
            this.lblCodePermanent.Text = "Code Permanent :";
            // 
            // lblTel
            // 
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTel.Location = new System.Drawing.Point(20, 411);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(174, 26);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Téléphone : ";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodePostal.Location = new System.Drawing.Point(20, 377);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(174, 28);
            this.lblCodePostal.TabIndex = 11;
            this.lblCodePostal.Text = "Code Postal : ";
            // 
            // lblVille
            // 
            this.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVille.Location = new System.Drawing.Point(20, 344);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(174, 26);
            this.lblVille.TabIndex = 9;
            this.lblVille.Text = "Ville : ";
            // 
            // grpSexe
            // 
            this.grpSexe.Controls.Add(this.optMasculin);
            this.grpSexe.Controls.Add(this.optFeminin);
            this.grpSexe.Location = new System.Drawing.Point(78, 202);
            this.grpSexe.Name = "grpSexe";
            this.grpSexe.Size = new System.Drawing.Size(171, 93);
            this.grpSexe.TabIndex = 6;
            this.grpSexe.TabStop = false;
            this.grpSexe.Text = "Sexe";
            // 
            // optMasculin
            // 
            this.optMasculin.AutoSize = true;
            this.optMasculin.Location = new System.Drawing.Point(14, 61);
            this.optMasculin.Name = "optMasculin";
            this.optMasculin.Size = new System.Drawing.Size(111, 26);
            this.optMasculin.TabIndex = 1;
            this.optMasculin.Text = "Masculin";
            this.optMasculin.UseVisualStyleBackColor = true;
            // 
            // optFeminin
            // 
            this.optFeminin.AutoSize = true;
            this.optFeminin.Location = new System.Drawing.Point(14, 28);
            this.optFeminin.Name = "optFeminin";
            this.optFeminin.Size = new System.Drawing.Size(102, 26);
            this.optFeminin.TabIndex = 0;
            this.optFeminin.Text = "Féminin";
            this.optFeminin.UseVisualStyleBackColor = true;
            // 
            // lblPrenom
            // 
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrenom.Location = new System.Drawing.Point(20, 81);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(174, 27);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Location = new System.Drawing.Point(20, 120);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(174, 27);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateNaissance.Location = new System.Drawing.Point(20, 158);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(174, 32);
            this.lblDateNaissance.TabIndex = 4;
            this.lblDateNaissance.Text = "Date Naissance :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdresse.Location = new System.Drawing.Point(20, 311);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(174, 28);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse : ";
            // 
            // lblNoid
            // 
            this.lblNoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoid.Location = new System.Drawing.Point(20, 39);
            this.lblNoid.Name = "lblNoid";
            this.lblNoid.Size = new System.Drawing.Size(174, 27);
            this.lblNoid.TabIndex = 17;
            this.lblNoid.Text = "No id:";
            // 
            // grpNavigation
            // 
            this.grpNavigation.Controls.Add(this.lblEtudiant);
            this.grpNavigation.Controls.Add(this.cmdSuivant);
            this.grpNavigation.Controls.Add(this.cmdPrecedent);
            this.grpNavigation.Controls.Add(this.cmdDernier);
            this.grpNavigation.Controls.Add(this.cmdPremier);
            this.grpNavigation.Location = new System.Drawing.Point(12, 589);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(501, 67);
            this.grpNavigation.TabIndex = 2;
            this.grpNavigation.TabStop = false;
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.BackColor = System.Drawing.Color.Silver;
            this.lblEtudiant.Location = new System.Drawing.Point(124, 18);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(257, 41);
            this.lblEtudiant.TabIndex = 2;
            this.lblEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSuivant
            // 
            this.cmdSuivant.Location = new System.Drawing.Point(387, 18);
            this.cmdSuivant.Name = "cmdSuivant";
            this.cmdSuivant.Size = new System.Drawing.Size(51, 43);
            this.cmdSuivant.TabIndex = 3;
            this.cmdSuivant.Text = ">";
            this.cmdSuivant.UseVisualStyleBackColor = true;
            this.cmdSuivant.Click += new System.EventHandler(this.cmdSuivant_Click);
            // 
            // cmdPrecedent
            // 
            this.cmdPrecedent.Location = new System.Drawing.Point(67, 18);
            this.cmdPrecedent.Name = "cmdPrecedent";
            this.cmdPrecedent.Size = new System.Drawing.Size(51, 43);
            this.cmdPrecedent.TabIndex = 1;
            this.cmdPrecedent.Text = "<";
            this.cmdPrecedent.UseVisualStyleBackColor = true;
            this.cmdPrecedent.Click += new System.EventHandler(this.cmdPrecedent_Click);
            // 
            // cmdDernier
            // 
            this.cmdDernier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdDernier.Location = new System.Drawing.Point(444, 18);
            this.cmdDernier.Name = "cmdDernier";
            this.cmdDernier.Size = new System.Drawing.Size(51, 43);
            this.cmdDernier.TabIndex = 4;
            this.cmdDernier.Text = ">|";
            this.cmdDernier.UseVisualStyleBackColor = true;
            this.cmdDernier.Click += new System.EventHandler(this.cmdDernier_Click);
            // 
            // cmdPremier
            // 
            this.cmdPremier.Location = new System.Drawing.Point(10, 18);
            this.cmdPremier.Name = "cmdPremier";
            this.cmdPremier.Size = new System.Drawing.Size(51, 43);
            this.cmdPremier.TabIndex = 0;
            this.cmdPremier.Text = "|<";
            this.cmdPremier.UseVisualStyleBackColor = true;
            this.cmdPremier.Click += new System.EventHandler(this.cmdPremier_Click_1);
            // 
            // grpResultats
            // 
            this.grpResultats.Controls.Add(this.numTp2);
            this.grpResultats.Controls.Add(this.numTp1);
            this.grpResultats.Controls.Add(this.numFinal);
            this.grpResultats.Controls.Add(this.numIntra);
            this.grpResultats.Controls.Add(this.lblTp2);
            this.grpResultats.Controls.Add(this.lblTp1);
            this.grpResultats.Controls.Add(this.lblFinal);
            this.grpResultats.Controls.Add(this.lblIntra);
            this.grpResultats.Enabled = false;
            this.grpResultats.Location = new System.Drawing.Point(550, 402);
            this.grpResultats.Name = "grpResultats";
            this.grpResultats.Size = new System.Drawing.Size(282, 254);
            this.grpResultats.TabIndex = 1;
            this.grpResultats.TabStop = false;
            this.grpResultats.Text = "Résultats";
            // 
            // numTp2
            // 
            this.numTp2.DecimalPlaces = 2;
            this.numTp2.Location = new System.Drawing.Point(130, 198);
            this.numTp2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.numTp2.Name = "numTp2";
            this.numTp2.Size = new System.Drawing.Size(120, 28);
            this.numTp2.TabIndex = 7;
            // 
            // numTp1
            // 
            this.numTp1.DecimalPlaces = 2;
            this.numTp1.Location = new System.Drawing.Point(130, 142);
            this.numTp1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.numTp1.Name = "numTp1";
            this.numTp1.Size = new System.Drawing.Size(120, 28);
            this.numTp1.TabIndex = 5;
            // 
            // numFinal
            // 
            this.numFinal.DecimalPlaces = 2;
            this.numFinal.Location = new System.Drawing.Point(130, 91);
            this.numFinal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.numFinal.Name = "numFinal";
            this.numFinal.Size = new System.Drawing.Size(120, 28);
            this.numFinal.TabIndex = 3;
            // 
            // numIntra
            // 
            this.numIntra.DecimalPlaces = 2;
            this.numIntra.Location = new System.Drawing.Point(130, 35);
            this.numIntra.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.numIntra.Name = "numIntra";
            this.numIntra.Size = new System.Drawing.Size(120, 28);
            this.numIntra.TabIndex = 1;
            // 
            // lblTp2
            // 
            this.lblTp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTp2.Location = new System.Drawing.Point(15, 198);
            this.lblTp2.Name = "lblTp2";
            this.lblTp2.Size = new System.Drawing.Size(94, 27);
            this.lblTp2.TabIndex = 6;
            this.lblTp2.Text = "Tp2 :";
            // 
            // lblTp1
            // 
            this.lblTp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTp1.Location = new System.Drawing.Point(15, 144);
            this.lblTp1.Name = "lblTp1";
            this.lblTp1.Size = new System.Drawing.Size(94, 27);
            this.lblTp1.TabIndex = 4;
            this.lblTp1.Text = "Tp1 :";
            // 
            // lblFinal
            // 
            this.lblFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinal.Location = new System.Drawing.Point(15, 91);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(94, 27);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "Final :";
            // 
            // lblIntra
            // 
            this.lblIntra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIntra.Location = new System.Drawing.Point(15, 39);
            this.lblIntra.Name = "lblIntra";
            this.lblIntra.Size = new System.Drawing.Size(94, 27);
            this.lblIntra.TabIndex = 0;
            this.lblIntra.Text = "Intra :";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(611, 164);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(181, 45);
            this.cmdOk.TabIndex = 5;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click_1);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(611, 92);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(181, 46);
            this.cmdModifier.TabIndex = 4;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdEnlever
            // 
            this.cmdEnlever.Location = new System.Drawing.Point(611, 319);
            this.cmdEnlever.Name = "cmdEnlever";
            this.cmdEnlever.Size = new System.Drawing.Size(181, 48);
            this.cmdEnlever.TabIndex = 7;
            this.cmdEnlever.Text = "Enlever";
            this.cmdEnlever.UseVisualStyleBackColor = true;
            this.cmdEnlever.Click += new System.EventHandler(this.cmdEnlever_Click);
            // 
            // cmdInscrire
            // 
            this.cmdInscrire.Location = new System.Drawing.Point(611, 23);
            this.cmdInscrire.Name = "cmdInscrire";
            this.cmdInscrire.Size = new System.Drawing.Size(181, 46);
            this.cmdInscrire.TabIndex = 3;
            this.cmdInscrire.Text = "Inscrire";
            this.cmdInscrire.UseVisualStyleBackColor = true;
            this.cmdInscrire.Click += new System.EventHandler(this.cmdInscrire_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(611, 241);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(181, 49);
            this.cmdAnnuler.TabIndex = 6;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click_1);
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // picEcole
            // 
            this.picEcole.Image = global::P24_Tp2.Properties.Resources.logo10_1;
            this.picEcole.Location = new System.Drawing.Point(2, -7);
            this.picEcole.Name = "picEcole";
            this.picEcole.Size = new System.Drawing.Size(91, 87);
            this.picEcole.TabIndex = 8;
            this.picEcole.TabStop = false;
            // 
            // lblNomEcole
            // 
            this.lblNomEcole.AutoSize = true;
            this.lblNomEcole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNomEcole.Location = new System.Drawing.Point(99, 36);
            this.lblNomEcole.Name = "lblNomEcole";
            this.lblNomEcole.Size = new System.Drawing.Size(221, 22);
            this.lblNomEcole.TabIndex = 9;
            this.lblNomEcole.Text = "L’école du Petit Moulin ";
            // 
            // frmGestionEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(867, 673);
            this.Controls.Add(this.lblNomEcole);
            this.Controls.Add(this.picEcole);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdInscrire);
            this.Controls.Add(this.cmdEnlever);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.grpResultats);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.grpEtudiant);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionEtudiants";
            this.Text = "Gestion Étudiants";
            this.Load += new System.EventHandler(this.frmGestionEtudiants_Load);
            this.grpEtudiant.ResumeLayout(false);
            this.grpEtudiant.PerformLayout();
            this.grpSexe.ResumeLayout(false);
            this.grpSexe.PerformLayout();
            this.grpNavigation.ResumeLayout(false);
            this.grpResultats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEcole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEtudiant;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.MaskedTextBox mskCodePermanent;
        private System.Windows.Forms.Label lblCodePermanent;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.GroupBox grpSexe;
        private System.Windows.Forms.RadioButton optMasculin;
        private System.Windows.Forms.RadioButton optFeminin;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNoid;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.Button cmdSuivant;
        private System.Windows.Forms.Button cmdPrecedent;
        private System.Windows.Forms.Button cmdPremier;
        private System.Windows.Forms.GroupBox grpResultats;
        private System.Windows.Forms.NumericUpDown numIntra;
        private System.Windows.Forms.Label lblTp2;
        private System.Windows.Forms.Label lblTp1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblIntra;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdEnlever;
        private System.Windows.Forms.Button cmdInscrire;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numTp2;
        private System.Windows.Forms.NumericUpDown numTp1;
        private System.Windows.Forms.NumericUpDown numFinal;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Button cmdDernier;
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.MaskedTextBox mskNodi;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.PictureBox picEcole;
        private System.Windows.Forms.Label lblNomEcole;
    }
}