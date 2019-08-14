using dao;
using metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class frmGestListeFiches : Form
    {
        FicheFrais ficheFrais;
        private int idFicheFraisSelectionne;
        public frmGestListeFiches()
        {
            InitializeComponent();


            /********************************************************************************
             * Mise en forme du datagridview (liste des fiches de frais)
             * ******************************************************************************/
            dgvFiches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFiches.MultiSelect = false;
            dgvFiches.RowHeadersVisible = false;
            dgvFiches.ColumnHeadersVisible = true;
            dgvFiches.AllowUserToAddRows = false;
            dgvFiches.ReadOnly = true;
            dgvFiches.ScrollBars = ScrollBars.Vertical;
            dgvFiches.ColumnCount = 4;
            dgvFiches.AllowUserToResizeRows = false;


            dgvFiches.Columns[0].Width = 80;
            dgvFiches.Columns[1].Width = 230;
            dgvFiches.Columns[2].Width = 170;
            dgvFiches.Columns[3].Width = 200;
            dgvFiches.Width = 680;

            dgvFiches.Columns[0].HeaderText = "Code";
            dgvFiches.Columns[1].HeaderText = "Visiteur";
            dgvFiches.Columns[2].HeaderText = "Mois";
            dgvFiches.Columns[3].HeaderText = "Etat";


            /********************************************************************************
           * Remplissage du datagridview (liste des fiches de frais) à partir de la classe LesFichesFrais
           * ******************************************************************************/


            remplirDgvFiches();
        }

        public void remplirDgvFiches()
        {


            try
            {
                dgvFiches.RowCount = LesFichesFrais.nbFichesFrais();

                int ligne = 0;
                foreach (FicheFrais uneFicheFrais in LesFichesFrais.obtenirLesFichesFrais())
                {
                    dgvFiches[0, ligne].Value = uneFicheFrais.getId();
                    dgvFiches[1, ligne].Value = uneFicheFrais.getNomPrenomVisiteur();
                    dgvFiches[2, ligne].Value = uneFicheFrais.getMoisAnnee();
                    dgvFiches[3, ligne].Value = uneFicheFrais.getEtatLong();
                    ligne++;
                }



                dgvFiches.Sort(dgvFiches.Columns[2], System.ComponentModel.ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Fiches de frais introuvales");
            }

        }

        //Récupère l'id de la fiche sélectionnée
        public int getIdFicheFraisSelectionne()
        {
            return idFicheFraisSelectionne;
        }
        private void frmGestListeFiches_Load(object sender, EventArgs e)
        {

        }

        //Permet de se déconnecter de la session en cours
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DbConnexion.SeDeconnecter();
            this.Close();
        }

        //Ouvre la fiche sélectionnée
        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (dgvFiches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vous devez sélectionner une fiche de frais.");
            }
            else
            {
                idFicheFraisSelectionne = (int)dgvFiches.CurrentRow.Cells[0].Value;
                frmGestFiche GestFiche = new frmGestFiche();
                GestFiche.Owner = this;
                GestFiche.ShowDialog();
            }

        }

        
    }
}
