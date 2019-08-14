namespace Envoi_Mail
{
    partial class Contacts
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
            this.lbxContacts2 = new System.Windows.Forms.ListBox();
            this.btnSupprimer2 = new System.Windows.Forms.Button();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnModifier2 = new System.Windows.Forms.Button();
            this.tbxMail2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxContacts2
            // 
            this.lbxContacts2.FormattingEnabled = true;
            this.lbxContacts2.Location = new System.Drawing.Point(26, 62);
            this.lbxContacts2.Name = "lbxContacts2";
            this.lbxContacts2.Size = new System.Drawing.Size(172, 290);
            this.lbxContacts2.TabIndex = 0;
            // 
            // btnSupprimer2
            // 
            this.btnSupprimer2.Location = new System.Drawing.Point(282, 86);
            this.btnSupprimer2.Name = "btnSupprimer2";
            this.btnSupprimer2.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer2.TabIndex = 1;
            this.btnSupprimer2.Text = "Supprimer";
            this.btnSupprimer2.UseVisualStyleBackColor = true;
            // 
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(282, 187);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact.TabIndex = 2;
            this.btnNewContact.Text = "Nouveau contact";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnModifier2
            // 
            this.btnModifier2.Location = new System.Drawing.Point(282, 134);
            this.btnModifier2.Name = "btnModifier2";
            this.btnModifier2.Size = new System.Drawing.Size(75, 23);
            this.btnModifier2.TabIndex = 3;
            this.btnModifier2.Text = "Modifier";
            this.btnModifier2.UseVisualStyleBackColor = true;
            // 
            // tbxMail2
            // 
            this.tbxMail2.Location = new System.Drawing.Point(282, 263);
            this.tbxMail2.Name = "tbxMail2";
            this.tbxMail2.Size = new System.Drawing.Size(142, 20);
            this.tbxMail2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresse mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contacts";
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMail2);
            this.Controls.Add(this.btnModifier2);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.btnSupprimer2);
            this.Controls.Add(this.lbxContacts2);
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxContacts2;
        private System.Windows.Forms.Button btnSupprimer2;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnModifier2;
        private System.Windows.Forms.TextBox tbxMail2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}