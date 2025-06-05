namespace LibraryUserControl
{
    partial class ucStatistique
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
            this.lblStat = new System.Windows.Forms.Label();
            this.tabCStat = new System.Windows.Forms.TabControl();
            this.tabParCaserne = new System.Windows.Forms.TabPage();
            this.lblTitre1 = new System.Windows.Forms.Label();
            this.pnlHeure = new System.Windows.Forms.Panel();
            this.pnlEnginplus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEngin = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.tabGlobal = new System.Windows.Forms.TabPage();
            this.pnlListePompier = new System.Windows.Forms.Panel();
            this.cbxHabilitation = new System.Windows.Forms.ComboBox();
            this.lblListePompier = new System.Windows.Forms.Label();
            this.lblResHabilitation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlIntervention = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreInterv = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.tabCStat.SuspendLayout();
            this.tabParCaserne.SuspendLayout();
            this.tabGlobal.SuspendLayout();
            this.pnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.BackColor = System.Drawing.Color.Transparent;
            this.lblStat.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblStat.Location = new System.Drawing.Point(582, 39);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(260, 62);
            this.lblStat.TabIndex = 0;
            this.lblStat.Text = "Statistique";
            // 
            // tabCStat
            // 
            this.tabCStat.Controls.Add(this.tabParCaserne);
            this.tabCStat.Controls.Add(this.tabGlobal);
            this.tabCStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCStat.Location = new System.Drawing.Point(35, 164);
            this.tabCStat.Name = "tabCStat";
            this.tabCStat.SelectedIndex = 0;
            this.tabCStat.Size = new System.Drawing.Size(1476, 760);
            this.tabCStat.TabIndex = 1;
            // 
            // tabParCaserne
            // 
            this.tabParCaserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabParCaserne.Controls.Add(this.lblTitre1);
            this.tabParCaserne.Controls.Add(this.pnlHeure);
            this.tabParCaserne.Controls.Add(this.pnlEnginplus);
            this.tabParCaserne.Controls.Add(this.label1);
            this.tabParCaserne.Controls.Add(this.LblEngin);
            this.tabParCaserne.Controls.Add(this.lblCaserne);
            this.tabParCaserne.Controls.Add(this.cbxCaserne);
            this.tabParCaserne.Location = new System.Drawing.Point(4, 40);
            this.tabParCaserne.Name = "tabParCaserne";
            this.tabParCaserne.Padding = new System.Windows.Forms.Padding(3);
            this.tabParCaserne.Size = new System.Drawing.Size(1468, 716);
            this.tabParCaserne.TabIndex = 0;
            this.tabParCaserne.Text = "Statistique par caserne";
            // 
            // lblTitre1
            // 
            this.lblTitre1.AutoSize = true;
            this.lblTitre1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitre1.Location = new System.Drawing.Point(556, 39);
            this.lblTitre1.Name = "lblTitre1";
            this.lblTitre1.Size = new System.Drawing.Size(314, 38);
            this.lblTitre1.TabIndex = 6;
            this.lblTitre1.Text = "Statistique par caserne";
            // 
            // pnlHeure
            // 
            this.pnlHeure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeure.Location = new System.Drawing.Point(801, 268);
            this.pnlHeure.Name = "pnlHeure";
            this.pnlHeure.Size = new System.Drawing.Size(571, 428);
            this.pnlHeure.TabIndex = 5;
            // 
            // pnlEnginplus
            // 
            this.pnlEnginplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlEnginplus.Location = new System.Drawing.Point(86, 268);
            this.pnlEnginplus.Name = "pnlEnginplus";
            this.pnlEnginplus.Size = new System.Drawing.Size(571, 428);
            this.pnlEnginplus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(794, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE TOTAL D\'HEURE D\'UTILISATION :";
            // 
            // LblEngin
            // 
            this.LblEngin.AutoSize = true;
            this.LblEngin.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEngin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LblEngin.Location = new System.Drawing.Point(126, 206);
            this.LblEngin.Name = "LblEngin";
            this.LblEngin.Size = new System.Drawing.Size(395, 38);
            this.LblEngin.TabIndex = 2;
            this.LblEngin.Text = "ENGINS LES PLUS UTILISÉS  :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCaserne.Location = new System.Drawing.Point(327, 117);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(326, 37);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Selectionnez une caserne :";
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaserne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(692, 121);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(342, 36);
            this.cbxCaserne.TabIndex = 0;
            this.cbxCaserne.SelectedValueChanged += new System.EventHandler(this.cbxCaserne_SelectedValueChanged);
            // 
            // tabGlobal
            // 
            this.tabGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.tabGlobal.Controls.Add(this.pnlListePompier);
            this.tabGlobal.Controls.Add(this.cbxHabilitation);
            this.tabGlobal.Controls.Add(this.lblListePompier);
            this.tabGlobal.Controls.Add(this.lblResHabilitation);
            this.tabGlobal.Controls.Add(this.label3);
            this.tabGlobal.Controls.Add(this.pnlIntervention);
            this.tabGlobal.Controls.Add(this.label2);
            this.tabGlobal.Controls.Add(this.lblNombreInterv);
            this.tabGlobal.Location = new System.Drawing.Point(4, 40);
            this.tabGlobal.Name = "tabGlobal";
            this.tabGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tabGlobal.Size = new System.Drawing.Size(1468, 716);
            this.tabGlobal.TabIndex = 1;
            this.tabGlobal.Text = "Statistique global";
            // 
            // pnlListePompier
            // 
            this.pnlListePompier.AutoScroll = true;
            this.pnlListePompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlListePompier.Location = new System.Drawing.Point(22, 485);
            this.pnlListePompier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlListePompier.Name = "pnlListePompier";
            this.pnlListePompier.Size = new System.Drawing.Size(1418, 220);
            this.pnlListePompier.TabIndex = 14;
            // 
            // cbxHabilitation
            // 
            this.cbxHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHabilitation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHabilitation.FormattingEnabled = true;
            this.cbxHabilitation.Location = new System.Drawing.Point(660, 432);
            this.cbxHabilitation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHabilitation.Name = "cbxHabilitation";
            this.cbxHabilitation.Size = new System.Drawing.Size(445, 36);
            this.cbxHabilitation.TabIndex = 13;
            this.cbxHabilitation.SelectedValueChanged += new System.EventHandler(this.cbxHabilitation_SelectedValueChanged);
            // 
            // lblListePompier
            // 
            this.lblListePompier.AutoSize = true;
            this.lblListePompier.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePompier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblListePompier.Location = new System.Drawing.Point(110, 426);
            this.lblListePompier.Name = "lblListePompier";
            this.lblListePompier.Size = new System.Drawing.Size(487, 38);
            this.lblListePompier.TabIndex = 11;
            this.lblListePompier.Text = "Liste des pompiers par habilitation :";
            // 
            // lblResHabilitation
            // 
            this.lblResHabilitation.AutoSize = true;
            this.lblResHabilitation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResHabilitation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResHabilitation.Location = new System.Drawing.Point(741, 365);
            this.lblResHabilitation.Name = "lblResHabilitation";
            this.lblResHabilitation.Size = new System.Drawing.Size(111, 37);
            this.lblResHabilitation.TabIndex = 10;
            this.lblResHabilitation.Text = "Résultat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(201, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "HABILITATION LA PLUS SOLLICITEES :";
            // 
            // pnlIntervention
            // 
            this.pnlIntervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlIntervention.Location = new System.Drawing.Point(22, 138);
            this.pnlIntervention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIntervention.Name = "pnlIntervention";
            this.pnlIntervention.Size = new System.Drawing.Size(1428, 210);
            this.pnlIntervention.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(586, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Statistique global";
            // 
            // lblNombreInterv
            // 
            this.lblNombreInterv.AutoSize = true;
            this.lblNombreInterv.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInterv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblNombreInterv.Location = new System.Drawing.Point(361, 87);
            this.lblNombreInterv.Name = "lblNombreInterv";
            this.lblNombreInterv.Size = new System.Drawing.Size(711, 38);
            this.lblNombreInterv.TabIndex = 3;
            this.lblNombreInterv.Text = "NOMBRE D\'INTERVENTION PAR TYPE DE SINISTRE : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1529, 402);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 80);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTitre.Controls.Add(this.lblStat);
            this.pnlTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlTitre.Location = new System.Drawing.Point(0, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1530, 133);
            this.pnlTitre.TabIndex = 0;
            // 
            // ucStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabCStat);
            this.DoubleBuffered = true;
            this.Name = "ucStatistique";
            this.Size = new System.Drawing.Size(1530, 950);
            this.Load += new System.EventHandler(this.ucStatistique_Load);
            this.tabCStat.ResumeLayout(false);
            this.tabParCaserne.ResumeLayout(false);
            this.tabParCaserne.PerformLayout();
            this.tabGlobal.ResumeLayout(false);
            this.tabGlobal.PerformLayout();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.TabPage tabParCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.TabPage tabGlobal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEngin;
        private System.Windows.Forms.Panel pnlHeure;
        private System.Windows.Forms.Panel pnlEnginplus;
        private System.Windows.Forms.Label lblNombreInterv;
        private System.Windows.Forms.Label lblTitre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlIntervention;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblListePompier;
        private System.Windows.Forms.Label lblResHabilitation;
        private System.Windows.Forms.Panel pnlListePompier;
        private System.Windows.Forms.ComboBox cbxHabilitation;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.TabControl tabCStat;
    }
}
