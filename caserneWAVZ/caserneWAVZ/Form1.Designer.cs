namespace caserneWAVZ
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.btnNewMission = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
=======
            this.ucTableauDeBordCase1 = new LibraryUserControl.ucTableauDeBordCase();
>>>>>>> d67f7f79ad0c27ba359ada8e0d3f2762613ca66c
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNewMission);
            this.panel1.Location = new System.Drawing.Point(12, 12);
=======
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> d67f7f79ad0c27ba359ada8e0d3f2762613ca66c
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 969);
            this.panel1.TabIndex = 0;
            // 
<<<<<<< HEAD
            // btnNewMission
            // 
            this.btnNewMission.Location = new System.Drawing.Point(20, 130);
            this.btnNewMission.Name = "btnNewMission";
            this.btnNewMission.Size = new System.Drawing.Size(208, 80);
            this.btnNewMission.TabIndex = 0;
            this.btnNewMission.Text = "Nouvelle Mission";
            this.btnNewMission.UseVisualStyleBackColor = true;
            this.btnNewMission.Click += new System.EventHandler(this.btnNewMission_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
            // ucTableauDeBordCase1
            // 
            this.ucTableauDeBordCase1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucTableauDeBordCase1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTableauDeBordCase1.Location = new System.Drawing.Point(327, 38);
            this.ucTableauDeBordCase1.Name = "ucTableauDeBordCase1";
            this.ucTableauDeBordCase1.Size = new System.Drawing.Size(722, 195);
            this.ucTableauDeBordCase1.TabIndex = 1;
>>>>>>> d67f7f79ad0c27ba359ada8e0d3f2762613ca66c
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1493, 838);
=======
            this.ClientSize = new System.Drawing.Size(1680, 999);
            this.Controls.Add(this.ucTableauDeBordCase1);
>>>>>>> d67f7f79ad0c27ba359ada8e0d3f2762613ca66c
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnNewMission;
        private System.Windows.Forms.Button button1;
=======
        private LibraryUserControl.ucTableauDeBordCase ucTableauDeBordCase1;
>>>>>>> d67f7f79ad0c27ba359ada8e0d3f2762613ca66c
    }
}

