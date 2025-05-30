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
            this.btnEngin = new System.Windows.Forms.Button();
            this.btnTab1 = new System.Windows.Forms.Button();
            this.btnNewMission = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnEngin);
            this.panel1.Controls.Add(this.btnTab1);
            this.panel1.Controls.Add(this.btnNewMission);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 950);
            this.panel1.TabIndex = 0;
            // 
            // btnEngin
            // 
            this.btnEngin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEngin.FlatAppearance.BorderSize = 0;
            this.btnEngin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEngin.Location = new System.Drawing.Point(3, 212);
            this.btnEngin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEngin.Name = "btnEngin";
            this.btnEngin.Size = new System.Drawing.Size(344, 69);
            this.btnEngin.TabIndex = 2;
            this.btnEngin.Text = "Engin";
            this.btnEngin.UseVisualStyleBackColor = false;
            this.btnEngin.Click += new System.EventHandler(this.btnEngin_Click);
            this.btnEngin.MouseEnter += new System.EventHandler(this.btnTab1_MouseEnter);
            this.btnEngin.MouseLeave += new System.EventHandler(this.btnTab1_MouseLeave);
            // 
            // btnTab1
            // 
            this.btnTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTab1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTab1.FlatAppearance.BorderSize = 0;
            this.btnTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTab1.Location = new System.Drawing.Point(3, 70);
            this.btnTab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTab1.Name = "btnTab1";
            this.btnTab1.Size = new System.Drawing.Size(344, 65);
            this.btnTab1.TabIndex = 1;
            this.btnTab1.Text = "Tableau de bord";
            this.btnTab1.UseVisualStyleBackColor = false;
            this.btnTab1.Click += new System.EventHandler(this.btnTab_Click_1);
            this.btnTab1.MouseEnter += new System.EventHandler(this.btnTab1_MouseEnter);
            this.btnTab1.MouseLeave += new System.EventHandler(this.btnTab1_MouseLeave);
            // 
            // btnNewMission
            // 
            this.btnNewMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewMission.FlatAppearance.BorderSize = 0;
            this.btnNewMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNewMission.Location = new System.Drawing.Point(3, 139);
            this.btnNewMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewMission.Name = "btnNewMission";
            this.btnNewMission.Size = new System.Drawing.Size(344, 69);
            this.btnNewMission.TabIndex = 0;
            this.btnNewMission.Text = "Nouvelle Mission";
            this.btnNewMission.UseVisualStyleBackColor = false;
            this.btnNewMission.Click += new System.EventHandler(this.btnNewMission_Click);
            this.btnNewMission.MouseEnter += new System.EventHandler(this.btnTab1_MouseEnter);
            this.btnNewMission.MouseLeave += new System.EventHandler(this.btnTab1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::caserneWAVZ.Properties.Resources.fond2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1710, 799);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button btnNewMission;
        private System.Windows.Forms.Button btnTab1;
        private System.Windows.Forms.Button btnEngin;
    }
}

