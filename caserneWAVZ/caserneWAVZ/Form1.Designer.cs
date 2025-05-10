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
            this.ucTableauDeBordCase1 = new LibraryUserControl.ucTableauDeBordCase();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 969);
            this.panel1.TabIndex = 0;
            // 
            // ucTableauDeBordCase1
            // 
            this.ucTableauDeBordCase1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucTableauDeBordCase1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTableauDeBordCase1.Location = new System.Drawing.Point(327, 38);
            this.ucTableauDeBordCase1.Name = "ucTableauDeBordCase1";
            this.ucTableauDeBordCase1.Size = new System.Drawing.Size(722, 195);
            this.ucTableauDeBordCase1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1680, 999);
            this.Controls.Add(this.ucTableauDeBordCase1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LibraryUserControl.ucTableauDeBordCase ucTableauDeBordCase1;
    }
}

