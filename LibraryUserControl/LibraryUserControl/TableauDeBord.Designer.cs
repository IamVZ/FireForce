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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnCours
            // 
            this.chkEnCours.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.BackColor = System.Drawing.Color.Transparent;
            this.chkEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chkEnCours.Location = new System.Drawing.Point(24, 22);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(135, 42);
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
            this.lblTabBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabBord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTabBord.Location = new System.Drawing.Point(582, 39);
            this.lblTabBord.Name = "lblTabBord";
            this.lblTabBord.Size = new System.Drawing.Size(377, 54);
            this.lblTabBord.TabIndex = 1;
            this.lblTabBord.Text = "Tableau de bord";
            // 
            // pnlMission
            // 
            this.pnlMission.AutoScroll = true;
            this.pnlMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlMission.Location = new System.Drawing.Point(46, 157);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(1440, 754);
            this.pnlMission.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTabBord);
            this.panel1.Controls.Add(this.chkEnCours);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1530, 133);
            this.panel1.TabIndex = 4;
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMission);
            this.DoubleBuffered = true;
            this.Name = "TableauDeBord";
            this.Size = new System.Drawing.Size(1530, 950);
            this.Load += new System.EventHandler(this.TableauDeBord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Label lblTabBord;
        private System.Windows.Forms.Panel pnlMission;
        private System.Windows.Forms.Panel panel1;
    }
}
