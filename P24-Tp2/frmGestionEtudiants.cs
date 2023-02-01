using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P24_Tp2
{


    /// <summary>
    /// Cet programme regrouper les fonctionnalités du menu Inscription, MAJ et Destruction dans le même écran. Et dans un autre écran les fonctionnalités Recherche, 
    /// Liste et Statistiques de l’école du Petit Moulin.
    /// 
    /// Fait par: Marierlin Higuerey
    /// le:
    /// modifie le:
    /// </summary>
    public partial class frmGestionEtudiants : Form
    {
        public frmGestionEtudiants()
        {
            InitializeComponent();
        }

        //Variables globales
        int pos = -1; // Indique la position dans le fichier
        public const int longueurEnr = 174; // represente la longueur d'un enregistrement
        int nbEtudiants = 0; // indique le nombre de étudiants dans le fichier
        public const string nomFichier = "Etudiants.bin"; // indique le nom du fichier
        Action actionCourante = Action.Aucune; // Action que nous allons faire sur le fichier
        public enum Action
        {
            Inscription,
            Modification,
            Aucune
        }
       

        private void frmGestionEtudiants_Load(object sender, EventArgs e)
        {
            

            try
            {
                FileStream fs = new FileStream(nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                nbEtudiants = (int)fs.Length / longueurEnr; 

                fs.Close(); 


                if (nbEtudiants > 0)
                {
                    Debarrer(grpNavigation, cmdModifier, cmdEnlever);

                    pos = 0;
                    Recuperer_Etudiant(pos);
                }
            
                else
                {
                    Barrer(grpNavigation, cmdModifier, cmdEnlever, cmdAnnuler, cmdOk);
                }
            }
            catch(Exception ex )
                {
                MessageBox.Show(ex.Message);
                Application.Exit();
                }
        }

        /// <summary>
        /// Cette procédure donne et vérifie le numéro d’identification de l’étudiant
        /// </summary>
        private string Donner_Nodi()
        {
            string Nodi = "";
            int c, i;

            //Liste des éléments à lire pour le numéro à attribuer a l'étudiant 
            string Nodi_etu, Prenom, Nom, DateNaissance, Adresse, Ville, CodePostal, Tel, CodePermanent;
            char Sexe;
            float Tp1, Tp2, Intra, Final;
            bool No_id_valide = true; // Vrai lorsque le no est valide

            try
            {
                // Prendre les trois premières lettres du nom et compléter avec des X si moins de 3 lettres
                if (txtNom.Text.Length < 3)
                {
                    c = 3 - txtNom.Text.Length; /// Nombre de caractéres à compléter avce des X
                    Nodi = txtNom.Text.Substring(0, txtNom.Text.Length).ToUpper();
                    for (i = 0; i < c; i++)
                        Nodi = Nodi + "X";
                }
                else
                {
                    Nodi = txtNom.Text.Substring(0, 3).ToUpper();
                }

                //Ajouter le première lettre du prénom
                Nodi = Nodi + txtPrenom.Text.Substring(0, 1).ToString().ToUpper();

                // Ajouter le numéro séquentiel 0 puis vérifier s'il est unique
                c = 48; // No ACSII pour 0
                Nodi = Nodi + (char)c;

                //verifie que le nodi est unique
                if (nbEtudiants > 0)
                {
                    do // Faire l'exercise tant que le numéro n'est pas unique
                    {
                        No_id_valide = true; // initialiser à vrai pour tester tous les étudiants

                        // Ovrir le fichier
                        FileStream fs = new FileStream(nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                        BinaryReader br = new BinaryReader(fs);

                        for (; ;)
                        {
                            if (br.PeekChar() == -1) break;
                            Nodi_etu = br.ReadString().Trim().ToUpper();
                            Nom = br.ReadString().Trim().ToUpper();
                            Prenom = br.ReadString().Trim().ToUpper();
                            DateNaissance = br.ReadString().Trim();
                            Sexe = br.ReadChar();
                            Adresse = br.ReadString().Trim().ToUpper();
                            Ville = br.ReadString().Trim().ToUpper();
                            CodePostal = br.ReadString().Trim().ToUpper();
                            Tel = br.ReadString().Trim();
                            CodePermanent = br.ReadString().Trim().ToUpper();
                            Intra = br.ReadSingle();
                            Final = br.ReadSingle();
                            Tp1 = br.ReadSingle();
                            Tp2 = br.ReadSingle();


                            //verifier si nodi est unique
                            if (Nodi == Nodi_etu.TrimEnd())
                            {
                                No_id_valide = false;

                                Nodi = Nodi.Substring(0, 4);

                                if (c < 57)
                                {
                                    c++;
                                    Nodi = Nodi + (char)c;
                                }
                                else 
                                {
                                    
                                    br.Close();
                                    fs.Close();
                                    throw (new Exception("Impossible d'attribuer un numero séquentiel!"));
                                }
                            }
                        }
                        br.Close();
                        fs.Close();
                    } while (No_id_valide == false);


                    mskNodi.Text = Nodi;
                }
                return Nodi;
        }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
}

        //private string Valide_CodePermmanent()
        //{
        //    string CodePermanente = "";
        //    int c, i;

        //    //Liste des éléments à lire pour le numéro à attribuer a l'étudiant 
        //    string Nodi_etu, Prenom, Nom, DateNaissance, Adresse, Ville, CodePostal, Tel, Etu_CodePermanent;
        //    int day, mois, year;
        //    char Sexe;
        //    float Tp1, Tp2, Intra, Final;
        //    bool No_codepermanente_valide = true; // Vrai lorsque le no est valide

        //    try
        //    {
        //        // Prendre les trois premières lettres du nom et compléter avec des X si moins de 3 lettres
        //        if (txtNom.Text.Length < 3)
        //        {
        //            c = 3 - txtNom.Text.Length; /// Nombre de caractéres à compléter avce des X
        //            CodePermanente = txtNom.Text.Substring(0, txtNom.Text.Length).ToUpper();
        //            for (i = 0; i < c; i++)
        //                CodePermanente = CodePermanente + "X";
        //        }
        //        else
        //        {
        //            CodePermanente = txtNom.Text.Substring(0, 3).ToUpper();
        //        }

        //        //Ajouter le première lettre du prénom
        //        CodePermanente = CodePermanente + txtPrenom.Text.Substring(0, 1).ToString().ToUpper();

        //        // Ajouter le numéro séquentiel 0 puis vérifier s'il est unique
        //        c = 48; // No ACSII pour 0
        //        CodePermanente = CodePermanente + (char)c;


        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return null;
        //    }
        //}


        private void Recuperer_Etudiant(int position)
        {
            
            try
            {
            // Creer le FileStream et le BinaryReader
            FileStream fs = new FileStream(nomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fs);

            fs.Seek(position * longueurEnr, SeekOrigin.Begin); // Partons du début...

            //  Lire dans le même ordre que l'on écrit

            mskNodi.Text = br.ReadString().Trim().ToUpper(); 
            txtPrenom.Text = br.ReadString().Trim(); 
            txtNom.Text = br.ReadString().Trim();
            dtpDateNaissance.Text = br.ReadString().Trim() ;
            char sexe;
            sexe = br.ReadChar();
            if (sexe == 'F')
                optFeminin.Checked = true;
            else
                optMasculin.Checked = true;
            txtAdresse.Text = br.ReadString().Trim();
            txtVille.Text = br.ReadString().Trim();
            mskCodePostal.Text = br.ReadString().ToUpper();  
            mskTel.Text = br.ReadString();  
            mskCodePermanent.Text = br.ReadString().ToUpper(); 
            numIntra.Value = (decimal)br.ReadSingle();
            numFinal.Value = (decimal)br.ReadSingle();
            numTp1.Value = (decimal)br.ReadSingle();
            numTp2.Value = (decimal)br.ReadSingle();


            // Fermer dans le bon ordre

            br.Close();
            fs.Close();

            //Afficher l'étudiant sur lequel nous sommes positionnés.
            lblEtudiant.Text = "Etudiant" + (position + 1).ToString() + "de" + nbEtudiants;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Debarrer(params Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Enabled = true;
            }
        }

        private void Barrer(params Control[] c)
        {
            foreach (Control ctr in c)
            {
                ctr.Enabled = false;
            }
        }

        private void cmdInscrire_Click(object sender, EventArgs e)
        {

            // Vider le formulaire
            Vider_Formulaire();

            // Barre les différents contrôles
            Barrer(cmdInscrire, cmdModifier, cmdEnlever, grpEtudiant, grpNavigation, grpResultats);

            // Débarrer les différents contrôles
            Debarrer(cmdOk, cmdAnnuler, grpEtudiant, grpResultats);

            // Donner le focus au prénom
            txtPrenom.Focus();

            // 5. Identifier l'action en cours
            actionCourante = Action.Inscription;
            lblEtudiant.Text = " *** Mode Inscription *** ";
            
        }



        private void Vider_Formulaire()
        {
            mskNodi.Clear();
            txtPrenom.Text = "";
            txtNom.Clear();
            dtpDateNaissance.Checked = false;
            optFeminin.Checked = true; // Disons que Féminin est la valeur par défaut
            optMasculin.Checked = false;
            txtAdresse.Text = "";
            txtVille.Text = "";
            mskCodePostal.Clear();
            mskTel.Clear();
            mskCodePermanent.Clear();
            numIntra.Value = 0;
            numFinal.Value = 0;
            numTp1.Value = 0;
            numTp2.Value = 0;
        }

        private void cmdAnnuler_Click_1(object sender, EventArgs e)
        {
            
            err1.Clear();
            actionCourante = Action.Aucune;
            lblEtudiant.Text = " ";
            if (nbEtudiants > 0)
            {
                Barrer(cmdOk, cmdAnnuler, grpEtudiant,grpResultats);
                Debarrer(cmdInscrire, cmdModifier, cmdEnlever, grpNavigation);
                Recuperer_Etudiant(pos);
            }
            else
            {
                Vider_Formulaire();
                Barrer(cmdOk, cmdAnnuler, cmdModifier, cmdEnlever, grpEtudiant, grpNavigation, grpResultats);
                Debarrer(cmdInscrire);
            }
        }


        private Boolean Valider_Formulaire()
        {

            Boolean valide = true;

         
            err1.Clear();

            if (mskNodi.Text.ToUpper() != Donner_Nodi())
            {
                valide = false;
                err1.SetError(mskNodi, "No identifiant invalide");
            }
            if (txtPrenom.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtPrenom, "Entrée invalide,  le prénom est obligatoire");
            }
            if (txtNom.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtNom, "Entrée invalide,  le nom est obligatoire");
            }
            if (dtpDateNaissance.Checked == false)
            {
                valide = false;
                err1.SetError(dtpDateNaissance, "Entrée invalide,  la date de naissance est obligatoire");
            }
            if (optFeminin.Checked == false && optMasculin.Checked == false)
            {
                valide = false;
                err1.SetError(grpSexe, "Sexe obligatoire");
            }
            if (txtAdresse.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtAdresse, "Entrée invalide,  l'adresse est obligatoire");
            }
            if (txtVille.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtVille, "Entrée invalide, la ville est obligatoire");
            }
            if (mskCodePostal.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskCodePostal, "Code Postal invalide");
            }
            if (mskTel.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskTel, " Téléphone invalide");
            }
            if (mskCodePermanent.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskCodePermanent, "Code Permanent invalide");
            }
       

            return valide;

        }

        private void Valider_Chaine(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == ' ' || e.KeyChar == '-' || char.IsLetter(e.KeyChar) == true || e.KeyChar == (char)8) 
                return;
            else
                e.Handled = true;
        }


        private void Ajouter_ou_Modifier_Etudiant()
        {

            try
            {
               
                FileStream fs;

                if (actionCourante == Action.Inscription)
                {
                    fs = new FileStream(nomFichier, FileMode.Append, FileAccess.Write, FileShare.None);
                }
                else
                {
                    fs = new FileStream(nomFichier, FileMode.Open, FileAccess.Write, FileShare.None);
                  
                    fs.Seek(pos * longueurEnr, SeekOrigin.Begin);
                }

                BinaryWriter bw = new BinaryWriter(fs);

               
                string Nodi, Prenom, Nom, Date_Nais, Adresse, Ville, CodePostal, Tel, CodePermanent;
                char Sexe;
                float intra, final, tp1, tp2;
                //mskNodi.Text = Donner_Nodi();
                Nodi = Donner_Nodi();
                Nodi = mskNodi.Text.PadRight(5);
                Prenom = txtPrenom.Text.PadRight(20); 
                Nom = txtNom.Text.PadRight(20);
                Date_Nais = dtpDateNaissance.Text.PadRight(10);
                
                if (optFeminin.Checked == true)
                    Sexe = 'F';
                else
                    Sexe = 'M';
                Adresse = txtAdresse.Text.PadRight(30);
                Ville = txtVille.Text.PadRight(30);
                CodePostal = mskCodePostal.Text.ToUpper();
                Tel = mskTel.Text;
                CodePermanent = mskCodePermanent.Text.ToUpper().PadRight(12);
                intra = (float)numIntra.Value;
                final = (float)numFinal.Value;
                tp1 = (float)numTp1.Value;
                tp2 = (float)numTp2.Value;


                //écrit dans le ficihier dans le BON ORDRE 

                bw.Write(Nodi);             //  5 + 1  =  6 octets 
                bw.Write(Prenom);           // 20 + 1  = 21 octets - total  27
                bw.Write(Nom);              // 20 + 1 =  21 octets - total  48
                bw.Write(Date_Nais);        // 10 + 1 =  11 octets - total  59
                bw.Write(Sexe);             //            1 octets - total  60
                bw.Write(Adresse);          // 30 + 1 =  31 octets - total  91
                bw.Write(Ville);            // 30 + 1 =  31 octets - total 122
                bw.Write(CodePostal);       //  7 + 1 =   8 octets - total 129
                bw.Write(Tel);              // 14 + 1 =  15 octets - total 145
                bw.Write(CodePermanent);    // 12 + 1 =  13 octets - total 158
                bw.Write(intra);            //            4 octets - total 162
                bw.Write(final);            //            4 octets - total 166
                bw.Write(tp1);              //            4 octets - total 167
                bw.Write(tp2);              //            4 octets - total 174



                //Fermer le fichier
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //On vérifie puis décide ce qu'on fait avec l'erreur
            }
        }

        

        private void cmdPremier_Click_1(object sender, EventArgs e)
        {
            pos = 0;
            Recuperer_Etudiant(pos);
        }

        private void cmdPrecedent_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                Recuperer_Etudiant(pos);
            }
        }

        private void cmdSuivant_Click(object sender, EventArgs e)
        {
            if (pos < nbEtudiants - 1)
            {
                pos++;
                Recuperer_Etudiant(pos);
            }
        }

        private void cmdDernier_Click(object sender, EventArgs e)
        {
            pos = nbEtudiants - 1;
            Recuperer_Etudiant(pos);
        }



        private void cmdOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Valider formulaire
                if (Valider_Formulaire() == false)
                    return;

                // Réaliser l'action en cours
                if (actionCourante == Action.Inscription)
                {

                    Ajouter_ou_Modifier_Etudiant();

                    MessageBox.Show("Étudiant inscrit avec succès !");

                    nbEtudiants++;
                    pos = nbEtudiants - 1;
                    lblEtudiant.Text = "Etudiant" + (pos + 1) + "de" + nbEtudiants;
                }
                else
                {
                   
                    Ajouter_ou_Modifier_Etudiant();
                    MessageBox.Show("Étudiant modifié avec succès !");
                }

                //Gerer l'affichage apres l'action

                Barrer(cmdOk, cmdAnnuler, grpEtudiant, grpResultats);
                Debarrer(cmdInscrire, cmdModifier, cmdEnlever, grpNavigation);
                actionCourante = Action.Aucune;

                cmdAnnuler.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }


        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            

            Barrer(grpNavigation, cmdInscrire, cmdModifier, cmdEnlever);
            Debarrer(grpEtudiant, grpResultats, cmdOk, cmdAnnuler);


            actionCourante = Action.Modification;
            lblEtudiant.Text = "***Mode Modification***";

            

            txtPrenom.Focus();
        }

        private void cmdEnlever_Click(object sender, EventArgs e)
        {
            DialogResult rep; // pour récupérer la réponse de l'utilisateur

            rep = MessageBox.Show("Désirez-vous enlever cet étudiant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Valider la réponse 
            if (rep == DialogResult.Yes)
                Enlever_Etudiant(); 
        }

        private void Enlever_Etudiant()
        {
            string nomFichierTempo = "Etudiant.tmp"; // Nom du fichier temporaire

          

            FileStream fsSource = new FileStream(nomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fsSource);


            FileStream fsDestination = new FileStream(nomFichierTempo, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryWriter bw = new BinaryWriter(fsDestination);

            //Boucle de lecture sur le fichier source

            int cpt = 0;
            string nodi, prenom, nom, date_nais, tel, adresse, ville, codepostal, codepermanent;
            char sexe;
            float intra, final, tp1, tp2;
            
   
            for (int i = 0; i < nbEtudiants; i++)
            {
                nodi = br.ReadString();
                prenom = br.ReadString();
                nom = br.ReadString();
                date_nais = br.ReadString();
                sexe = br.ReadChar();
                adresse = br.ReadString();
                ville = br.ReadString();
                codepostal = br.ReadString();
                tel = br.ReadString();
                codepermanent = br.ReadString();
                intra = br.ReadSingle();
                final = br.ReadSingle();
                tp1 = br.ReadSingle();
                tp2 = br.ReadSingle();
                
                


                if (nodi != mskNodi.Text)
                {
        
                    cpt++; 
                    bw.Write(cpt);
                    bw.Write(nodi);
                    bw.Write(prenom);
                    bw.Write(nom);
                    bw.Write(date_nais);
                    bw.Write(sexe);
                    bw.Write(adresse);
                    bw.Write(ville);
                    bw.Write(codepostal);
                    bw.Write(tel);
                    bw.Write(codepermanent);
                    bw.Write(intra);
                    bw.Write(final);
                    bw.Write(tp1);
                    bw.Write(tp2);


                }
            }

            br.Close();
            fsSource.Close();
            bw.Close();
            fsDestination.Close();

            File.Delete(nomFichier);

            File.Move(nomFichierTempo, nomFichier);

            MessageBox.Show("Étudiant enleve avec succes !");
            nbEtudiants--; 

            if (nbEtudiants > 0)
            {
                pos = 0;
                Recuperer_Etudiant(pos);
            }
            else
            {
            
                pos = -1;
                Vider_Formulaire();
                Barrer(grpEtudiant, grpNavigation, grpResultats, cmdAnnuler, cmdDernier, cmdModifier, cmdEnlever, cmdOk);
                lblEtudiant.Text = "";
            }


        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            Donner_Nodi();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Donner_Nodi();
        }


    }
}
