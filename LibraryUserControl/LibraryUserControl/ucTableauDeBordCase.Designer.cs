namespace LibraryUserControl
{
    partial class ucTableauDeBordCase
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
            this.pbMission = new System.Windows.Forms.PictureBox();
            this.lblIDMission = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblNomCaserne = new System.Windows.Forms.Label();
            this.lblCause = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMission)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMission
            // 
            this.pbMission.Location = new System.Drawing.Point(14, 20);
            this.pbMission.Name = "pbMission";
            this.pbMission.Size = new System.Drawing.Size(131, 135);
            this.pbMission.TabIndex = 1;
            this.pbMission.TabStop = false;
            // 
            // lblIDMission
            // 
            this.lblIDMission.AutoSize = true;
            this.lblIDMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMission.Location = new System.Drawing.Point(481, 20);
            this.lblIDMission.Name = "lblIDMission";
            this.lblIDMission.Size = new System.Drawing.Size(137, 29);
            this.lblIDMission.TabIndex = 1;
            this.lblIDMission.Text = "ID Mission :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(162, 49);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(89, 29);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Debut :";
            // 
            // lblNomCaserne
            // 
            this.lblNomCaserne.AutoSize = true;
            this.lblNomCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCaserne.Location = new System.Drawing.Point(162, 20);
            this.lblNomCaserne.Name = "lblNomCaserne";
            this.lblNomCaserne.Size = new System.Drawing.Size(116, 29);
            this.lblNomCaserne.TabIndex = 3;
            this.lblNomCaserne.Text = "Caserne :";
            // 
            // lblCause
            // 
            this.lblCause.AutoSize = true;
            this.lblCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCause.Location = new System.Drawing.Point(162, 87);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(82, 29);
            this.lblCause.TabIndex = 4;
            this.lblCause.Text = "Cause";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(185, 126);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(114, 29);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Précision";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.DarkGray;
            this.pnlInfo.Controls.Add(this.lblDesc);
            this.pnlInfo.Controls.Add(this.lblCause);
            this.pnlInfo.Controls.Add(this.lblNomCaserne);
            this.pnlInfo.Controls.Add(this.lblDebut);
            this.pnlInfo.Controls.Add(this.lblIDMission);
            this.pnlInfo.Controls.Add(this.pbMission);
            this.pnlInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(716, 189);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ucTableauDeBordCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pnlInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucTableauDeBordCase";
            this.Size = new System.Drawing.Size(722, 195);
            this.Load += new System.EventHandler(this.ucTableauDeBordCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMission)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMission;
        private System.Windows.Forms.Label lblIDMission;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblNomCaserne;
        private System.Windows.Forms.Label lblCause;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlInfo;
    }
}
