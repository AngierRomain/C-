using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envoi_Mail
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String ligne;
            /* Remplir la liste des contacts */
            try
            {
                lbxContacts2.Items.Clear(); //vider la combobox

                StreamReader SR = new StreamReader(@"..\\..\\..\\contacts.txt"); //Ouvrir le fichier en lecture
                while ((ligne = SR.ReadLine()) != null) //lire le fichier ligne par ligne
                {
                    lbxContacts2.Items.Add(ligne); //Ajouter une par une les lignes dans la comboBox
                }
                lbxContacts2.SelectedIndex = 0; //selection par défaut
            }
            catch
            {
                MessageBox.Show("Erreur: Impossible d'accéder au fichier \"contacts.txt\"");
            }
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {

        }
    }
}
