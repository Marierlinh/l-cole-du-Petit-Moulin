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
    public partial class frmListe : Form
    {
        public frmListe()
        {
            InitializeComponent();
        }

        private void frmListe_Load(object sender, EventArgs e)
        {
            Afficher_Etudiants();
        }

        private void Afficher_Etudiants()
        {
            // Vider la liste 
            lvEtudiants.Clear();

            //Faire les en-têtes des colommes
            lvEtudiants.Columns.Add("Nodi", 70, HorizontalAlignment.Center);
            lvEtudiants.Columns.Add("Prenom", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Nom", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Date Naiss", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Sexe", 20, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Adresse", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Ville", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Code Postal", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Tel", 80, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Code Permanent", 80, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Intra", 50, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Final", 50, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("TP1", 50, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("TP2", 50, HorizontalAlignment.Left);
            lvEtudiants.Width = 1170;


        }

        private void lvEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdAfficherTous_Click(object sender, EventArgs e)
        {

            // Vider la liste 
            lvEtudiants.Clear();

            //Faire les en-têtes des colommes
            lvEtudiants.Columns.Add("Nodi", 70, HorizontalAlignment.Center);
            lvEtudiants.Columns.Add("Prenom", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Nom", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Date Naiss", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Sexe", 20, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Adresse", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Ville", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Code Postal", 120, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Tel", 80, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Code Permanent", 80, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Intra", 50, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("Final", 50, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("TP1", 50, HorizontalAlignment.Left);
            lvEtudiants.Columns.Add("TP2", 50, HorizontalAlignment.Left);
            lvEtudiants.Width = 1170;

            // Ovrir le fichier des étudiants
            FileStream fs = new FileStream(frmGestionEtudiants.nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fs);

            // Pour lire et ajouter les informations d'un étudiant
            string[] etudiant = new string[14];

            // Pour ajouter un item au ListView
            ListViewItem itm;

            for (; ; )
            {
                if (br.PeekChar() == -1) break;

                etudiant[0] = br.ReadString();
                etudiant[1] = br.ReadString().Trim();
                etudiant[2] = br.ReadString().Trim();
                etudiant[3] = br.ReadString();
                etudiant[4] = br.ReadChar().ToString();
                etudiant[5] = br.ReadString().Trim();
                etudiant[6] = br.ReadString().Trim();
                etudiant[7] = br.ReadString();
                etudiant[8] = br.ReadString();
                etudiant[9] = br.ReadString().Trim();
                etudiant[10] = br.ReadSingle().ToString();
                etudiant[11] = br.ReadSingle().ToString();
                etudiant[12] = br.ReadSingle().ToString();
                etudiant[13] = br.ReadSingle().ToString();

                // Ajouter l'Item au ListView
                itm = new ListViewItem(etudiant);
                lvEtudiants.Items.Add(itm);

            }


            // Fermer les fichiers
            br.Close();
            fs.Close();
        }

        private void cmdRechercher_Click(object sender, EventArgs e)
        {
            frmRechercher frm = new frmRechercher();
            frm.ShowDialog();

        }

        private void lslListedEtudiants_Click(object sender, EventArgs e)
        {

        }

        private void cmdEffacer_Click(object sender, EventArgs e)
        {
            // Vider la liste 
            lvEtudiants.Clear();
        }

        private void cmdStatisques_Click(object sender, EventArgs e)
        {

            frmStatistiques frm = new frmStatistiques();
            frm.ShowDialog();
        }


        private void lvMoyenne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
