namespace Envoi_Mail
{
    partial class EnvoiMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvoiMail));
            this.btnEnvoiMail = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.tbxObjet = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.tbxExp = new System.Windows.Forms.TextBox();
            this.tbxCopieCachee = new System.Windows.Forms.TextBox();
            this.tbxCopie = new System.Windows.Forms.TextBox();
            this.btnAjouterPJ = new System.Windows.Forms.Button();
            this.cbxServ = new System.Windows.Forms.ComboBox();
            this.btnCopieCachee = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnServ = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxDest = new System.Windows.Forms.TextBox();
            this.btnCopie = new System.Windows.Forms.Button();
            this.btnAjouterDestinataire = new System.Windows.Forms.Button();
            this.btnMesContacts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnvoiMail
            // 
            this.btnEnvoiMail.Location = new System.Drawing.Point(15, 436);
            this.btnEnvoiMail.Name = "btnEnvoiMail";
            this.btnEnvoiMail.Size = new System.Drawing.Size(99, 27);
            this.btnEnvoiMail.TabIndex = 0;
            this.btnEnvoiMail.Text = "Envoyer";
            this.btnEnvoiMail.UseVisualStyleBackColor = true;
            this.btnEnvoiMail.Click += new System.EventHandler(this.btnEnvoiMail_Click_1);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(156, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(272, 31);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Bord\'o Mail Express";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serveur SMTP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destinataire:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Copie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expediteur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Copie cachée:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Objet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pièces jointes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Message:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(94, 322);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(368, 97);
            this.tbxMessage.TabIndex = 10;
            // 
            // tbxObjet
            // 
            this.tbxObjet.Location = new System.Drawing.Point(94, 247);
            this.tbxObjet.Name = "tbxObjet";
            this.tbxObjet.Size = new System.Drawing.Size(287, 20);
            this.tbxObjet.TabIndex = 11;
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // tbxExp
            // 
            this.tbxExp.Location = new System.Drawing.Point(94, 215);
            this.tbxExp.Name = "tbxExp";
            this.tbxExp.Size = new System.Drawing.Size(287, 20);
            this.tbxExp.TabIndex = 12;
            // 
            // tbxCopieCachee
            // 
            this.tbxCopieCachee.Location = new System.Drawing.Point(94, 182);
            this.tbxCopieCachee.Name = "tbxCopieCachee";
            this.tbxCopieCachee.Size = new System.Drawing.Size(287, 20);
            this.tbxCopieCachee.TabIndex = 13;
            // 
            // tbxCopie
            // 
            this.tbxCopie.Location = new System.Drawing.Point(94, 142);
            this.tbxCopie.Name = "tbxCopie";
            this.tbxCopie.Size = new System.Drawing.Size(287, 20);
            this.tbxCopie.TabIndex = 14;
            // 
            // btnAjouterPJ
            // 
            this.btnAjouterPJ.Location = new System.Drawing.Point(94, 282);
            this.btnAjouterPJ.Name = "btnAjouterPJ";
            this.btnAjouterPJ.Size = new System.Drawing.Size(127, 23);
            this.btnAjouterPJ.TabIndex = 16;
            this.btnAjouterPJ.Text = "Ajouter une pièce jointe";
            this.btnAjouterPJ.UseVisualStyleBackColor = true;
            this.btnAjouterPJ.Click += new System.EventHandler(this.btnAjouterPJ_Click);
            // 
            // cbxServ
            // 
            this.cbxServ.FormattingEnabled = true;
            this.cbxServ.Location = new System.Drawing.Point(94, 73);
            this.cbxServ.Name = "cbxServ";
            this.cbxServ.Size = new System.Drawing.Size(287, 21);
            this.cbxServ.TabIndex = 17;
            // 
            // btnCopieCachee
            // 
            this.btnCopieCachee.Location = new System.Drawing.Point(387, 179);
            this.btnCopieCachee.Name = "btnCopieCachee";
            this.btnCopieCachee.Size = new System.Drawing.Size(75, 23);
            this.btnCopieCachee.TabIndex = 21;
            this.btnCopieCachee.Text = "Ajouter";
            this.btnCopieCachee.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(373, 434);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(89, 29);
            this.btnQuitter.TabIndex = 22;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(387, 74);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(75, 23);
            this.btnServ.TabIndex = 23;
            this.btnServ.Text = "Serveurs";
            this.btnServ.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // tbxDest
            // 
            this.tbxDest.Location = new System.Drawing.Point(94, 109);
            this.tbxDest.Name = "tbxDest";
            this.tbxDest.Size = new System.Drawing.Size(287, 20);
            this.tbxDest.TabIndex = 25;
            // 
            // btnCopie
            // 
            this.btnCopie.Location = new System.Drawing.Point(387, 139);
            this.btnCopie.Name = "btnCopie";
            this.btnCopie.Size = new System.Drawing.Size(75, 23);
            this.btnCopie.TabIndex = 20;
            this.btnCopie.Text = "Ajouter";
            this.btnCopie.UseVisualStyleBackColor = true;
            // 
            // btnAjouterDestinataire
            // 
            this.btnAjouterDestinataire.Location = new System.Drawing.Point(387, 107);
            this.btnAjouterDestinataire.Name = "btnAjouterDestinataire";
            this.btnAjouterDestinataire.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterDestinataire.TabIndex = 19;
            this.btnAjouterDestinataire.Text = "Ajouter";
            this.btnAjouterDestinataire.UseVisualStyleBackColor = true;
            this.btnAjouterDestinataire.Click += new System.EventHandler(this.btnAjouterDestinataire_Click);
            // 
            // btnMesContacts
            // 
            this.btnMesContacts.Location = new System.Drawing.Point(162, 436);
            this.btnMesContacts.Name = "btnMesContacts";
            this.btnMesContacts.Size = new System.Drawing.Size(124, 27);
            this.btnMesContacts.TabIndex = 26;
            this.btnMesContacts.Text = "Mes contacts";
            this.btnMesContacts.UseVisualStyleBackColor = true;
            // 
            // EnvoiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(678, 485);
            this.Controls.Add(this.btnMesContacts);
            this.Controls.Add(this.tbxDest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServ);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnCopieCachee);
            this.Controls.Add(this.btnCopie);
            this.Controls.Add(this.btnAjouterDestinataire);
            this.Controls.Add(this.cbxServ);
            this.Controls.Add(this.btnAjouterPJ);
            this.Controls.Add(this.tbxCopie);
            this.Controls.Add(this.tbxCopieCachee);
            this.Controls.Add(this.tbxExp);
            this.Controls.Add(this.tbxObjet);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnEnvoiMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnvoiMail";
            this.Text = "Envoi Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvoiMail;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox tbxObjet;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.TextBox tbxExp;
        private System.Windows.Forms.TextBox tbxCopieCachee;
        private System.Windows.Forms.TextBox tbxCopie;
        private System.Windows.Forms.Button btnAjouterPJ;
        private System.Windows.Forms.ComboBox cbxServ;
        private System.Windows.Forms.Button btnCopieCachee;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnServ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxDest;
        private System.Windows.Forms.Button btnCopie;
        private System.Windows.Forms.Button btnAjouterDestinataire;
        private System.Windows.Forms.Button btnMesContacts;
    }
}

