using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunt2
{
    public partial class frmEmprunt : Form
    {
        public frmEmprunt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const byte NB_COL = 6;
            float taux;
            int nbItems = 20;
            int nbItems2 = 81;
            int duree;

            for (int i = 0; i < nbItems; i++)
            {
                taux = (float)((1 + i) * 0.5);
                cbxTaux.Items.Add(taux);
            }
            cbxTaux.SelectedIndex = 0;

            for (int i = 1; i < nbItems2; i++)
            {
                duree = (int)(i*3);
                cbxDuree.Items.Add(duree);
            }
            cbxDuree.SelectedIndex = 0;

            dgvTabAmort.ColumnCount = NB_COL;
            dgvTabAmort.Width = 140 * NB_COL + 6;




            dgvTabAmort.ColumnHeadersVisible = true;
            dgvTabAmort.Columns[0].HeaderText = "Date";
            dgvTabAmort.Columns[1].HeaderText = "Echéance";
            dgvTabAmort.Columns[2].HeaderText = "Amortissement";
            dgvTabAmort.Columns[3].HeaderText = "Intérêts";
            dgvTabAmort.Columns[4].HeaderText = "Assurance";
            dgvTabAmort.Columns[5].HeaderText = "Capital restant dû";



            dgvTabAmort.ReadOnly = true;
            dgvTabAmort.RowHeadersVisible = false;




            for (int i = 0; i < dgvTabAmort.ColumnCount; i++)
            {
                dgvTabAmort.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                dgvTabAmort.Columns[i].SortMode =
                DataGridViewColumnSortMode.NotSortable;
                dgvTabAmort.Columns[i].Width = 140;
                dgvTabAmort.Columns[i].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.BottomRight;
            }

        }

        private void tbxMontant_TextChanged(object sender, EventArgs e)
        {
            lblMontantMensualite.Text = null;
            dgvTabAmort.RowCount = 0;
        }


        private void cbxTaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMontantMensualite.Text = null;
            dgvTabAmort.RowCount = 0;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            int duree;
            float mensualite, montant, taux, interets, amortissement , restant = 0;
            Single assurance;
            try
            {
                montant = Convert.ToSingle(tbxMontant.Text);
                taux = (float)cbxTaux.SelectedItem / 100;
                duree = (int)cbxDuree.SelectedItem;
                mensualite = (montant * taux / 12) / (float)(1-Math.Pow(1 + taux / 12,-duree));
                lblMontantMensualite.Text = Convert.ToString(Math.Round(mensualite, 2));
                try
                {
                    if(tbxAssurances.Text == "")
                    {
                        assurance = 0;
                    }
                    else
                    {
                        assurance = Convert.ToSingle(tbxAssurances.Text);
                    }


                    
                    dgvTabAmort.RowCount = 0;

                    for (int i = 0; i < duree; i++)
                    {
                        dgvTabAmort.Rows.Add();
                        dgvTabAmort[4, i].Value = assurance.ToString("c");

                        dgvTabAmort[1, i].Value = mensualite + assurance;


                        dgvTabAmort[0, i].Value = dtpDate.Value.AddMonths(i).ToString("d");
                        //Pour le premier mois
                        if (i == 0)
                        {
                            interets = (montant * taux) / 12;
                            dgvTabAmort[3, i].Value = interets.ToString("c");

                            amortissement = (mensualite - interets);
                            dgvTabAmort[2, i].Value = amortissement.ToString("c");

                            restant = montant - amortissement;
                            dgvTabAmort[5, i].Value = restant.ToString("c");

                        }
                        //Calcul pour le mois suivant
                        else
                        {
                            interets = (restant * taux) / 12;
                            dgvTabAmort[3, i].Value = interets.ToString("c");

                            amortissement = (mensualite - interets);
                            dgvTabAmort[2, i].Value = amortissement.ToString("c");

                            restant = restant - amortissement;
                            dgvTabAmort[5, i].Value = restant.ToString("c");


                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Le montant de l'assurance doit être un nombre", "Erreur");
                    tbxAssurances.Text = null;
                    tbxAssurances.Focus();
                }


            }
            catch
            {
                MessageBox.Show("Le montant doit être un nombre", "Erreur");
                tbxMontant.Text = null;
                tbxMontant.Focus();
            }
          
           

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxDuree_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMontantMensualite.Text = null;
            dgvTabAmort.RowCount = 0;
        }


        private void btnEffacer_Click(object sender, EventArgs e)
        {
            tbxMontant.Text = null;
            tbxAssurances.Text = null;
            lblMontantMensualite.Text = null;
        }

        private void tbxAssurances_TextChanged(object sender, EventArgs e)
        {
            lblMontantMensualite.Text = null;
            dgvTabAmort.RowCount = 0;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            lblMontantMensualite.Text = null;
            dgvTabAmort.RowCount = 0;
        }
    }
}
