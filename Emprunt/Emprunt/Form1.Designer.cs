namespace Emprunt
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
            this.btnCalculer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(98, 190);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(137, 48);
            this.btnCalculer.TabIndex = 0;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre prénom :";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(150, 59);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(172, 20);
            this.tbxPrenom.TabIndex = 2;
            this.tbxPrenom.TextChanged += new System.EventHandler(this.tbxPrenom_TextChanged);
            // 
            // frmEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculer);
            this.Name = "frmEmprunt";
            this.Text = "Emprunt";
            this.Load += new System.EventHandler(this.frmEmprunt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrenom;
    }
}

