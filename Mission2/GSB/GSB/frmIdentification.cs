using dao;
using metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class frmIdentification : Form
    {
        private int idUtilisateur;

        public frmIdentification()
        {
            InitializeComponent();
        }
        public int getIdUtilisateur()
        {
            return idUtilisateur;
        }

        private void btEntrer_Click(object sender, EventArgs e)
        {

            try
            {
                String serveur = tbxServeur.Text;
                int port = Convert.ToInt32(tbxPort.Text);
                if (DbConnexion.etatConnexion() == ConnectionState.Closed)
                {
                    DbConnexion.connexionBase(serveur, port);
                }

                String[] idStatut = UtilisateurDAO.authentificationUtilisateur(tbxLogin.Text, tbxMdP.Text);
                
                if(idStatut[1] == "C")
                {
                    List<Utilisateur> Utilisateurs = UtilisateurDAO.chargerUtilisateurs();
                    LesUtilisateurs.remplirListeUtilisateurs(Utilisateurs);

                    List<FicheFrais> fichesFrais = FicheFraisDAO.chargerFichesFrais();
                    LesFichesFrais.remplirLesFichesFrais(fichesFrais);

                    List<TypeFrais> typesFrais = TypeFraisDAO.chargerTypesFrais();
                    LesTypesFrais.remplirLesTypesFrais(typesFrais);


                    frmComptaListeFiches comptaListeFiches = new frmComptaListeFiches();
                    comptaListeFiches.ShowDialog();
                }
                else if(idStatut[1] == "V")
                {

                    String unId = idStatut[0];
                    List<Utilisateur> Utilisateurs = UtilisateurDAO.chargerUtilisateurs();
                    LesUtilisateurs.remplirListeUtilisateurs(Utilisateurs);

                    List<FicheFrais> fichesFrais = FicheFraisDAO.chargerFichesFraisUnUtilisateur(unId);
                    LesFichesFrais.remplirLesFichesFrais(fichesFrais);

                    List<TypeFrais> typesFrais = TypeFraisDAO.chargerTypesFrais();
                    LesTypesFrais.remplirLesTypesFrais(typesFrais);

                    frmComptaListeFiches comptaListeFiches = new frmComptaListeFiches();
                    comptaListeFiches.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe inconnu !!");

                }
                tbxLogin.Text = "";
                tbxMdP.Text = "";
                List<Utilisateur> idUtilisateur = UtilisateurDAO.chargerUtilisateurs();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (DbConnexion.etatConnexion() == ConnectionState.Open)
            {
                DbConnexion.SeDeconnecter();   
            }
            this.Close();
        }

        private void PN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmIdentification_Load(object sender, EventArgs e)
        {

        }
    }
}
