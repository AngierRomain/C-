namespace Nombre_Mystère
{
    partial class FrmNombre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNombre));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.quitter = new System.Windows.Forms.Button();
            this.btnVerif = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(9, 48);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(660, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bonjour ! Je m\'appelle Romain et je vous souhaite la bienvenue dans le jeu du nom" +
    "bre mystère !";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl2.Location = new System.Drawing.Point(22, 106);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(582, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Votre mission : Trouver un nombre entre 0 et 100 généré aléatoirement par ce magn" +
    "ifique programme.";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(37, 132);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(564, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Vous n\'avez que  7 essais pour trouver le nombre mystère... Bonne chance !";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(36, 179);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(231, 19);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Entrez un nombre entre 0 et 100 :";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(271, 176);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(54, 26);
            this.tbxNombre.TabIndex = 4;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(480, 310);
            this.quitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(61, 23);
            this.quitter.TabIndex = 5;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // btnVerif
            // 
            this.btnVerif.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.Image = global::Nombre_Mystère.Properties.Resources._240_F_30156001_ATS9wVlqiLZRwszfyVCwGiVqgAXMaILa_ConvertImage;
            this.btnVerif.Location = new System.Drawing.Point(338, 153);
            this.btnVerif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(71, 72);
            this.btnVerif.TabIndex = 6;
            this.btnVerif.UseVisualStyleBackColor = false;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Location = new System.Drawing.Point(382, 310);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(75, 23);
            this.btnRejouer.TabIndex = 7;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // FrmNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNombre";
            this.Text = "Jeu du nombre mystère";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Button btnRejouer;
    }
}

