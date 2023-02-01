using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P24_Tp2
{
    public partial class FrmMdi : Form
    {
        
        public FrmMdi()
        {
            InitializeComponent();
          
        }
 
       
        private void mnuGestionEtudiants_Click(object sender, EventArgs e)
        {
            // Verifier si la fenêtre est déjà ouverte
            for(int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == "Gestion Étudiants")
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }

            frmGestionEtudiants frm = new frmGestionEtudiants();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuApropos_Click(object sender, EventArgs e)
        {
            //Afficher le formulaire À porpos de manière Modale

            frmApropos frm = new frmApropos();
            frm.ShowDialog();
        }

        private void mnuListeEtudiant_Click(object sender, EventArgs e)
        {
            // Verifier si la fenêtre est déjà ouverte
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == "Liste d'étudiants")
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            frmListe frm = new frmListe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMdi_Load(object sender, EventArgs e)
        {

        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuUtilisateur_Click(object sender, EventArgs e)
        {
          
            frmConnexion frm = new frmConnexion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            DialogResult rep;

            //Demander une confirmation
            rep = MessageBox.Show("Desirez-vous quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
                Application.Exit();
        }
    }
}
