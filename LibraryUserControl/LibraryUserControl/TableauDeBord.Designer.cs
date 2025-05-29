namespace LibraryUserControl
{
    partial class TableauDeBord
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
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.lblTabBord = new System.Windows.Forms.Label();
            this.pnlMission = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.BackColor = System.Drawing.Color.Transparent;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEnCours.Location = new System.Drawing.Point(34, 38);
            this.chkEnCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(123, 29);
            this.chkEnCours.TabIndex = 0;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = false;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            this.chkEnCours.CheckStateChanged += new System.EventHandler(this.chkEnCours_CheckStateChanged);
            // 
            // lblTabBord
            // 
            this.lblTabBord.AutoSize = true;
            this.lblTabBord.BackColor = System.Drawing.Color.Transparent;
            this.lblTabBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabBord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabBord.Location = new System.Drawing.Point(676, 28);
            this.lblTabBord.Name = "lblTabBord";
            this.lblTabBord.Size = new System.Drawing.Size(294, 40);
            this.lblTabBord.TabIndex = 1;
            this.lblTabBord.Text = "Tableau de bord";
            // 
            // pnlMission
            // 
            this.pnlMission.AutoScroll = true;
            this.pnlMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlMission.Location = new System.Drawing.Point(52, 95);
            this.pnlMission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(1620, 1044);
            this.pnlMission.TabIndex = 3;
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.Controls.Add(this.pnlMission);
            this.Controls.Add(this.lblTabBord);
            this.Controls.Add(this.chkEnCours);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableauDeBord";
            this.Size = new System.Drawing.Size(1721, 1188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Label lblTabBord;
        private System.Windows.Forms.Panel pnlMission;
    }
}
