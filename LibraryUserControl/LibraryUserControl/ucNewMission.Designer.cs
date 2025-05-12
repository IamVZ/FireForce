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
            this.grpInfoUsage.SuspendLayout();
            this.grpRegulateur.SuspendLayout();
            this.grpMobilisationPompier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierMobilisee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfoUsage
            // 
            this.grpInfoUsage.Controls.Add(this.label1);
            this.grpInfoUsage.Controls.Add(this.lblMotif);
            this.grpInfoUsage.Controls.Add(this.txtMotif);
            this.grpInfoUsage.Controls.Add(this.lblVille);
            this.grpInfoUsage.Controls.Add(this.lblCP);
            this.grpInfoUsage.Controls.Add(this.lblRue);
            this.grpInfoUsage.Controls.Add(this.txtVille);
            this.grpInfoUsage.Controls.Add(this.txtCP);
            this.grpInfoUsage.Controls.Add(this.txtRue);
            this.grpInfoUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoUsage.Location = new System.Drawing.Point(49, 94);
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
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adresse sinistre";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(208, 54);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(54, 25);
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
            this.lblVille.Size = new System.Drawing.Size(60, 25);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(509, 147);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(133, 25);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Code postal : ";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(509, 100);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(63, 25);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue : ";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(663, 187);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(370, 30);
            this.txtVille.TabIndex = 2;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(663, 142);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(370, 30);
            this.txtCP.TabIndex = 1;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(663, 95);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(370, 30);
            this.txtRue.TabIndex = 0;
            // 
            // grpRegulateur
            // 
            this.grpRegulateur.Controls.Add(this.cboCaserneMobiliser);
            this.grpRegulateur.Controls.Add(this.cboNatureSinistre);
            this.grpRegulateur.Controls.Add(this.label2);
            this.grpRegulateur.Controls.Add(this.lblNatureSinistre);
            this.grpRegulateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegulateur.Location = new System.Drawing.Point(49, 376);
            this.grpRegulateur.Name = "grpRegulateur";
            this.grpRegulateur.Size = new System.Drawing.Size(1104, 139);
            this.grpRegulateur.TabIndex = 1;
            this.grpRegulateur.TabStop = false;
            this.grpRegulateur.Text = "Décisions du régulateur";
            // 
            // cboCaserneMobiliser
            // 
            this.cboCaserneMobiliser.FormattingEnabled = true;
            this.cboCaserneMobiliser.Location = new System.Drawing.Point(678, 52);
            this.cboCaserneMobiliser.Name = "cboCaserneMobiliser";
            this.cboCaserneMobiliser.Size = new System.Drawing.Size(222, 33);
            this.cboCaserneMobiliser.TabIndex = 12;
            this.cboCaserneMobiliser.SelectedIndexChanged += new System.EventHandler(this.cboCaserneMobiliser_SelectedIndexChanged);
            // 
            // cboNatureSinistre
            // 
            this.cboNatureSinistre.FormattingEnabled = true;
            this.cboNatureSinistre.Location = new System.Drawing.Point(228, 49);
            this.cboNatureSinistre.Name = "cboNatureSinistre";
            this.cboNatureSinistre.Size = new System.Drawing.Size(222, 33);
            this.cboNatureSinistre.TabIndex = 11;
            this.cboNatureSinistre.SelectedIndexChanged += new System.EventHandler(this.cboNatureSinistre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Caserne à mobiliser";
            // 
            // lblNatureSinistre
            // 
            this.lblNatureSinistre.AutoSize = true;
            this.lblNatureSinistre.Location = new System.Drawing.Point(38, 52);
            this.lblNatureSinistre.Name = "lblNatureSinistre";
            this.lblNatureSinistre.Size = new System.Drawing.Size(163, 25);
            this.lblNatureSinistre.TabIndex = 9;
            this.lblNatureSinistre.Text = "Nature du sinistre";
            // 
            // grpMobilisationPompier
            // 
            this.grpMobilisationPompier.Controls.Add(this.dgvPompierMobilisee);
            this.grpMobilisationPompier.Controls.Add(this.dgvEngin);
            this.grpMobilisationPompier.Controls.Add(this.label4);
            this.grpMobilisationPompier.Controls.Add(this.lblEnginMobiliser);
            this.grpMobilisationPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMobilisationPompier.Location = new System.Drawing.Point(49, 529);
            this.grpMobilisationPompier.Name = "grpMobilisationPompier";
            this.grpMobilisationPompier.Size = new System.Drawing.Size(1103, 263);
            this.grpMobilisationPompier.TabIndex = 2;
            this.grpMobilisationPompier.TabStop = false;
            this.grpMobilisationPompier.Text = "Mobilisation des engins et des pompiers";
            // 
            // dgvPompierMobilisee
            // 
            this.dgvPompierMobilisee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompierMobilisee.Location = new System.Drawing.Point(515, 91);
            this.dgvPompierMobilisee.Name = "dgvPompierMobilisee";
            this.dgvPompierMobilisee.RowHeadersWidth = 51;
            this.dgvPompierMobilisee.RowTemplate.Height = 24;
            this.dgvPompierMobilisee.Size = new System.Drawing.Size(402, 156);
            this.dgvPompierMobilisee.TabIndex = 16;
            // 
            // dgvEngin
            // 
            this.dgvEngin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngin.Location = new System.Drawing.Point(36, 91);
            this.dgvEngin.Name = "dgvEngin";
            this.dgvEngin.RowHeadersWidth = 51;
            this.dgvEngin.RowTemplate.Height = 24;
            this.dgvEngin.Size = new System.Drawing.Size(402, 156);
            this.dgvEngin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pompier mobilisés";
            // 
            // lblEnginMobiliser
            // 
            this.lblEnginMobiliser.AutoSize = true;
            this.lblEnginMobiliser.Location = new System.Drawing.Point(161, 47);
            this.lblEnginMobiliser.Name = "lblEnginMobiliser";
            this.lblEnginMobiliser.Size = new System.Drawing.Size(148, 25);
            this.lblEnginMobiliser.TabIndex = 13;
            this.lblEnginMobiliser.Text = "Engin mobilisés";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMission.Location = new System.Drawing.Point(121, 30);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(118, 25);
            this.lblNumMission.TabIndex = 3;
            this.lblNumMission.Text = "Mission n°   ";
            // 
            // lblDateMission
            // 
            this.lblDateMission.AutoSize = true;
            this.lblDateMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateMission.Location = new System.Drawing.Point(638, 30);
            this.lblDateMission.Name = "lblDateMission";
            this.lblDateMission.Size = new System.Drawing.Size(149, 25);
            this.lblDateMission.TabIndex = 4;
            this.lblDateMission.Text = "déclenchée le : ";
            // 
            // btnValide
            // 
            this.btnValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValide.Location = new System.Drawing.Point(853, 820);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(128, 56);
            this.btnValide.TabIndex = 5;
            this.btnValide.Text = "valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // ucNewMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.lblDateMission);
            this.Controls.Add(this.lblNumMission);
            this.Controls.Add(this.grpMobilisationPompier);
            this.Controls.Add(this.grpRegulateur);
            this.Controls.Add(this.grpInfoUsage);
            this.Name = "ucNewMission";
            this.Size = new System.Drawing.Size(1212, 895);
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
    }
}
