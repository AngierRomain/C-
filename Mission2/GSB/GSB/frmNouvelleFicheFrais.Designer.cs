namespace GSB
{
    partial class frmNouvelleFicheFrais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouvelleFicheFrais));
            this.btnValiderDate = new System.Windows.Forms.Button();
            this.cbxMoisAnnee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.lblDateCloture = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLignesFiches = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCloturer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.cbxTypeDeFrais = new System.Windows.Forms.ComboBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignesFiches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValiderDate
            // 
            this.btnValiderDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderDate.Location = new System.Drawing.Point(252, 19);
            this.btnValiderDate.Name = "btnValiderDate";
            this.btnValiderDate.Size = new System.Drawing.Size(76, 27);
            this.btnValiderDate.TabIndex = 53;
            this.btnValiderDate.Text = "Valider";
            this.btnValiderDate.UseVisualStyleBackColor = true;
            // 
            // cbxMoisAnnee
            // 
            this.cbxMoisAnnee.FormattingEnabled = true;
            this.cbxMoisAnnee.Location = new System.Drawing.Point(119, 23);
            this.cbxMoisAnnee.Name = "cbxMoisAnnee";
            this.cbxMoisAnnee.Size = new System.Drawing.Size(119, 21);
            this.cbxMoisAnnee.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Mois/Année :";
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(732, 346);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(76, 33);
            this.btnModifier.TabIndex = 50;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(920, 65);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(120, 80);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 49;
            this.pbxLogo.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Informations de la fiche";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Informations utilisateur";
            // 
            // lblPrenom
            // 
            this.lblPrenom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(100, 118);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(138, 16);
            this.lblPrenom.TabIndex = 46;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(100, 94);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(138, 16);
            this.lblNom.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Prénom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nom :";
            // 
            // lblMontant
            // 
            this.lblMontant.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(100, 324);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(138, 16);
            this.lblMontant.TabIndex = 42;
            // 
            // lblEtat
            // 
            this.lblEtat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(100, 300);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(138, 16);
            this.lblEtat.TabIndex = 41;
            // 
            // lblDateCloture
            // 
            this.lblDateCloture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDateCloture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateCloture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCloture.Location = new System.Drawing.Point(100, 276);
            this.lblDateCloture.Name = "lblDateCloture";
            this.lblDateCloture.Size = new System.Drawing.Size(138, 16);
            this.lblDateCloture.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Montant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Etat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date cloture :";
            // 
            // dgvLignesFiches
            // 
            this.dgvLignesFiches.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLignesFiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignesFiches.Location = new System.Drawing.Point(254, 64);
            this.dgvLignesFiches.Name = "dgvLignesFiches";
            this.dgvLignesFiches.Size = new System.Drawing.Size(649, 276);
            this.dgvLignesFiches.TabIndex = 36;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(254, 346);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(76, 33);
            this.btnQuitter.TabIndex = 35;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(920, 307);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(121, 33);
            this.btnValider.TabIndex = 34;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnCloturer
            // 
            this.btnCloturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloturer.Location = new System.Drawing.Point(650, 346);
            this.btnCloturer.Name = "btnCloturer";
            this.btnCloturer.Size = new System.Drawing.Size(76, 33);
            this.btnCloturer.TabIndex = 33;
            this.btnCloturer.Text = "Cloturer";
            this.btnCloturer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(917, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Quantité :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(917, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Type de frais :";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(920, 263);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(121, 20);
            this.txtQuantite.TabIndex = 30;
            // 
            // cbxTypeDeFrais
            // 
            this.cbxTypeDeFrais.FormattingEnabled = true;
            this.cbxTypeDeFrais.Location = new System.Drawing.Point(920, 220);
            this.cbxTypeDeFrais.Name = "cbxTypeDeFrais";
            this.cbxTypeDeFrais.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeDeFrais.TabIndex = 29;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppr.Location = new System.Drawing.Point(814, 346);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(89, 33);
            this.btnSuppr.TabIndex = 54;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // frmNouvelleFicheFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1056, 389);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnValiderDate);
            this.Controls.Add(this.cbxMoisAnnee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.lblDateCloture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLignesFiches);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnCloturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cbxTypeDeFrais);
            this.Name = "frmNouvelleFicheFrais";
            this.Text = "frmNouvelleFicheFrais";
            this.Load += new System.EventHandler(this.frmNouvelleFicheFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignesFiches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderDate;
        private System.Windows.Forms.ComboBox cbxMoisAnnee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModifier;
        internal System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Label lblDateCloture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLignesFiches;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCloturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ComboBox cbxTypeDeFrais;
        private System.Windows.Forms.Button btnSuppr;
    }
}