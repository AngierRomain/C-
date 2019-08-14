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
using System.Data.SqlClient;


namespace GSB
{
    public partial class CreationFicheFrais : Form
    {
        FicheFrais ficheFrais;
        TypeFrais typeFrais;
        public CreationFicheFrais()
        {
            

            InitializeComponent();

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

            // ****************************************************************
            //Charger les type de frais
            // ****************************************************************

            //List<TypeFrais> typeDeFrais = TypeFraisDAO.chargerTypesFrais(typeFrais.getLibelle());
            //LesTypesFrais.remplirLesTypesFrais(typeDeFrais);

            // ****************************************************************
            //remplir combo box de type de frais 
            // ****************************************************************

            //string unTypeFrais = Convert.ToString(typeDeFrais);
            //cbxTypeDeFrais.Items.Add(typeDeFrais);


            // ****************************************************************
            // Information à propos de l'utilisateur
            // Charger les info
            // ****************************************************************


            //List<Utilisateur> unVisiteur = LesUtilisateurs.remplirListeUtilisateurs();
            //LesUtilisateurs.remplirListeUtilisateurs(unVisiteur);

            //lblNom.Text = unVisiteur.();
            //lblPrenom.Text = unVisiteur.();


            // ****************************************************************
            // Date cbx
            // ****************************************************************

             CultureInfo culture = new CultureInfo("fr-Fr");
            string mDate = culture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            cbxMoisAnnee.Items.Add(mDate);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNouvelleFicheFrais_Load(object sender, EventArgs e)
        {
         
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }


        // ****************************************************************
        // Paramètre du bouton validé 
        // ****************************************************************
        private void btnValider_Click(object sender, EventArgs e)
        {
            dgvLignesFiches.RowCount = LesLignesFrais.nbLignesFrais();
            
            Decimal? totalDeclare;
            int ligne = 0;

            // ****************************************************************
            // Affichage des information suite à l'action du click 
            // ****************************************************************
            foreach (LigneFrais uneLigneFrais in LesLignesFrais.obtenirLesLignesFrais())
            {
                dgvLignesFiches[0, ligne].Value = cbxTypeDeFrais.SelectedItem;
                dgvLignesFiches[1, ligne].Value = uneLigneFrais.getTypeFrais().getMontant().ToString("C");
                dgvLignesFiches[2, ligne].Value = txtQuantite.Text;
                totalDeclare = uneLigneFrais.getQuantiteDeclaree() * uneLigneFrais.getTypeFrais().getMontant();
                dgvLignesFiches[3, ligne].Value = (totalDeclare != null ? totalDeclare.Value.ToString("C") : "");

            }
        }

        // ****************************************************************
        // Bouton quitter
        // ****************************************************************
        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
