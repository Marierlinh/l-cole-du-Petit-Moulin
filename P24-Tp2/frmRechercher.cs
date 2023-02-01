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
    public partial class frmRechercher : Form
    {
        private int nbEtudiants;
        private int nbTrouveEtudiant;
        private int[] EtuPosTrouve;
        private int pos_e = -1;
        

        public frmRechercher()
        {
            InitializeComponent();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            // Lancer la recherche 
            if (txtRechercher.Text.Trim() != "")
            {
                Chercher_Etudiant();
                lblEtudiantTrouver.Text = (nbTrouveEtudiant + " Étudiants trouvés");
                grpRechercherEtudiant.Text = " Etudiant" + pos_e;
                grpRechercherEtudiant.Visible = true;
            }
                
            else
            {
                // Il n'y a plus rien à chercher
                lblNom.Text = "";
                grpRechercherEtudiant.Visible = false;
                cmdProchain.Enabled = false;
                cmdChoisir.Enabled = false;
            }
              
        }
        /// <summary>
        /// Procédure qui recherche un étudiant 
        /// </summary>
        private void Chercher_Etudiant()
        {
            // Liste des éléments à lire pour chaque étudiant
            string Nodi, Prenom, Nom, Date_Nais, Adresse, Ville, CodePostal, Tel, CodePermanente;
            char Sexe;
            float Intra, Final, Tp1, Tp2;
            int i, pos_e = -1;

            try
            {
                // Ouvrir Fichier
                FileStream fs = new FileStream(frmGestionEtudiants.nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                if(nbEtudiants > 0)
                {
                    Array.Clear(EtuPosTrouve, 0, EtuPosTrouve.Length);
                    nbTrouveEtudiant = 0;
                    for(; ;)
                    {
                        if (br.PeekChar() == -1) break;
                        pos_e++;  // Position de l'étudiant dans le fichier
                        Nodi = br.ReadString().Trim();
                        Prenom = br.ReadString().Trim();
                        Nom = br.ReadString().Trim();
                        Date_Nais = br.ReadString().Trim();
                        Sexe = br.ReadChar();
                        Adresse = br.ReadString().Trim();
                        Ville = br.ReadString().Trim();
                        CodePostal = br.ReadString().Trim();
                        Tel = br.ReadString().Trim();
                        CodePermanente = br.ReadString().Trim();
                        Intra = br.ReadSingle();
                        Final = br.ReadSingle();
                        Tp1 = br.ReadSingle();
                        Tp2 = br.ReadSingle();

                        // Vérifier l'option de recherche sélectionnée
                        if (optNom.Checked == true)
                        {
                            if (txtRechercher.TextLength <= Nom.Length)
                            {
                                for (i = 0; i <= Nom.Length - txtRechercher.TextLength; i++)
                                {
                                    //Recherche par nom
                                    if (Nom.ToUpper().Substring(i, txtRechercher.TextLength) == txtRechercher.Text.ToUpper())
                                    {
                                        EtuPosTrouve[nbTrouveEtudiant] = pos_e;
                                        nbTrouveEtudiant++;
                                        break;           
                                    }

                                }
                            }
                        }
                        else if (optPrenom.Checked == true)
                        {
                            if (txtRechercher.TextLength <= Prenom.Length)
                            {
                                for (i = 0; i <= Prenom.Length - txtRechercher.TextLength; i++)
                                {
                                    //Recherche par nom
                                    if (Prenom.ToUpper().Substring(i, txtRechercher.TextLength) == txtRechercher.Text.ToUpper())
                                    {
                                        EtuPosTrouve[nbTrouveEtudiant] = pos_e;
                                        nbTrouveEtudiant++;
                                        break;
                                    }

                                }
                            }
                        }
                        else
                             if (txtRechercher.TextLength <= CodePermanente.Length)
                        {
                            for (i = 0; i <= CodePermanente.Length - txtRechercher.TextLength; i++)
                            {
                                //Recherche par nom
                                if (CodePermanente.ToUpper().Substring(i, txtRechercher.TextLength) == txtRechercher.Text.ToUpper())
                                {
                                    EtuPosTrouve[nbTrouveEtudiant] = pos_e;
                                    nbTrouveEtudiant++;
                                    break;
                                }

                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a aucun étudiant à rechercher !", " Recherche étudiant");
                }
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

        }

        /// <summary>
        /// Orvertue du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRechercher_Load(object sender, EventArgs e)
        {
   
            

             try
             {

                // Vérifier s'il y a des enregistrements dans le fichier
                FileStream fs = new FileStream(frmGestionEtudiants.nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Déterminer le nombre d'étudiants
                nbEtudiants = (int)fs.Length / frmGestionEtudiants.longueurEnr;

                //Fermer le fichier
                br.Close();
                fs.Close();

                EtuPosTrouve = new int[nbEtudiants]; // Maximum d'étudiants que l'on peut trouver
             }
             catch (Exception ex)
             {
                    MessageBox.Show(ex.Message, "Ouverture frmRechercher !");
             }
            
        }

        private void cmdChoisir_Click(object sender, EventArgs e)
        {

        }

        private void cmdProchain_Click(object sender, EventArgs e)
        {

        }
    }
}
