namespace LibraryUserControl
{
    partial class ucGestionEngin
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDateRecep = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.btnGauche = new System.Windows.Forms.Button();
            this.btnDroit = new System.Windows.Forms.Button();
            this.pbImgEngin = new System.Windows.Forms.PictureBox();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.lblCompteur = new System.Windows.Forms.Label();
            this.pnlTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitre.Location = new System.Drawing.Point(582, 39);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(428, 54);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Engins";
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTitre.Controls.Add(this.lblTitre);
            this.pnlTitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTitre.Location = new System.Drawing.Point(0, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1530, 133);
            this.pnlTitre.TabIndex = 1;
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.BackColor = System.Drawing.Color.Transparent;
            this.lblChoixCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixCaserne.Location = new System.Drawing.Point(47, 184);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(271, 36);
            this.lblChoixCaserne.TabIndex = 2;
            this.lblChoixCaserne.Text = "choix de la caserne";
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(350, 176);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(354, 44);
            this.cboChoixCaserne.TabIndex = 3;
            this.cboChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cboChoixCaserne_SelectedIndexChanged);
            this.cboChoixCaserne.SelectedValueChanged += new System.EventHandler(this.cboChoixCaserne_SelectedValueChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(862, 184);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(144, 36);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numéro : ";
            // 
            // lblDateRecep
            // 
            this.lblDateRecep.AutoSize = true;
            this.lblDateRecep.BackColor = System.Drawing.Color.Transparent;
            this.lblDateRecep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRecep.Location = new System.Drawing.Point(1188, 346);
            this.lblDateRecep.Name = "lblDateRecep";
            this.lblDateRecep.Size = new System.Drawing.Size(272, 36);
            this.lblDateRecep.TabIndex = 5;
            this.lblDateRecep.Text = "Date de récéption : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(102, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(123, 36);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status : ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(1060, 184);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(72, 36);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "num";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1273, 408);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 36);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date ";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.BackColor = System.Drawing.Color.Transparent;
            this.lblStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.Location = new System.Drawing.Point(102, 408);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(107, 36);
            this.lblStat.TabIndex = 9;
            this.lblStat.Text = "Status ";
            // 
            // btnGauche
            // 
            this.btnGauche.BackColor = System.Drawing.Color.Maroon;
            this.btnGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauche.Location = new System.Drawing.Point(478, 849);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(121, 68);
            this.btnGauche.TabIndex = 10;
            this.btnGauche.Text = "<";
            this.btnGauche.UseVisualStyleBackColor = false;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // btnDroit
            // 
            this.btnDroit.BackColor = System.Drawing.Color.Maroon;
            this.btnDroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDroit.Location = new System.Drawing.Point(872, 849);
            this.btnDroit.Name = "btnDroit";
            this.btnDroit.Size = new System.Drawing.Size(121, 68);
            this.btnDroit.TabIndex = 11;
            this.btnDroit.Text = ">";
            this.btnDroit.UseVisualStyleBackColor = false;
            this.btnDroit.Click += new System.EventHandler(this.btnDroit_Click);
            // 
            // pbImgEngin
            // 
            this.pbImgEngin.Location = new System.Drawing.Point(350, 335);
            this.pbImgEngin.Name = "pbImgEngin";
            this.pbImgEngin.Size = new System.Drawing.Size(770, 460);
            this.pbImgEngin.TabIndex = 12;
            this.pbImgEngin.TabStop = false;
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.Maroon;
            this.btnDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDernier.Location = new System.Drawing.Point(999, 849);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(121, 68);
            this.btnDernier.TabIndex = 13;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.Maroon;
            this.btnPremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremier.Location = new System.Drawing.Point(350, 849);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(121, 68);
            this.btnPremier.TabIndex = 14;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // lblCompteur
            // 
            this.lblCompteur.AutoSize = true;
            this.lblCompteur.BackColor = System.Drawing.Color.Maroon;
            this.lblCompteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompteur.Location = new System.Drawing.Point(682, 865);
            this.lblCompteur.Name = "lblCompteur";
            this.lblCompteur.Size = new System.Drawing.Size(23, 36);
            this.lblCompteur.TabIndex = 15;
            this.lblCompteur.Text = "/";
            // 
            // ucGestionEngin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblCompteur);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.pbImgEngin);
            this.Controls.Add(this.btnDroit);
            this.Controls.Add(this.btnGauche);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDateRecep);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cboChoixCaserne);
            this.Controls.Add(this.lblChoixCaserne);
            this.Controls.Add(this.pnlTitre);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Name = "ucGestionEngin";
            this.Size = new System.Drawing.Size(1530, 950);
            this.Load += new System.EventHandler(this.ucGestionEngin_Load);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.ComboBox cboChoixCaserne;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDateRecep;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Button btnDroit;
        private System.Windows.Forms.PictureBox pbImgEngin;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Label lblCompteur;
    }
}
