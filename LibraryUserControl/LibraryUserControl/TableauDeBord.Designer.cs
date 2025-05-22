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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMission = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.Location = new System.Drawing.Point(20, 23);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(98, 24);
            this.chkEnCours.TabIndex = 0;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            this.chkEnCours.CheckStateChanged += new System.EventHandler(this.chkEnCours_CheckStateChanged);
            // 
            // lblTabBord
            // 
            this.lblTabBord.AutoSize = true;
            this.lblTabBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabBord.Location = new System.Drawing.Point(666, 14);
            this.lblTabBord.Name = "lblTabBord";
            this.lblTabBord.Size = new System.Drawing.Size(221, 32);
            this.lblTabBord.TabIndex = 1;
            this.lblTabBord.Text = "Tableau de bord";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(-4, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 10);
            this.panel1.TabIndex = 2;
            // 
            // pnlMission
            // 
            this.pnlMission.AutoScroll = true;
            this.pnlMission.Location = new System.Drawing.Point(94, 103);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(1323, 737);
            this.pnlMission.TabIndex = 3;
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pnlMission);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTabBord);
            this.Controls.Add(this.chkEnCours);
            this.Name = "TableauDeBord";
            this.Size = new System.Drawing.Size(1530, 950);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Label lblTabBord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMission;
    }
}
