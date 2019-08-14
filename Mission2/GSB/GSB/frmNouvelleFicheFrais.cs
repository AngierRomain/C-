using dao;
using metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class frmNouvelleFicheFrais : Form
    {
        FicheFrais ficheFrais;
        TypeFrais typeFrais;
        public frmNouvelleFicheFrais()
        {
            InitializeComponent();

            // ****************************************************************
            // Désactiver de base les boutons: Valider et quantité ainsi que le combo box Type de Frais
            // ****************************************************************
            btnValider.Enabled = false;
            cbxTypeDeFrais.Enabled = false;
            txtQuantite.Enabled = false;
            /*************************************************************************
            * Mise en place du datadridview - lignes de la fiche de frais sélectionnée
            *************************************************************************/
            dgvLignesFiches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLignesFiches.MultiSelect = false;
            dgvLignesFiches.RowHeadersVisible = false;
            dgvLignesFiches.ColumnHeadersVisible = true;
            dgvLignesFiches.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLignesFiches.ReadOnly = true;
            dgvLignesFiches.AllowUserToAddRows = false;
            dgvLignesFiches.ScrollBars = ScrollBars.Vertical;
            dgvLignesFiches.AllowUserToResizeRows = false;

            dgvLignesFiches.ColumnCount = 6;

            dgvLignesFiches.Columns[0].Width = 150;
            dgvLignesFiches.Columns[1].Width = 80;
            dgvLignesFiches.Columns[2].Width = 80;
            dgvLignesFiches.Columns[3].Width = 130;


            dgvLignesFiches.Width = 650;

            dgvLignesFiches.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLignesFiches.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLignesFiches.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            dgvLignesFiches.Columns[0].HeaderText = "Forfait";
            dgvLignesFiches.Columns[1].HeaderText = "Tarif";
            dgvLignesFiches.Columns[2].HeaderText = "Quantité Déclarée";
            dgvLignesFiches.Columns[3].HeaderText = "Total Déclaré";

            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNouvelleFicheFrais_Load(object sender, EventArgs e)
        {
            /**********************************************************************************
             * Récupérer de l'id des type de frais
             * *******************************************************************************/

            int idTypeFrais = (this.Owner as frmComptaListeFiches).getIdFicheFraisSelectionne();
            /**********************************************************************************
             * Affichage du type de faris
             * *******************************************************************************/
            


            /**********************************************************************************
             * Récupération de l'id de la fiche sélectionnée 
             * *******************************************************************************/
            int idFicheFrais = (this.Owner as frmComptaListeFiches).getIdFicheFraisSelectionne();


            /**********************************************************************************
            * Recherche de l'objet fichefrais et de l'objet visiteur sélectionnés
            * *******************************************************************************/
            ficheFrais = LesFichesFrais.chercherFicheFrais(idFicheFrais);
            Utilisateur visiteur = LesUtilisateurs.chercherUtilisateur(ficheFrais.getUtilisateur().getId());


            /**********************************************************************************
            * Chargement des lignes concernant la fiche de frais et du visiteur sélectionnée
            * *******************************************************************************/
            List<LigneFrais> lignesFrais = LignesFraisDAO.chargerLignesFrais(ficheFrais.getId());
            LesLignesFrais.remplirLesLignesFrais(lignesFrais);

            ficheFrais.setLignesFrais(LesLignesFrais.obtenirLesLignesFrais());




            /*************************************************************************
            * Affichage des informations dans le formulaire.
            *************************************************************************/
            CultureInfo culture = new CultureInfo("fr-Fr");

            

            
            lblNom.Text = visiteur.getNom();
            lblPrenom.Text = visiteur.getPrenom();
            
            lblDateCloture.Text = "";
            if (ficheFrais.getDateCloture() != null)
            {
                lblDateCloture.Text = ficheFrais.getDateCloture().Value.ToString("dd-MM-yyyy");
            }

            lblEtat.Text = ficheFrais.getEtatLong();


            Decimal? montantDeclare = ficheFrais.getMontantDeclare();

            lblMontant.Text = (montantDeclare != null ? montantDeclare.Value.ToString("C") : "");
            //DataGridView1.Rows(indiceLigne).Selected = True

            /*************************************************************************
            * Remplissage du datagridview
            *************************************************************************/
            dgvLignesFiches.RowCount = LesLignesFrais.nbLignesFrais();

            Decimal? totalDeclare;
            int ligne = 0;
            foreach (LigneFrais uneLigneFrais in LesLignesFrais.obtenirLesLignesFrais())
            {
                // ****************************************************************
                // Affichage des informations dans le DGV
                // ****************************************************************
                dgvLignesFiches[0, ligne].Value = uneLigneFrais.getTypeFrais().getLibelle();
                dgvLignesFiches[1, ligne].Value = uneLigneFrais.getTypeFrais().getMontant().ToString("C");
                dgvLignesFiches[2, ligne].Value = uneLigneFrais.getQuantiteDeclaree();
                totalDeclare = uneLigneFrais.getQuantiteDeclaree() * uneLigneFrais.getTypeFrais().getMontant();
                dgvLignesFiches[3, ligne].Value = (totalDeclare != null ? totalDeclare.Value.ToString("C") : "");
                cbxTypeDeFrais.Items.Add(uneLigneFrais.getTypeFrais().getLibelle());


                ligne++;
            }

            lblMontant.Text = (montantDeclare != null ? montantDeclare.Value.ToString("C") : "");



        }

        // ****************************************************************
        // Bouton modifier
        // ****************************************************************
        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnValider.Enabled = true;
            cbxTypeDeFrais.Enabled = true;
            txtQuantite.Enabled = true;
        }

        // ****************************************************************
        // Bouton supprimé
        // ****************************************************************
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            int indexLigne = dgvLignesFiches.Rows.Add();
            //dgvLignesFiches.Rows[indexLigne][0].Value = cbxTypeDeFrais.SelectedItem;

            // suppression
            dgvLignesFiches.Rows.RemoveAt(indexLigne);

        }
    }
}
