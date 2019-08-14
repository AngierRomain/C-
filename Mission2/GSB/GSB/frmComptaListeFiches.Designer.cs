namespace GSB
{
    partial class frmComptaListeFiches
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComptaListeFiches));
            this.dgvFiches = new System.Windows.Forms.DataGridView();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnNouvelleFiche = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiches
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiches.Location = new System.Drawing.Point(12, 12);
            this.dgvFiches.Name = "dgvFiches";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFiches.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFiches.Size = new System.Drawing.Size(680, 388);
            this.dgvFiches.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(715, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(237, 139);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 10;
            this.pbxLogo.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(715, 362);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(237, 38);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnNouvelleFiche
            // 
            this.btnNouvelleFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleFiche.Location = new System.Drawing.Point(715, 267);
            this.btnNouvelleFiche.Name = "btnNouvelleFiche";
            this.btnNouvelleFiche.Size = new System.Drawing.Size(237, 38);
            this.btnNouvelleFiche.TabIndex = 12;
            this.btnNouvelleFiche.Text = "Fiche de frais";
            this.btnNouvelleFiche.UseVisualStyleBackColor = true;
            this.btnNouvelleFiche.Click += new System.EventHandler(this.btnNouvelleFiche_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(715, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nouvelle fiche de frais";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmComptaListeFiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(967, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNouvelleFiche);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.dgvFiches);
            this.Name = "frmComptaListeFiches";
            this.Text = "GSB Gestion des frais - Compta Fiches de frais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmComptaListeFiches_FormClosed);
            this.Load += new System.EventHandler(this.frmComptaListeFiches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiches;
        internal System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnNouvelleFiche;
        private System.Windows.Forms.Button button1;
    }
}