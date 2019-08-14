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

        public frmIdentification()
        {
            InitializeComponent();
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
                
                //Si l'utilisateur est "Comptable"
                if(idStatut[9] == "CMP")
                {
                    List<Utilisateur> utilisateurs = UtilisateurDAO.chargerUtilisateurs();
                    LesUtilisateurs.remplirListeUtilisateurs(utilisateurs);

                    List<FicheFrais> fichesFrais = FicheFraisDAO.chargerFichesFrais();
                    LesFichesFrais.remplirLesFichesFrais(fichesFrais);

                    List<TypeFrais> typesFrais = TypeFraisDAO.chargerTypesFrais();
                    LesTypesFrais.remplirLesTypesFrais(typesFrais);


                    frmComptaListeFiches comptaListeFiches = new frmComptaListeFiches();
                    comptaListeFiches.ShowDialog();
                }
                
                //Si l'utilisateur est "Gestionnaire"
                else if (idStatut[9] == "GST")
                {
                    List<Utilisateur> utilisateurs = UtilisateurDAO.chargerUtilisateurs();
                    LesUtilisateurs.remplirListeUtilisateurs(utilisateurs);

                    List<FicheFrais> fichesFrais = FicheFraisDAO.chargerFichesFrais();
                    LesFichesFrais.remplirLesFichesFrais(fichesFrais);

                    List<TypeFrais> typesFrais = TypeFraisDAO.chargerTypesFrais();
                    LesTypesFrais.remplirLesTypesFrais(typesFrais);


                    frmGestListeFiches gestListeFiches = new frmGestListeFiches();
                    gestListeFiches.ShowDialog();
                }

                //Si l'utilisateur est "Visiteur"
                else if (idStatut[9] == "VIS")
                {
                    List<Utilisateur> utilisateurs = UtilisateurDAO.chargerUtilisateurs();
                    LesUtilisateurs.remplirListeUtilisateurs(utilisateurs);

                    List<FicheFrais> fichesFrais = FicheFraisDAO.chargerFichesFrais();
                    LesFichesFrais.remplirLesFichesFrais(fichesFrais);

                    List<TypeFrais> typesFrais = TypeFraisDAO.chargerTypesFrais();
                    LesTypesFrais.remplirLesTypesFrais(typesFrais);


                    //frmVisiteurListeFiches gestListeFiches = new frmVisiteurListeFiches();
                    //gestListeFiches.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe inconnu !!");

                }
                tbxLogin.Text = "";
                tbxMdP.Text = "";



            }
            catch
            {
                MessageBox.Show("Connexion impossible");
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
    }
}
