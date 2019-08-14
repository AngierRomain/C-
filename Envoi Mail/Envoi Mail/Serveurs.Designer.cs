namespace Envoi_Mail
{
    partial class Serveurs
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
            this.lbxListeServ = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutServ = new System.Windows.Forms.Button();
            this.btnSupprServ = new System.Windows.Forms.Button();
            this.btnModifServ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxListeServ
            // 
            this.lbxListeServ.FormattingEnabled = true;
            this.lbxListeServ.Location = new System.Drawing.Point(23, 52);
            this.lbxListeServ.Name = "lbxListeServ";
            this.lbxListeServ.Size = new System.Drawing.Size(182, 316);
            this.lbxListeServ.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serveurs";
            // 
            // btnAjoutServ
            // 
            this.btnAjoutServ.Location = new System.Drawing.Point(275, 52);
            this.btnAjoutServ.Name = "btnAjoutServ";
            this.btnAjoutServ.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutServ.TabIndex = 2;
            this.btnAjoutServ.Text = "Ajouter";
            this.btnAjoutServ.UseVisualStyleBackColor = true;
            // 
            // btnSupprServ
            // 
            this.btnSupprServ.Location = new System.Drawing.Point(275, 151);
            this.btnSupprServ.Name = "btnSupprServ";
            this.btnSupprServ.Size = new System.Drawing.Size(75, 23);
            this.btnSupprServ.TabIndex = 3;
            this.btnSupprServ.Text = "Supprimer";
            this.btnSupprServ.UseVisualStyleBackColor = true;
            // 
            // btnModifServ
            // 
            this.btnModifServ.Location = new System.Drawing.Point(275, 97);
            this.btnModifServ.Name = "btnModifServ";
            this.btnModifServ.Size = new System.Drawing.Size(75, 23);
            this.btnModifServ.TabIndex = 4;
            this.btnModifServ.Text = "Modifier";
            this.btnModifServ.UseVisualStyleBackColor = true;
            this.btnModifServ.Click += new System.EventHandler(this.btnModifServ_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 477);
            this.Controls.Add(this.btnModifServ);
            this.Controls.Add(this.btnSupprServ);
            this.Controls.Add(this.btnAjoutServ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxListeServ);
            this.Name = "Form2";
            this.Text = "Serveurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxListeServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutServ;
        private System.Windows.Forms.Button btnSupprServ;
        private System.Windows.Forms.Button btnModifServ;
    }
}