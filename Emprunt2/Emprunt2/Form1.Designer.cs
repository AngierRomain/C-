namespace Emprunt2
{
    partial class frmEmprunt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblTaux = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblMensualite = new System.Windows.Forms.Label();
            this.lblMontantMensualite = new System.Windows.Forms.Label();
            this.tbxMontant = new System.Windows.Forms.TextBox();
            this.cbxTaux = new System.Windows.Forms.ComboBox();
            this.cbxDuree = new System.Windows.Forms.ComboBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblAssurance = new System.Windows.Forms.Label();
            this.tbxAssurances = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.dgvTabAmort = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabAmort)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Blackadder ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Red;
            this.lblTitre.Location = new System.Drawing.Point(264, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(359, 41);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Remboursement d\'un emprunt";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(17, 82);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 1;
            this.lblMontant.Text = "Montant";
            // 
            // lblTaux
            // 
            this.lblTaux.AutoSize = true;
            this.lblTaux.Location = new System.Drawing.Point(17, 113);
            this.lblTaux.Name = "lblTaux";
            this.lblTaux.Size = new System.Drawing.Size(31, 13);
            this.lblTaux.TabIndex = 2;
            this.lblTaux.Text = "Taux";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(17, 148);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(36, 13);
            this.lblDuree.TabIndex = 3;
            this.lblDuree.Text = "Durée";
            // 
            // lblMensualite
            // 
            this.lblMensualite.AutoSize = true;
            this.lblMensualite.Location = new System.Drawing.Point(17, 271);
            this.lblMensualite.Name = "lblMensualite";
            this.lblMensualite.Size = new System.Drawing.Size(58, 13);
            this.lblMensualite.TabIndex = 4;
            this.lblMensualite.Text = "Mensualité";
            // 
            // lblMontantMensualite
            // 
            this.lblMontantMensualite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMontantMensualite.Location = new System.Drawing.Point(98, 271);
            this.lblMontantMensualite.Name = "lblMontantMensualite";
            this.lblMontantMensualite.Size = new System.Drawing.Size(121, 23);
            this.lblMontantMensualite.TabIndex = 5;
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(98, 75);
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(121, 20);
            this.tbxMontant.TabIndex = 6;
            this.tbxMontant.TextChanged += new System.EventHandler(this.tbxMontant_TextChanged);
            // 
            // cbxTaux
            // 
            this.cbxTaux.FormattingEnabled = true;
            this.cbxTaux.Location = new System.Drawing.Point(98, 113);
            this.cbxTaux.Name = "cbxTaux";
            this.cbxTaux.Size = new System.Drawing.Size(121, 21);
            this.cbxTaux.TabIndex = 7;
            this.cbxTaux.SelectedIndexChanged += new System.EventHandler(this.cbxTaux_SelectedIndexChanged);
            // 
            // cbxDuree
            // 
            this.cbxDuree.FormattingEnabled = true;
            this.cbxDuree.Location = new System.Drawing.Point(98, 148);
            this.cbxDuree.Name = "cbxDuree";
            this.cbxDuree.Size = new System.Drawing.Size(121, 21);
            this.cbxDuree.TabIndex = 8;
            this.cbxDuree.SelectedIndexChanged += new System.EventHandler(this.cbxDuree_SelectedIndexChanged);
            // 
            // btnCalculer
            // 
            this.btnCalculer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCalculer.Location = new System.Drawing.Point(271, 261);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(86, 33);
            this.btnCalculer.TabIndex = 9;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = false;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnQuitter.Location = new System.Drawing.Point(498, 262);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(78, 33);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblAssurance
            // 
            this.lblAssurance.AutoSize = true;
            this.lblAssurance.Location = new System.Drawing.Point(17, 191);
            this.lblAssurance.Name = "lblAssurance";
            this.lblAssurance.Size = new System.Drawing.Size(57, 13);
            this.lblAssurance.TabIndex = 11;
            this.lblAssurance.Text = "Assurance";
            // 
            // tbxAssurances
            // 
            this.tbxAssurances.Location = new System.Drawing.Point(98, 191);
            this.tbxAssurances.Name = "tbxAssurances";
            this.tbxAssurances.Size = new System.Drawing.Size(121, 20);
            this.tbxAssurances.TabIndex = 12;
            this.tbxAssurances.TextChanged += new System.EventHandler(this.tbxAssurances_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(98, 229);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(167, 20);
            this.dtpDate.TabIndex = 13;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date de début";
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.Red;
            this.btnEffacer.Location = new System.Drawing.Point(391, 262);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(80, 32);
            this.btnEffacer.TabIndex = 15;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // dgvTabAmort
            // 
            this.dgvTabAmort.AllowUserToAddRows = false;
            this.dgvTabAmort.AllowUserToDeleteRows = false;
            this.dgvTabAmort.AllowUserToOrderColumns = true;
            this.dgvTabAmort.AllowUserToResizeColumns = false;
            this.dgvTabAmort.AllowUserToResizeRows = false;
            this.dgvTabAmort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabAmort.Location = new System.Drawing.Point(20, 329);
            this.dgvTabAmort.Name = "dgvTabAmort";
            this.dgvTabAmort.ReadOnly = true;
            this.dgvTabAmort.RowHeadersVisible = false;
            this.dgvTabAmort.Size = new System.Drawing.Size(628, 150);
            this.dgvTabAmort.TabIndex = 16;
            // 
            // frmEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(893, 515);
            this.Controls.Add(this.dgvTabAmort);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbxAssurances);
            this.Controls.Add(this.lblAssurance);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.cbxDuree);
            this.Controls.Add(this.cbxTaux);
            this.Controls.Add(this.tbxMontant);
            this.Controls.Add(this.lblMontantMensualite);
            this.Controls.Add(this.lblMensualite);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblTaux);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblTitre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmEmprunt";
            this.Text = "Remboursement Emprunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabAmort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblTaux;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblMensualite;
        private System.Windows.Forms.Label lblMontantMensualite;
        private System.Windows.Forms.TextBox tbxMontant;
        private System.Windows.Forms.ComboBox cbxTaux;
        private System.Windows.Forms.ComboBox cbxDuree;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblAssurance;
        private System.Windows.Forms.TextBox tbxAssurances;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.DataGridView dgvTabAmort;
    }
}

