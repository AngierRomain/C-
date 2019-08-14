namespace Envoi_Mail
{
    partial class adresses
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
            this.lbxMails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxMails
            // 
            this.lbxMails.FormattingEnabled = true;
            this.lbxMails.Location = new System.Drawing.Point(48, 68);
            this.lbxMails.Name = "lbxMails";
            this.lbxMails.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxMails.Size = new System.Drawing.Size(187, 186);
            this.lbxMails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez les adresses à utiliser:";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(51, 267);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(107, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider la sélection";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // adresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxMails);
            this.Name = "adresses";
            this.Text = "Sélection adresses";
            this.Load += new System.EventHandler(this.adresses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
    }
}