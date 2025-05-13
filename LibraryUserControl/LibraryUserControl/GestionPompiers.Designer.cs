namespace LibraryUserControl
{
    partial class GestionPompiers
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
            this.grpLoginUtilisateur = new System.Windows.Forms.GroupBox();
            this.grpInfoNorm = new System.Windows.Forms.GroupBox();
            this.grpInfoExtend = new System.Windows.Forms.GroupBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblpompier = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.imgUtilisateur = new System.Windows.Forms.PictureBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.rdbProf = new System.Windows.Forms.RadioButton();
            this.rdbVol = new System.Windows.Forms.RadioButton();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.grpCarriere = new System.Windows.Forms.GroupBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnChangeCarriere = new System.Windows.Forms.Button();
            this.imgGrade = new System.Windows.Forms.PictureBox();
            this.btnExtendedInfo = new System.Windows.Forms.Button();
            this.grpInfoCarriere = new System.Windows.Forms.GroupBox();
            this.lblCaserneRattach = new System.Windows.Forms.Label();
            this.lblAffectationsPass = new System.Windows.Forms.Label();
            this.lblHabitations = new System.Windows.Forms.Label();
            this.cmbCaserenRattachement = new System.Windows.Forms.ComboBox();
            this.lsbHabitations = new System.Windows.Forms.ListBox();
            this.lsbAffectationPass = new System.Windows.Forms.ListBox();
            this.cmbCarriereGrade = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imgNewCompte = new System.Windows.Forms.PictureBox();
            this.lblNewCompte = new System.Windows.Forms.Label();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.lblRetour = new System.Windows.Forms.Label();
            this.grpLoginUtilisateur.SuspendLayout();
            this.grpInfoNorm.SuspendLayout();
            this.grpInfoExtend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUtilisateur)).BeginInit();
            this.grpCarriere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrade)).BeginInit();
            this.grpInfoCarriere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNewCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoginUtilisateur
            // 
            this.grpLoginUtilisateur.BackColor = System.Drawing.Color.DarkRed;
            this.grpLoginUtilisateur.Controls.Add(this.lblRetour);
            this.grpLoginUtilisateur.Controls.Add(this.imgExit);
            this.grpLoginUtilisateur.Controls.Add(this.lblNewCompte);
            this.grpLoginUtilisateur.Controls.Add(this.imgNewCompte);
            this.grpLoginUtilisateur.Controls.Add(this.imgUtilisateur);
            this.grpLoginUtilisateur.Controls.Add(this.comboBox2);
            this.grpLoginUtilisateur.Controls.Add(this.comboBox1);
            this.grpLoginUtilisateur.Controls.Add(this.lblpompier);
            this.grpLoginUtilisateur.Controls.Add(this.lblCaserne);
            this.grpLoginUtilisateur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpLoginUtilisateur.Location = new System.Drawing.Point(3, 3);
            this.grpLoginUtilisateur.Name = "grpLoginUtilisateur";
            this.grpLoginUtilisateur.Size = new System.Drawing.Size(524, 1072);
            this.grpLoginUtilisateur.TabIndex = 0;
            this.grpLoginUtilisateur.TabStop = false;
            // 
            // grpInfoNorm
            // 
            this.grpInfoNorm.Controls.Add(this.imgGrade);
            this.grpInfoNorm.Controls.Add(this.grpCarriere);
            this.grpInfoNorm.Controls.Add(this.lblDateEmbauche);
            this.grpInfoNorm.Controls.Add(this.rdbVol);
            this.grpInfoNorm.Controls.Add(this.rdbProf);
            this.grpInfoNorm.Controls.Add(this.lblPrenom);
            this.grpInfoNorm.Controls.Add(this.lblSexe);
            this.grpInfoNorm.Controls.Add(this.lblDateNaissance);
            this.grpInfoNorm.Controls.Add(this.lblNom);
            this.grpInfoNorm.Controls.Add(this.lblMatricule);
            this.grpInfoNorm.Location = new System.Drawing.Point(533, 0);
            this.grpInfoNorm.Name = "grpInfoNorm";
            this.grpInfoNorm.Size = new System.Drawing.Size(967, 493);
            this.grpInfoNorm.TabIndex = 1;
            this.grpInfoNorm.TabStop = false;
            // 
            // grpInfoExtend
            // 
            this.grpInfoExtend.Controls.Add(this.button1);
            this.grpInfoExtend.Controls.Add(this.checkBox1);
            this.grpInfoExtend.Controls.Add(this.grpInfoCarriere);
            this.grpInfoExtend.Location = new System.Drawing.Point(533, 526);
            this.grpInfoExtend.Name = "grpInfoExtend";
            this.grpInfoExtend.Size = new System.Drawing.Size(967, 546);
            this.grpInfoExtend.TabIndex = 2;
            this.grpInfoExtend.TabStop = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaserne.Location = new System.Drawing.Point(18, 235);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(348, 25);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Veuillez sélectionner une caserne :";
            // 
            // lblpompier
            // 
            this.lblpompier.AutoSize = true;
            this.lblpompier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpompier.Location = new System.Drawing.Point(18, 405);
            this.lblpompier.Name = "lblpompier";
            this.lblpompier.Size = new System.Drawing.Size(336, 25);
            this.lblpompier.TabIndex = 1;
            this.lblpompier.Text = "Veuillez sélectionner un pompier :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(485, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 457);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(485, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // imgUtilisateur
            // 
            this.imgUtilisateur.Location = new System.Drawing.Point(165, 30);
            this.imgUtilisateur.Name = "imgUtilisateur";
            this.imgUtilisateur.Size = new System.Drawing.Size(147, 138);
            this.imgUtilisateur.TabIndex = 4;
            this.imgUtilisateur.TabStop = false;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMatricule.Location = new System.Drawing.Point(454, 27);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(100, 25);
            this.lblMatricule.TabIndex = 1;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNom.Location = new System.Drawing.Point(6, 73);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(68, 25);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateNaissance.Location = new System.Drawing.Point(6, 199);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(203, 25);
            this.lblDateNaissance.TabIndex = 3;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSexe.Location = new System.Drawing.Point(6, 158);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(73, 25);
            this.lblSexe.TabIndex = 4;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrenom.Location = new System.Drawing.Point(6, 120);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(98, 25);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom :";
            // 
            // rdbProf
            // 
            this.rdbProf.AutoSize = true;
            this.rdbProf.Location = new System.Drawing.Point(23, 240);
            this.rdbProf.Name = "rdbProf";
            this.rdbProf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbProf.Size = new System.Drawing.Size(174, 29);
            this.rdbProf.TabIndex = 6;
            this.rdbProf.TabStop = true;
            this.rdbProf.Text = "Professionnel";
            this.rdbProf.UseVisualStyleBackColor = true;
            // 
            // rdbVol
            // 
            this.rdbVol.AutoSize = true;
            this.rdbVol.Location = new System.Drawing.Point(219, 240);
            this.rdbVol.Name = "rdbVol";
            this.rdbVol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbVol.Size = new System.Drawing.Size(140, 29);
            this.rdbVol.TabIndex = 7;
            this.rdbVol.TabStop = true;
            this.rdbVol.Text = "Volontaire";
            this.rdbVol.UseVisualStyleBackColor = true;
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateEmbauche.Location = new System.Drawing.Point(6, 291);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(191, 25);
            this.lblDateEmbauche.TabIndex = 8;
            this.lblDateEmbauche.Text = "Date d\'embauche :";
            // 
            // grpCarriere
            // 
            this.grpCarriere.Controls.Add(this.cmbCarriereGrade);
            this.grpCarriere.Controls.Add(this.btnChangeCarriere);
            this.grpCarriere.Controls.Add(this.txtGrade);
            this.grpCarriere.Controls.Add(this.lblGrade);
            this.grpCarriere.Controls.Add(this.lblBip);
            this.grpCarriere.Controls.Add(this.lblTelephone);
            this.grpCarriere.Location = new System.Drawing.Point(11, 344);
            this.grpCarriere.Name = "grpCarriere";
            this.grpCarriere.Size = new System.Drawing.Size(543, 125);
            this.grpCarriere.TabIndex = 9;
            this.grpCarriere.TabStop = false;
            this.grpCarriere.Text = "Carrière";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelephone.Location = new System.Drawing.Point(38, 87);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(126, 25);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBip.Location = new System.Drawing.Point(371, 87);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(55, 25);
            this.lblBip.TabIndex = 4;
            this.lblBip.Text = "Bip :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrade.Location = new System.Drawing.Point(38, 42);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(83, 25);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grade :";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(127, 39);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 31);
            this.txtGrade.TabIndex = 6;
            // 
            // btnChangeCarriere
            // 
            this.btnChangeCarriere.ForeColor = System.Drawing.Color.DarkRed;
            this.btnChangeCarriere.Location = new System.Drawing.Point(376, 35);
            this.btnChangeCarriere.Name = "btnChangeCarriere";
            this.btnChangeCarriere.Size = new System.Drawing.Size(127, 39);
            this.btnChangeCarriere.TabIndex = 7;
            this.btnChangeCarriere.Text = "Changer";
            this.btnChangeCarriere.UseVisualStyleBackColor = true;
            // 
            // imgGrade
            // 
            this.imgGrade.Location = new System.Drawing.Point(708, 73);
            this.imgGrade.Name = "imgGrade";
            this.imgGrade.Size = new System.Drawing.Size(161, 151);
            this.imgGrade.TabIndex = 5;
            this.imgGrade.TabStop = false;
            // 
            // btnExtendedInfo
            // 
            this.btnExtendedInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExtendedInfo.Location = new System.Drawing.Point(1200, 490);
            this.btnExtendedInfo.Name = "btnExtendedInfo";
            this.btnExtendedInfo.Size = new System.Drawing.Size(202, 60);
            this.btnExtendedInfo.TabIndex = 3;
            this.btnExtendedInfo.Text = "Plus d\'information";
            this.btnExtendedInfo.UseVisualStyleBackColor = true;
            this.btnExtendedInfo.Click += new System.EventHandler(this.btnExtendedInfo_Click);
            // 
            // grpInfoCarriere
            // 
            this.grpInfoCarriere.Controls.Add(this.lsbAffectationPass);
            this.grpInfoCarriere.Controls.Add(this.lsbHabitations);
            this.grpInfoCarriere.Controls.Add(this.cmbCaserenRattachement);
            this.grpInfoCarriere.Controls.Add(this.lblHabitations);
            this.grpInfoCarriere.Controls.Add(this.lblAffectationsPass);
            this.grpInfoCarriere.Controls.Add(this.lblCaserneRattach);
            this.grpInfoCarriere.Location = new System.Drawing.Point(11, 30);
            this.grpInfoCarriere.Name = "grpInfoCarriere";
            this.grpInfoCarriere.Size = new System.Drawing.Size(938, 431);
            this.grpInfoCarriere.TabIndex = 3;
            this.grpInfoCarriere.TabStop = false;
            this.grpInfoCarriere.Text = "Informations carrière";
            // 
            // lblCaserneRattach
            // 
            this.lblCaserneRattach.AutoSize = true;
            this.lblCaserneRattach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCaserneRattach.Location = new System.Drawing.Point(16, 49);
            this.lblCaserneRattach.Name = "lblCaserneRattach";
            this.lblCaserneRattach.Size = new System.Drawing.Size(266, 25);
            this.lblCaserneRattach.TabIndex = 4;
            this.lblCaserneRattach.Text = "Caserne de rattachement :";
            // 
            // lblAffectationsPass
            // 
            this.lblAffectationsPass.AutoSize = true;
            this.lblAffectationsPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAffectationsPass.Location = new System.Drawing.Point(16, 275);
            this.lblAffectationsPass.Name = "lblAffectationsPass";
            this.lblAffectationsPass.Size = new System.Drawing.Size(212, 25);
            this.lblAffectationsPass.TabIndex = 5;
            this.lblAffectationsPass.Text = "Affectations passées";
            // 
            // lblHabitations
            // 
            this.lblHabitations.AutoSize = true;
            this.lblHabitations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHabitations.Location = new System.Drawing.Point(16, 113);
            this.lblHabitations.Name = "lblHabitations";
            this.lblHabitations.Size = new System.Drawing.Size(130, 25);
            this.lblHabitations.TabIndex = 6;
            this.lblHabitations.Text = "Habilitations";
            // 
            // cmbCaserenRattachement
            // 
            this.cmbCaserenRattachement.FormattingEnabled = true;
            this.cmbCaserenRattachement.Location = new System.Drawing.Point(308, 46);
            this.cmbCaserenRattachement.Name = "cmbCaserenRattachement";
            this.cmbCaserenRattachement.Size = new System.Drawing.Size(282, 33);
            this.cmbCaserenRattachement.TabIndex = 7;
            // 
            // lsbHabitations
            // 
            this.lsbHabitations.FormattingEnabled = true;
            this.lsbHabitations.ItemHeight = 25;
            this.lsbHabitations.Location = new System.Drawing.Point(21, 160);
            this.lsbHabitations.Name = "lsbHabitations";
            this.lsbHabitations.Size = new System.Drawing.Size(569, 79);
            this.lsbHabitations.TabIndex = 8;
            // 
            // lsbAffectationPass
            // 
            this.lsbAffectationPass.FormattingEnabled = true;
            this.lsbAffectationPass.ItemHeight = 25;
            this.lsbAffectationPass.Location = new System.Drawing.Point(21, 318);
            this.lsbAffectationPass.Name = "lsbAffectationPass";
            this.lsbAffectationPass.Size = new System.Drawing.Size(569, 79);
            this.lsbAffectationPass.TabIndex = 9;
            // 
            // cmbCarriereGrade
            // 
            this.cmbCarriereGrade.FormattingEnabled = true;
            this.cmbCarriereGrade.Location = new System.Drawing.Point(243, 39);
            this.cmbCarriereGrade.Name = "cmbCarriereGrade";
            this.cmbCarriereGrade.Size = new System.Drawing.Size(111, 33);
            this.cmbCarriereGrade.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 494);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "En congé";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(708, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mettre à jour";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imgNewCompte
            // 
            this.imgNewCompte.Location = new System.Drawing.Point(23, 565);
            this.imgNewCompte.Name = "imgNewCompte";
            this.imgNewCompte.Size = new System.Drawing.Size(117, 107);
            this.imgNewCompte.TabIndex = 5;
            this.imgNewCompte.TabStop = false;
            // 
            // lblNewCompte
            // 
            this.lblNewCompte.AutoSize = true;
            this.lblNewCompte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewCompte.Location = new System.Drawing.Point(160, 607);
            this.lblNewCompte.Name = "lblNewCompte";
            this.lblNewCompte.Size = new System.Drawing.Size(98, 25);
            this.lblNewCompte.TabIndex = 6;
            this.lblNewCompte.Text = "Nouveau";
            // 
            // imgExit
            // 
            this.imgExit.Location = new System.Drawing.Point(23, 911);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(82, 73);
            this.imgExit.TabIndex = 7;
            this.imgExit.TabStop = false;
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRetour.Location = new System.Drawing.Point(123, 939);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(76, 25);
            this.lblRetour.TabIndex = 8;
            this.lblRetour.Text = "Retour";
            // 
            // GestionPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExtendedInfo);
            this.Controls.Add(this.grpInfoExtend);
            this.Controls.Add(this.grpInfoNorm);
            this.Controls.Add(this.grpLoginUtilisateur);
            this.Name = "GestionPompiers";
            this.Size = new System.Drawing.Size(1525, 1075);
            this.Load += new System.EventHandler(this.GestionPompiers_Load);
            this.grpLoginUtilisateur.ResumeLayout(false);
            this.grpLoginUtilisateur.PerformLayout();
            this.grpInfoNorm.ResumeLayout(false);
            this.grpInfoNorm.PerformLayout();
            this.grpInfoExtend.ResumeLayout(false);
            this.grpInfoExtend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUtilisateur)).EndInit();
            this.grpCarriere.ResumeLayout(false);
            this.grpCarriere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrade)).EndInit();
            this.grpInfoCarriere.ResumeLayout(false);
            this.grpInfoCarriere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNewCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginUtilisateur;
        private System.Windows.Forms.GroupBox grpInfoNorm;
        private System.Windows.Forms.GroupBox grpInfoExtend;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.PictureBox imgExit;
        private System.Windows.Forms.Label lblNewCompte;
        private System.Windows.Forms.PictureBox imgNewCompte;
        private System.Windows.Forms.PictureBox imgUtilisateur;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblpompier;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.PictureBox imgGrade;
        private System.Windows.Forms.GroupBox grpCarriere;
        private System.Windows.Forms.ComboBox cmbCarriereGrade;
        private System.Windows.Forms.Button btnChangeCarriere;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.RadioButton rdbVol;
        private System.Windows.Forms.RadioButton rdbProf;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpInfoCarriere;
        private System.Windows.Forms.ListBox lsbAffectationPass;
        private System.Windows.Forms.ListBox lsbHabitations;
        private System.Windows.Forms.ComboBox cmbCaserenRattachement;
        private System.Windows.Forms.Label lblHabitations;
        private System.Windows.Forms.Label lblAffectationsPass;
        private System.Windows.Forms.Label lblCaserneRattach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExtendedInfo;
    }
}
