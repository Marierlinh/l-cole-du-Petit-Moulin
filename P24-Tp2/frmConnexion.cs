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
    public partial class frmConnexion : Form
    {
        string utilisateur = "Admin";
        string motpass = "Pa$$w0rd";


        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdConnexion_Click(object sender, EventArgs e)
        {
            try
            {

           
            if (txtUtilisateur.Text != utilisateur || txtMotpass.Text != motpass)
            {
                if (txtUtilisateur.Text != utilisateur)
                {
                    MessageBox.Show("Utilisateur Incorrect");
                    txtUtilisateur.Clear();
                    txtUtilisateur.Focus();
                    return;
                }
                if (txtMotpass.Text != motpass)
                {
                    MessageBox.Show("Mot de pass Incorrect");
                    txtMotpass.Clear();
                    txtMotpass.Focus();
                    return;
                }
            }
            else
            {
                txtUtilisateur.Clear();
                txtMotpass.Clear();
                FrmMdi form = new FrmMdi();
                    form.Show();


                    this.Hide();
                }
            }

           

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                
                
            }
           
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtMotpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ckbmontrerMotPasse_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbmontrerMotPasse.Checked == true)
     
                txtMotpass.UseSystemPasswordChar = false;
      
            else
                txtMotpass.UseSystemPasswordChar = false;

            if (ckbmontrerMotPasse.Checked == false)

                txtMotpass.UseSystemPasswordChar = true;

        }







    }
}
