using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //gère les acces aux fichiers

namespace Motus
{
    public partial class Motus : Form
    {
        //Déclaration des variables
        byte nbLignes = 7;
        byte nbColonnes;
        String motCache;
        byte numLigne = 0;
        public Motus()
        {
            InitializeComponent();
        }
       
        private void Motus_Load(object sender, EventArgs e)
        {

            

            //On désactive le tableau le bouton Annuler et Valider
            dgvMotus.Enabled = false;
            btnAnnuler.Enabled = false;
            btnValider.Enabled = false;
            tbxMot.Enabled = false;

            

            //Définition du nombre de Lignes
            dgvMotus.RowCount = nbLignes;
            dgvMotus.Height = nbLignes * 40+3;

            for(int i = 0; i < nbLignes; i++)
            {
                dgvMotus.Rows[i].Height = 40;
            }
            dgvMotus.RowHeadersVisible = false;
            dgvMotus.ColumnHeadersVisible = false;
          
            //forcer la saisie en majuscule
            tbxMot.CharacterCasing = CharacterCasing.Upper;
            
            //Valeurs de la combobox où on peut choisir le nombre de lettres du mot
            cbxNbLettres.Items.Add(8);
            cbxNbLettres.Items.Add(9);

            //Afficher par défaut 8 dans la combobox
            cbxNbLettres.SelectedIndex = 0;

        }

        private void cbxNbLettres_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Définir le nombre de colonnes

            nbColonnes = Convert.ToByte(cbxNbLettres.SelectedItem);

            dgvMotus.ColumnCount = nbColonnes;
            dgvMotus.Width = nbColonnes * 40 + 3;
            for(int i =0; i<nbColonnes; i++)
            {
                dgvMotus.Columns[i].Width = 40;
            }
            //limiter la taille du mot
            tbxMot.MaxLength = Convert.ToByte(cbxNbLettres.Text);
            dgvMotus.Rows[0].Selected = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Fermer le programme
            this.Close();
        }

        private void tbxMot_KeyDown(object sender, KeyEventArgs e)
        {
            //Autoriser que certaines touches du clavier
            if (((int)e.KeyCode >= 1 && (int)e.KeyCode <= 7)
    || ((int)e.KeyCode >= 9 && (int)e.KeyCode <= 36)
    || ((int)e.KeyCode >= 40 && (int)e.KeyCode <= 45)
    || ((int)e.KeyCode >= 47 && (int)e.KeyCode <= 64)
    || ((int)e.KeyCode == 38)
    || ((int)e.KeyCode > 90)
    )
            {
                e.SuppressKeyPress = true;
            }

        }

        private void tbxMot_TextChanged(object sender, EventArgs e)
        {

            if (tbxMot.Text.Length == Convert.ToByte(cbxNbLettres.SelectedItem)){
                btnValider.Enabled = true;
            }
            else {
                btnValider.Enabled = false;
            }



            

            
         

        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            dgvMotus.Rows[0].Selected = false;
            btnAnnuler.Enabled = true;
            tbxMot.Enabled = true;
            cbxNbLettres.Enabled = false;
            btnJouer.Enabled = false;
            //Choisir un mot dans le fichier
            string path = "..\\..\\..\\";
            string nomFichier = "mots" + cbxNbLettres.SelectedItem + ".txt";
            path = path + nomFichier;

            int nbMots = File.ReadAllLines(path).Count();

            string[] lesLignes = File.ReadAllLines(path);
            Random tirage = new Random();
            int positionMot = tirage.Next(0, nbMots);

            motCache = lesLignes[positionMot];

          
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            String motPropse;
            byte i, j = 0;
            Boolean trouve = false;
            Boolean[] tabDejaTraites = new Boolean[Convert.ToInt32(cbxNbLettres.SelectedItem.ToString())];


            motPropse = tbxMot.Text;
            tbxMot.Text = null;
            tbxMot.Focus();

            for (i = 0; i < Convert.ToInt32(cbxNbLettres.SelectedItem.ToString()); i++)
            {
                tabDejaTraites[i] = false;
            }

            if (numLigne < 7 && motCache != motPropse)
            {
                /***********************************************************
                Recherche des lettres bien placées
                ***********************************************************/
                for (i = 0; i < Convert.ToInt32(cbxNbLettres.SelectedItem); i++)
                {
                    dgvMotus[i, numLigne].Value = motPropse[i];
                    if (motCache[i] == motPropse[i])
                    {
                        dgvMotus[i, numLigne].Style.BackColor = Color.Chocolate;
                        tabDejaTraites[i] = true;
                    }

                }

                /************************************************************
               *Recherche des lettres mal placées
               **************************************************************/

                for (i = 0; i < Convert.ToInt32(cbxNbLettres.SelectedItem); i++)
                {
                    j = 0;
                    trouve = false;
                    if (motCache[i] != motPropse[i])
                    {
                        while (j < Convert.ToInt32(cbxNbLettres.SelectedItem) && trouve == false)
                        {
                            if (motPropse[i] == motCache[j] && tabDejaTraites[j] == false)
                            {
                                dgvMotus[i, numLigne].Style.BackColor = Color.Yellow;
                                tabDejaTraites[j] = true;
                                trouve = true;
                            }
                            j++;
                        }
                    }

                }
                numLigne++;
            }

            if (motCache == motPropse)
            {
                for (i = 0; i < Convert.ToInt32(cbxNbLettres.SelectedItem); i++)
                {
                    dgvMotus[i, numLigne].Value = motPropse[i];
                    if (motCache[i] == motPropse[i])
                    {
                        dgvMotus[i, numLigne].Style.BackColor = Color.Chocolate;
                    }
                }
                tbxMot.Enabled = false;
                MessageBox.Show("Vous avez gagné !");
            }





            else if (numLigne == 7)
            {
                tbxMot.Enabled = false;
                MessageBox.Show("Vous avez perdu !  " + motCache);

            }


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            numLigne = 0;
            dgvMotus.Rows[0].Selected = false;
            cbxNbLettres.Enabled = true;
            motCache = null;
            tbxMot.Enabled = false;
            btnJouer.Enabled = true;
            btnAnnuler.Enabled = false;
            

            for(int i = 0; i < nbLignes; i++)
            {
                for(int j = 0; j < Convert.ToByte(cbxNbLettres.SelectedItem); j++)
                {
                    dgvMotus[j, i].Value = null;
                    dgvMotus[j, i].Style.BackColor = Color.White;
                }
            }
        }
    }
}

