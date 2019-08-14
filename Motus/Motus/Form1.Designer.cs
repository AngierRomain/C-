namespace Motus
{
    partial class Motus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motus));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dgvMotus = new System.Windows.Forms.DataGridView();
            this.tbxMot = new System.Windows.Forms.TextBox();
            this.cbxNbLettres = new System.Windows.Forms.ComboBox();
            this.lblLettre = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(354, 450);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(83, 41);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(38, 450);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(152, 41);
            this.btnJouer.TabIndex = 1;
            this.btnJouer.Text = "Nouvelle Partie";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(223, 450);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 41);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dgvMotus
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMotus.Location = new System.Drawing.Point(81, 138);
            this.dgvMotus.Name = "dgvMotus";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMotus.Size = new System.Drawing.Size(337, 287);
            this.dgvMotus.TabIndex = 4;
            // 
            // tbxMot
            // 
            this.tbxMot.Location = new System.Drawing.Point(90, 82);
            this.tbxMot.Name = "tbxMot";
            this.tbxMot.Size = new System.Drawing.Size(150, 20);
            this.tbxMot.TabIndex = 5;
            this.tbxMot.TextChanged += new System.EventHandler(this.tbxMot_TextChanged);
            this.tbxMot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMot_KeyDown);
            // 
            // cbxNbLettres
            // 
            this.cbxNbLettres.FormattingEnabled = true;
            this.cbxNbLettres.Location = new System.Drawing.Point(316, 31);
            this.cbxNbLettres.Name = "cbxNbLettres";
            this.cbxNbLettres.Size = new System.Drawing.Size(121, 21);
            this.cbxNbLettres.TabIndex = 6;
            this.cbxNbLettres.SelectedIndexChanged += new System.EventHandler(this.cbxNbLettres_SelectedIndexChanged);
            // 
            // lblLettre
            // 
            this.lblLettre.AutoSize = true;
            this.lblLettre.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettre.Location = new System.Drawing.Point(35, 31);
            this.lblLettre.Name = "lblLettre";
            this.lblLettre.Size = new System.Drawing.Size(275, 17);
            this.lblLettre.TabIndex = 7;
            this.lblLettre.Text = "Choisir le nombre de lettres du mot:";
            // 
            // btnValider
            // 
            this.btnValider.Image = global::Motus.Properties.Resources._240_F_30840407_mEX7Ykol3JlUo3jBpffpj88CtuhxGyCt_ConvertImage;
            this.btnValider.Location = new System.Drawing.Point(336, 71);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(91, 41);
            this.btnValider.TabIndex = 3;
            this.btnValider.TabStop = false;
            this.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnValider.UseMnemonic = false;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Motus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(538, 543);
            this.Controls.Add(this.lblLettre);
            this.Controls.Add(this.cbxNbLettres);
            this.Controls.Add(this.tbxMot);
            this.Controls.Add(this.dgvMotus);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.btnQuitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Motus";
            this.Text = "Motus";
            this.Load += new System.EventHandler(this.Motus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dgvMotus;
        private System.Windows.Forms.TextBox tbxMot;
        private System.Windows.Forms.ComboBox cbxNbLettres;
        private System.Windows.Forms.Label lblLettre;
    }
}

