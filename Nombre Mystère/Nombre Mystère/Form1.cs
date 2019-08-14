using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Nombre_Mystère
{
    public partial class FrmNombre : Form
    {
        Random randomizer = new Random();
        // Le nombre mystère
        int randomNumber;

        // Le nombre d'essais restants ( Avec 5000 chances le jeu est plus facile monsieur :P )
        int essaysLeft = 7;
        
        public FrmNombre()
        {
            InitializeComponent();
            //Génération du nombre mystère dans l'intervalle [O..101[
            randomNumber = randomizer.Next(0, 101);

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            //Fermer le programme
            this.Close();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            //On verifie qu'il reste au moins une chance
            if (essaysLeft <= 0)
            {
                MessageBox.Show("Vous avez perdu ! Pourquoi ne pas reessayer ?");
                btnVerif.Enabled = false;
                // On stoppe la fonction
                return;
            }

            //Le nombre saisi par l'utilisateur
            int nbreChoisi;

            //On essaye de convertir la saisie utilisateur en un entier.
            bool entreeValide = int.TryParse(tbxNombre.Text, out nbreChoisi);

            // Si l'entrée utilisateur est invalide
            if (!entreeValide)
            {
                MessageBox.Show("Merci de bien vouloir entrer un nombre entier.");
                return;
            }

            // Si l'entrée utilisateur est valide

            if (nbreChoisi == randomNumber)
                MessageBox.Show("Bien joué tu as trouvé le nombre mystère en seulement " + (7-essaysLeft)  + " coups ! :) " );
            else if (nbreChoisi > randomNumber)
                MessageBox.Show("C'est plus petit ! :) Il te reste " + essaysLeft + " essais restants !");
            else
                MessageBox.Show("C'est plus grand ! :) Il te reste " + essaysLeft + " essais restants !");

            // On réduit de 1 le nombre d'essais restants
            essaysLeft--;
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            //On remet les valeurs par défaut
            essaysLeft = 7;
            randomNumber = randomizer.Next(0, 101);
            btnVerif.Enabled = true;
        }
    }
}
