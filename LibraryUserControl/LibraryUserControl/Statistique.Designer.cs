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
            this.tabCStat.SuspendLayout();
            this.tabParCaserne.SuspendLayout();
            this.tabGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.BackColor = System.Drawing.Color.Transparent;
            this.lblStat.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStat.Location = new System.Drawing.Point(703, 30);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(290, 70);
            this.lblStat.TabIndex = 0;
            this.lblStat.Text = "Statistique";
            // 
            // tabCStat
            // 
            this.tabCStat.Controls.Add(this.tabParCaserne);
            this.tabCStat.Controls.Add(this.tabGlobal);
            this.tabCStat.Location = new System.Drawing.Point(39, 104);
            this.tabCStat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCStat.Name = "tabCStat";
            this.tabCStat.SelectedIndex = 0;
            this.tabCStat.Size = new System.Drawing.Size(1660, 1051);
            this.tabCStat.TabIndex = 1;
            // 
            // tabParCaserne
            // 
            this.tabParCaserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabParCaserne.Controls.Add(this.lblTitre1);
            this.tabParCaserne.Controls.Add(this.pnlHeure);
            this.tabParCaserne.Controls.Add(this.pnlEnginplus);
            this.tabParCaserne.Controls.Add(this.label1);
            this.tabParCaserne.Controls.Add(this.LblEngin);
            this.tabParCaserne.Controls.Add(this.lblCaserne);
            this.tabParCaserne.Controls.Add(this.cbxCaserne);
            this.tabParCaserne.Location = new System.Drawing.Point(4, 29);
            this.tabParCaserne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabParCaserne.Name = "tabParCaserne";
            this.tabParCaserne.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabParCaserne.Size = new System.Drawing.Size(1652, 1018);
            this.tabParCaserne.TabIndex = 0;
            this.tabParCaserne.Text = "Statistique par caserne";
            // 
            // lblTitre1
            // 
            this.lblTitre1.AutoSize = true;
            this.lblTitre1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitre1.Location = new System.Drawing.Point(625, 49);
            this.lblTitre1.Name = "lblTitre1";
            this.lblTitre1.Size = new System.Drawing.Size(373, 45);
            this.lblTitre1.TabIndex = 6;
            this.lblTitre1.Text = "Statistique par caserne";
            // 
            // pnlHeure
            // 
            this.pnlHeure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeure.Location = new System.Drawing.Point(901, 335);
            this.pnlHeure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeure.Name = "pnlHeure";
            this.pnlHeure.Size = new System.Drawing.Size(642, 626);
            this.pnlHeure.TabIndex = 5;
            // 
            // pnlEnginplus
            // 
            this.pnlEnginplus.Location = new System.Drawing.Point(97, 335);
            this.pnlEnginplus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEnginplus.Name = "pnlEnginplus";
            this.pnlEnginplus.Size = new System.Drawing.Size(579, 626);
            this.pnlEnginplus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(893, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE TOTAL D\'HEURE D\'UTILISATION :";
            // 
            // LblEngin
            // 
            this.LblEngin.AutoSize = true;
            this.LblEngin.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEngin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblEngin.Location = new System.Drawing.Point(142, 258);
            this.LblEngin.Name = "LblEngin";
            this.LblEngin.Size = new System.Drawing.Size(465, 45);
            this.LblEngin.TabIndex = 2;
            this.LblEngin.Text = "ENGINS LES PLUS UTILISÉS  :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaserne.Location = new System.Drawing.Point(368, 146);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(394, 45);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Selectionnez une caserne :";
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaserne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(778, 151);
            this.cbxCaserne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(384, 40);
            this.cbxCaserne.TabIndex = 0;
            this.cbxCaserne.SelectedValueChanged += new System.EventHandler(this.cbxCaserne_SelectedValueChanged);
            // 
            // tabGlobal
            // 
            this.tabGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabGlobal.Controls.Add(this.pnlListePompier);
            this.tabGlobal.Controls.Add(this.cbxHabilitation);
            this.tabGlobal.Controls.Add(this.lblListePompier);
            this.tabGlobal.Controls.Add(this.lblResHabilitation);
            this.tabGlobal.Controls.Add(this.label3);
            this.tabGlobal.Controls.Add(this.pnlIntervention);
            this.tabGlobal.Controls.Add(this.label2);
            this.tabGlobal.Controls.Add(this.lblNombreInterv);
            this.tabGlobal.Location = new System.Drawing.Point(4, 29);
            this.tabGlobal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGlobal.Name = "tabGlobal";
            this.tabGlobal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGlobal.Size = new System.Drawing.Size(1652, 1018);
            this.tabGlobal.TabIndex = 1;
            this.tabGlobal.Text = "Statistique global";
            // 
            // pnlListePompier
            // 
            this.pnlListePompier.AutoScroll = true;
            this.pnlListePompier.Location = new System.Drawing.Point(25, 606);
            this.pnlListePompier.Name = "pnlListePompier";
            this.pnlListePompier.Size = new System.Drawing.Size(1595, 392);
            this.pnlListePompier.TabIndex = 14;
            // 
            // cbxHabilitation
            // 
            this.cbxHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHabilitation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHabilitation.FormattingEnabled = true;
            this.cbxHabilitation.Location = new System.Drawing.Point(743, 540);
            this.cbxHabilitation.Name = "cbxHabilitation";
            this.cbxHabilitation.Size = new System.Drawing.Size(500, 40);
            this.cbxHabilitation.TabIndex = 13;
            this.cbxHabilitation.SelectedValueChanged += new System.EventHandler(this.cbxHabilitation_SelectedValueChanged);
            // 
            // lblListePompier
            // 
            this.lblListePompier.AutoSize = true;
            this.lblListePompier.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePompier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListePompier.Location = new System.Drawing.Point(124, 533);
            this.lblListePompier.Name = "lblListePompier";
            this.lblListePompier.Size = new System.Drawing.Size(573, 45);
            this.lblListePompier.TabIndex = 11;
            this.lblListePompier.Text = "Liste des pompiers par habilitation :";
            // 
            // lblResHabilitation
            // 
            this.lblResHabilitation.AutoSize = true;
            this.lblResHabilitation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResHabilitation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResHabilitation.Location = new System.Drawing.Point(834, 456);
            this.lblResHabilitation.Name = "lblResHabilitation";
            this.lblResHabilitation.Size = new System.Drawing.Size(133, 45);
            this.lblResHabilitation.TabIndex = 10;
            this.lblResHabilitation.Text = "Résultat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(226, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "HABILITATION LA PLUS SOLLICITEES :";
            // 
            // pnlIntervention
            // 
            this.pnlIntervention.Location = new System.Drawing.Point(25, 172);
            this.pnlIntervention.Name = "pnlIntervention";
            this.pnlIntervention.Size = new System.Drawing.Size(1607, 245);
            this.pnlIntervention.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(659, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Statistique global";
            // 
            // lblNombreInterv
            // 
            this.lblNombreInterv.AutoSize = true;
            this.lblNombreInterv.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInterv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreInterv.Location = new System.Drawing.Point(406, 109);
            this.lblNombreInterv.Name = "lblNombreInterv";
            this.lblNombreInterv.Size = new System.Drawing.Size(837, 45);
            this.lblNombreInterv.TabIndex = 3;
            this.lblNombreInterv.Text = "NOMBRE D\'INTERVENTION PAR TYPE DE SINISTRE : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1720, 502);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ucStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabCStat);
            this.Controls.Add(this.lblStat);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucStatistique";
            this.Size = new System.Drawing.Size(1721, 1188);
            this.tabCStat.ResumeLayout(false);
            this.tabParCaserne.ResumeLayout(false);
            this.tabParCaserne.PerformLayout();
            this.tabGlobal.ResumeLayout(false);
            this.tabGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.TabControl tabCStat;
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
    }
}
