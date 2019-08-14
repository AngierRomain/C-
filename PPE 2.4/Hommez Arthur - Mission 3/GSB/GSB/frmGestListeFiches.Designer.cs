namespace GSB
{
    partial class frmGestListeFiches
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestListeFiches));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.dgvFiches = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBContenu = new System.Windows.Forms.CheckBox();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.cbxEtat = new System.Windows.Forms.ComboBox();
            this.cbxVisiteur = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(713, 388);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(237, 38);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(713, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(237, 139);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 14;
            this.pbxLogo.TabStop = false;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrir.Location = new System.Drawing.Point(713, 300);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(237, 38);
            this.btnOuvrir.TabIndex = 13;
            this.btnOuvrir.Text = "Ouvrir fiche";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // dgvFiches
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiches.Location = new System.Drawing.Point(12, 38);
            this.dgvFiches.Name = "dgvFiches";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFiches.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFiches.Size = new System.Drawing.Size(680, 388);
            this.dgvFiches.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(713, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 38);
            this.button4.TabIndex = 19;
            this.button4.Text = "Supprimer fiche ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mois :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Année :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Etat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Visiteur :";
            // 
            // chkBContenu
            // 
            this.chkBContenu.AutoSize = true;
            this.chkBContenu.Location = new System.Drawing.Point(800, 277);
            this.chkBContenu.Name = "chkBContenu";
            this.chkBContenu.Size = new System.Drawing.Size(58, 17);
            this.chkBContenu.TabIndex = 24;
            this.chkBContenu.Text = "Vide(s)";
            this.chkBContenu.UseVisualStyleBackColor = true;
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbxMois.Location = new System.Drawing.Point(748, 171);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(71, 21);
            this.cbxMois.TabIndex = 25;
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cbxAnnee.Location = new System.Drawing.Point(890, 171);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(71, 21);
            this.cbxAnnee.TabIndex = 26;
            // 
            // cbxEtat
            // 
            this.cbxEtat.FormattingEnabled = true;
            this.cbxEtat.Items.AddRange(new object[] {
            "En cours de saisie",
            "Clôturée",
            "Validée",
            "Mise en paiement",
            "Remboursée"});
            this.cbxEtat.Location = new System.Drawing.Point(748, 208);
            this.cbxEtat.Name = "cbxEtat";
            this.cbxEtat.Size = new System.Drawing.Size(141, 21);
            this.cbxEtat.TabIndex = 27;
            // 
            // cbxVisiteur
            // 
            this.cbxVisiteur.FormattingEnabled = true;
            this.cbxVisiteur.Location = new System.Drawing.Point(748, 243);
            this.cbxVisiteur.Name = "cbxVisiteur";
            this.cbxVisiteur.Size = new System.Drawing.Size(131, 21);
            this.cbxVisiteur.TabIndex = 28;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 4);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(210, 31);
            this.lblTitre.TabIndex = 29;
            this.lblTitre.Text = "Liste des fiches:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Montant déclaré :";
            // 
            // frmGestListeFiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(973, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cbxVisiteur);
            this.Controls.Add(this.cbxEtat);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.chkBContenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.dgvFiches);
            this.Name = "frmGestListeFiches";
            this.Text = "frmGestListeFiches";
            this.Load += new System.EventHandler(this.frmGestListeFiches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        internal System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.DataGridView dgvFiches;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBContenu;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.ComboBox cbxEtat;
        private System.Windows.Forms.ComboBox cbxVisiteur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label5;
    }
}