namespace NewMission
{
    partial class ucNewMission
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
            this.grpInfoUsage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.grpRegulateur = new System.Windows.Forms.GroupBox();
            this.cboCaserneMobiliser = new System.Windows.Forms.ComboBox();
            this.cboNatureSinistre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNatureSinistre = new System.Windows.Forms.Label();
            this.grpMobilisationPompier = new System.Windows.Forms.GroupBox();
            this.dgvPompierMobilisee = new System.Windows.Forms.DataGridView();
            this.dgvEngin = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEnginMobiliser = new System.Windows.Forms.Label();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDateMission = new System.Windows.Forms.Label();
            this.btnValide = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpInfoUsage.SuspendLayout();
            this.grpRegulateur.SuspendLayout();
            this.grpMobilisationPompier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierMobilisee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfoUsage
            // 
            this.grpInfoUsage.BackColor = System.Drawing.Color.Transparent;
            this.grpInfoUsage.Controls.Add(this.label1);
            this.grpInfoUsage.Controls.Add(this.lblMotif);
            this.grpInfoUsage.Controls.Add(this.txtMotif);
            this.grpInfoUsage.Controls.Add(this.lblVille);
            this.grpInfoUsage.Controls.Add(this.lblCP);
            this.grpInfoUsage.Controls.Add(this.lblRue);
            this.grpInfoUsage.Controls.Add(this.txtVille);
            this.grpInfoUsage.Controls.Add(this.txtCP);
            this.grpInfoUsage.Controls.Add(this.txtRue);
            this.grpInfoUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoUsage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpInfoUsage.Location = new System.Drawing.Point(200, 144);
            this.grpInfoUsage.Name = "grpInfoUsage";
            this.grpInfoUsage.Size = new System.Drawing.Size(1105, 256);
            this.grpInfoUsage.TabIndex = 0;
            this.grpInfoUsage.TabStop = false;
            this.grpInfoUsage.Text = "Information usage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adresse sinistre";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(208, 54);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(65, 29);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(43, 95);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(395, 122);
            this.txtMotif.TabIndex = 6;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(509, 192);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(72, 29);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(509, 147);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(161, 29);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Code postal : ";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(509, 100);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(75, 29);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue : ";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(678, 187);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(355, 34);
            this.txtVille.TabIndex = 2;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(678, 142);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(355, 34);
            this.txtCP.TabIndex = 1;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(678, 95);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(355, 34);
            this.txtRue.TabIndex = 0;
            // 
            // grpRegulateur
            // 
            this.grpRegulateur.BackColor = System.Drawing.Color.Transparent;
            this.grpRegulateur.Controls.Add(this.cboCaserneMobiliser);
            this.grpRegulateur.Controls.Add(this.cboNatureSinistre);
            this.grpRegulateur.Controls.Add(this.label2);
            this.grpRegulateur.Controls.Add(this.lblNatureSinistre);
            this.grpRegulateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegulateur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpRegulateur.Location = new System.Drawing.Point(200, 426);
            this.grpRegulateur.Name = "grpRegulateur";
            this.grpRegulateur.Size = new System.Drawing.Size(1104, 139);
            this.grpRegulateur.TabIndex = 1;
            this.grpRegulateur.TabStop = false;
            this.grpRegulateur.Text = "Décisions du régulateur";
            // 
            // cboCaserneMobiliser
            // 
            this.cboCaserneMobiliser.FormattingEnabled = true;
            this.cboCaserneMobiliser.Location = new System.Drawing.Point(758, 54);
            this.cboCaserneMobiliser.Name = "cboCaserneMobiliser";
            this.cboCaserneMobiliser.Size = new System.Drawing.Size(222, 37);
            this.cboCaserneMobiliser.TabIndex = 12;
            this.cboCaserneMobiliser.SelectedIndexChanged += new System.EventHandler(this.cboCaserneMobiliser_SelectedIndexChanged);
            // 
            // cboNatureSinistre
            // 
            this.cboNatureSinistre.FormattingEnabled = true;
            this.cboNatureSinistre.Location = new System.Drawing.Point(254, 49);
            this.cboNatureSinistre.Name = "cboNatureSinistre";
            this.cboNatureSinistre.Size = new System.Drawing.Size(222, 37);
            this.cboNatureSinistre.TabIndex = 11;
            this.cboNatureSinistre.SelectedIndexChanged += new System.EventHandler(this.cboNatureSinistre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(523, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Caserne à mobiliser";
            // 
            // lblNatureSinistre
            // 
            this.lblNatureSinistre.AutoSize = true;
            this.lblNatureSinistre.Location = new System.Drawing.Point(38, 52);
            this.lblNatureSinistre.Name = "lblNatureSinistre";
            this.lblNatureSinistre.Size = new System.Drawing.Size(201, 29);
            this.lblNatureSinistre.TabIndex = 9;
            this.lblNatureSinistre.Text = "Nature du sinistre";
            // 
            // grpMobilisationPompier
            // 
            this.grpMobilisationPompier.BackColor = System.Drawing.Color.Transparent;
            this.grpMobilisationPompier.Controls.Add(this.dgvPompierMobilisee);
            this.grpMobilisationPompier.Controls.Add(this.dgvEngin);
            this.grpMobilisationPompier.Controls.Add(this.label4);
            this.grpMobilisationPompier.Controls.Add(this.lblEnginMobiliser);
            this.grpMobilisationPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMobilisationPompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpMobilisationPompier.Location = new System.Drawing.Point(200, 590);
            this.grpMobilisationPompier.Name = "grpMobilisationPompier";
            this.grpMobilisationPompier.Size = new System.Drawing.Size(1103, 263);
            this.grpMobilisationPompier.TabIndex = 2;
            this.grpMobilisationPompier.TabStop = false;
            this.grpMobilisationPompier.Text = "Mobilisation des engins et des pompiers";
            // 
            // dgvPompierMobilisee
            // 
            this.dgvPompierMobilisee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompierMobilisee.Location = new System.Drawing.Point(479, 91);
            this.dgvPompierMobilisee.Name = "dgvPompierMobilisee";
            this.dgvPompierMobilisee.RowHeadersWidth = 51;
            this.dgvPompierMobilisee.RowTemplate.Height = 24;
            this.dgvPompierMobilisee.Size = new System.Drawing.Size(613, 156);
            this.dgvPompierMobilisee.TabIndex = 16;
            // 
            // dgvEngin
            // 
            this.dgvEngin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngin.Location = new System.Drawing.Point(12, 91);
            this.dgvEngin.Name = "dgvEngin";
            this.dgvEngin.RowHeadersWidth = 51;
            this.dgvEngin.RowTemplate.Height = 24;
            this.dgvEngin.Size = new System.Drawing.Size(462, 156);
            this.dgvEngin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pompier mobilisés";
            // 
            // lblEnginMobiliser
            // 
            this.lblEnginMobiliser.AutoSize = true;
            this.lblEnginMobiliser.Location = new System.Drawing.Point(163, 47);
            this.lblEnginMobiliser.Name = "lblEnginMobiliser";
            this.lblEnginMobiliser.Size = new System.Drawing.Size(185, 29);
            this.lblEnginMobiliser.TabIndex = 13;
            this.lblEnginMobiliser.Text = "Engin mobilisés";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.BackColor = System.Drawing.Color.Transparent;
            this.lblNumMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumMission.Location = new System.Drawing.Point(35, 30);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(118, 25);
            this.lblNumMission.TabIndex = 3;
            this.lblNumMission.Text = "Mission n°   ";
            // 
            // lblDateMission
            // 
            this.lblDateMission.AutoSize = true;
            this.lblDateMission.BackColor = System.Drawing.Color.Transparent;
            this.lblDateMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateMission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateMission.Location = new System.Drawing.Point(1154, 30);
            this.lblDateMission.Name = "lblDateMission";
            this.lblDateMission.Size = new System.Drawing.Size(149, 25);
            this.lblDateMission.TabIndex = 4;
            this.lblDateMission.Text = "déclenchée le : ";
            // 
            // btnValide
            // 
            this.btnValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValide.Location = new System.Drawing.Point(1177, 880);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(128, 56);
            this.btnValide.TabIndex = 5;
            this.btnValide.Text = "valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // btnConsulter
            // 
            this.btnConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(1015, 880);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(128, 56);
            this.btnConsulter.TabIndex = 6;
            this.btnConsulter.Text = "consulter";
            this.btnConsulter.UseVisualStyleBackColor = true;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitre.Location = new System.Drawing.Point(582, 51);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(350, 51);
            this.lblTitre.TabIndex = 7;
            this.lblTitre.Text = "Nouvelle Mission";
            // 
            // ucNewMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.lblDateMission);
            this.Controls.Add(this.lblNumMission);
            this.Controls.Add(this.grpMobilisationPompier);
            this.Controls.Add(this.grpRegulateur);
            this.Controls.Add(this.grpInfoUsage);
            this.Name = "ucNewMission";
            this.Size = new System.Drawing.Size(1530, 950);
            this.Load += new System.EventHandler(this.ucNewMission_Load);
            this.grpInfoUsage.ResumeLayout(false);
            this.grpInfoUsage.PerformLayout();
            this.grpRegulateur.ResumeLayout(false);
            this.grpRegulateur.PerformLayout();
            this.grpMobilisationPompier.ResumeLayout(false);
            this.grpMobilisationPompier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierMobilisee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoUsage;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRegulateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNatureSinistre;
        private System.Windows.Forms.ComboBox cboCaserneMobiliser;
        private System.Windows.Forms.ComboBox cboNatureSinistre;
        private System.Windows.Forms.GroupBox grpMobilisationPompier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnginMobiliser;
        private System.Windows.Forms.DataGridView dgvPompierMobilisee;
        private System.Windows.Forms.DataGridView dgvEngin;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDateMission;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Label lblTitre;
    }
}
