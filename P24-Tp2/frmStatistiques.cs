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
    public partial class frmStatistiques : Form
    {
        public frmStatistiques()
        {
            InitializeComponent();
        }

        private void frmStatistiques_Load(object sender, EventArgs e)
        {
            // ouvrir le fichier des etudiants
            FileStream fs = new FileStream(frmGestionEtudiants.nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fs);
            float TotalIntra = 0;
            float TotalFinal = 0;
            float TotalTp1 = 0;
            float TotalTp2 = 0;
            float Moy = 0;
            int NoEtu = 0;

            // Pour lire et ajouter des informations d'un étudiant

            string[] etudiant = new string[14]; //14 elements 


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




                TotalIntra += float.Parse(etudiant[10]);
                TotalFinal += float.Parse(etudiant[11]);
                TotalTp1+= float.Parse(etudiant[12]);
                TotalTp2+= float.Parse(etudiant[13]);
                NoEtu++;

            }
            Moy = ((TotalIntra * 0.40f + TotalFinal * 0.40f + TotalTp1 * 0.10f + TotalTp2 * 0.10f) / NoEtu);
            TotalIntra = TotalIntra / NoEtu;
            TotalFinal = TotalFinal / NoEtu;
            TotalTp1 = TotalTp1 / NoEtu;
            TotalTp2= TotalTp2/ NoEtu;
            

            txtMoyIntra.Text = TotalIntra.ToString();
            txtMoyFinal.Text = TotalFinal.ToString();
            txtMoyTp1.Text = TotalTp1.ToString();
            txtMoyTp2.Text = TotalTp2.ToString();
            txtMoyGroup.Text = Moy.ToString();
            txtNomEleves.Text = NoEtu.ToString();

            // Fermer les fichiers
            br.Close();
            fs.Close();
        }

        private void cmdSortir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
