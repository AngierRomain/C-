using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* TODO: Faire en sorte de choisir le destinataire le serveur et l'expediteur listbox censée remplir le champ destinataire */
 
namespace Envoi_Mail
{
    public partial class EnvoiMail : Form
    {
        private adresses adresses;

        public EnvoiMail()
        {
            InitializeComponent();
        }

        public EnvoiMail(adresses adresses)
        {
            this.adresses = adresses;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String ligne;
            pictureBox1.Image = Image.FromFile(@"..\\..\\..\\logo.png");

           /* Remplir la liste des serveurs smtp */
                try
                {
                    cbxServ.Items.Clear(); //vider la combobox

                    StreamReader SR = new StreamReader(@"..\\..\\..\\serveurs.txt"); //Ouvrir le fichier en lecture
                    while((ligne = SR.ReadLine()) != null) //lire le fichier ligne par ligne
                    {
                        cbxServ.Items.Add(ligne); //Ajouter une par une les lignes dans la comboBox
                    }
                    cbxServ.SelectedIndex = 13;
                }
                catch
                {
                    MessageBox.Show("Erreur: Impossible d'accéder au fichier \"serveurs.txt\"");
                }
            
        }
        


        /* Envoyer l'email */
        private void btnEnvoiMail_Click_1(object sender, EventArgs e)
        {
            SmtpClient clientSmtp = new SmtpClient("envoi.ac-bordeaux.fr"); //remplacer par celui du FAI
            MailMessage monMessage = new MailMessage();


            monMessage.Body = tbxMessage.Text;
            monMessage.Subject = tbxObjet.Text;

            //MailAddress destinataire = new MailAddress(cbxDest.Text);
            //monMessage.To.Add(destinataire);

            MailAddress expediteur = new MailAddress(tbxExp.Text);
            monMessage.From = expediteur;

            try
            {
                clientSmtp.Send(monMessage);
                MessageBox.Show("Le Mail a bien été envoyé");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec : " + ex.Message);
            }
        }

        private void btnAjouterPJ_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterDestinataire_Click(object sender, EventArgs e)
        {
            adresses contacts = new adresses();
            contacts.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
