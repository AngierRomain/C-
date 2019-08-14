namespace GSB
{
    partial class frmGestFiche
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestFiche));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMontantDeclare1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvLignesFiches = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateCloture = new System.Windows.Forms.Label();
            this.lblMontantDeclare2 = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblDateE = new System.Windows.Forms.Label();
            this.lblCPVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnMEP = new System.Windows.Forms.Button();
            this.btnCloturer = new System.Windows.Forms.Button();
            this.btnRembourse = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignesFiches)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Red;
            this.lblTitre.Location = new System.Drawing.Point(284, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(650, 24);
            this.lblTitre.TabIndex = 30;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(803, 426);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 40);
            this.btnQuitter.TabIndex = 29;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblMontantDeclare1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(288, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 55);
            this.panel4.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Montant déclaré :";
            // 
            // lblMontantDeclare1
            // 
            this.lblMontantDeclare1.AutoSize = true;
            this.lblMontantDeclare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantDeclare1.ForeColor = System.Drawing.Color.Red;
            this.lblMontantDeclare1.Location = new System.Drawing.Point(194, 18);
            this.lblMontantDeclare1.Name = "lblMontantDeclare1";
            this.lblMontantDeclare1.Size = new System.Drawing.Size(63, 18);
            this.lblMontantDeclare1.TabIndex = 18;
            this.lblMontantDeclare1.Text = "déclaré";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Montant déclaré :";
            // 
            // dgvLignesFiches
            // 
            this.dgvLignesFiches.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLignesFiches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLignesFiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignesFiches.Location = new System.Drawing.Point(288, 36);
            this.dgvLignesFiches.Name = "dgvLignesFiches";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLignesFiches.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLignesFiches.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLignesFiches.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLignesFiches.Size = new System.Drawing.Size(650, 319);
            this.dgvLignesFiches.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDateCloture);
            this.panel2.Controls.Add(this.lblMontantDeclare2);
            this.panel2.Controls.Add(this.lblEtat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 130);
            this.panel2.TabIndex = 25;
            // 
            // lblDateCloture
            // 
            this.lblDateCloture.AutoSize = true;
            this.lblDateCloture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCloture.Location = new System.Drawing.Point(109, 10);
            this.lblDateCloture.Name = "lblDateCloture";
            this.lblDateCloture.Size = new System.Drawing.Size(88, 18);
            this.lblDateCloture.TabIndex = 20;
            this.lblDateCloture.Text = "Date clôture";
            // 
            // lblMontantDeclare2
            // 
            this.lblMontantDeclare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantDeclare2.Location = new System.Drawing.Point(131, 67);
            this.lblMontantDeclare2.Name = "lblMontantDeclare2";
            this.lblMontantDeclare2.Size = new System.Drawing.Size(91, 18);
            this.lblMontantDeclare2.TabIndex = 18;
            this.lblMontantDeclare2.Text = "Montant declare";
            this.lblMontantDeclare2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(55, 38);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(34, 18);
            this.lblEtat.TabIndex = 17;
            this.lblEtat.Text = "Etat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Montant déclaré :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Etat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date clôture :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateEmbauche);
            this.panel1.Controls.Add(this.lblDateE);
            this.panel1.Controls.Add(this.lblCPVille);
            this.panel1.Controls.Add(this.lblAdresse);
            this.panel1.Controls.Add(this.lblNomPrenom);
            this.panel1.Location = new System.Drawing.Point(12, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 115);
            this.panel1.TabIndex = 24;
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEmbauche.Location = new System.Drawing.Point(133, 85);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(112, 18);
            this.lblDateEmbauche.TabIndex = 17;
            this.lblDateEmbauche.Text = "Date embauche";
            // 
            // lblDateE
            // 
            this.lblDateE.AutoSize = true;
            this.lblDateE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateE.Location = new System.Drawing.Point(7, 85);
            this.lblDateE.Name = "lblDateE";
            this.lblDateE.Size = new System.Drawing.Size(120, 18);
            this.lblDateE.TabIndex = 16;
            this.lblDateE.Text = "Date embauche :";
            // 
            // lblCPVille
            // 
            this.lblCPVille.AutoSize = true;
            this.lblCPVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPVille.Location = new System.Drawing.Point(7, 56);
            this.lblCPVille.Name = "lblCPVille";
            this.lblCPVille.Size = new System.Drawing.Size(69, 18);
            this.lblCPVille.TabIndex = 15;
            this.lblCPVille.Text = "lblCPVille";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(7, 38);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(76, 18);
            this.lblAdresse.TabIndex = 14;
            this.lblAdresse.Text = "lblAdresse";
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrenom.Location = new System.Drawing.Point(7, 9);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(108, 18);
            this.lblNomPrenom.TabIndex = 13;
            this.lblNomPrenom.Text = "lblNomPrenom";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(260, 164);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 23;
            this.pbxLogo.TabStop = false;
            // 
            // btnMEP
            // 
            this.btnMEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMEP.Location = new System.Drawing.Point(447, 426);
            this.btnMEP.Name = "btnMEP";
            this.btnMEP.Size = new System.Drawing.Size(161, 38);
            this.btnMEP.TabIndex = 32;
            this.btnMEP.Text = "Mise en paiement";
            this.btnMEP.UseVisualStyleBackColor = true;
            this.btnMEP.Click += new System.EventHandler(this.btnMEP_Click);
            // 
            // btnCloturer
            // 
            this.btnCloturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloturer.Location = new System.Drawing.Point(298, 426);
            this.btnCloturer.Name = "btnCloturer";
            this.btnCloturer.Size = new System.Drawing.Size(143, 38);
            this.btnCloturer.TabIndex = 31;
            this.btnCloturer.Text = "Cloturer fiche";
            this.btnCloturer.UseVisualStyleBackColor = true;
            this.btnCloturer.Click += new System.EventHandler(this.btnCloturer_Click);
            // 
            // btnRembourse
            // 
            this.btnRembourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRembourse.Location = new System.Drawing.Point(614, 426);
            this.btnRembourse.Name = "btnRembourse";
            this.btnRembourse.Size = new System.Drawing.Size(183, 40);
            this.btnRembourse.TabIndex = 29;
            this.btnRembourse.Text = "Fiche remboursée";
            this.btnRembourse.UseVisualStyleBackColor = true;
            this.btnRembourse.Click += new System.EventHandler(this.btnRembourse_Click);
            // 
            // frmGestFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 478);
            this.Controls.Add(this.btnRembourse);
            this.Controls.Add(this.btnMEP);
            this.Controls.Add(this.btnCloturer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvLignesFiches);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxLogo);
            this.Name = "frmGestFiche";
            this.Text = "frmGestFiche";
            this.Load += new System.EventHandler(this.frmGestFiche_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignesFiches)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMontantDeclare1;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvLignesFiches;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDateCloture;
        private System.Windows.Forms.Label lblMontantDeclare2;
        private System.Windows.Forms.Label lblEtat;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblDateE;
        internal System.Windows.Forms.Label lblCPVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNomPrenom;
        internal System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnMEP;
        private System.Windows.Forms.Button btnCloturer;
        private System.Windows.Forms.Button btnRembourse;
    }
}