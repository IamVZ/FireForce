namespace LibraryUserControl
{
    partial class ucGestionPersonnel
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
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.btnDeconexion = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlinfoPompier = new System.Windows.Forms.Panel();
            this.lblMat = new System.Windows.Forms.Label();
            this.pbImgGrade = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCarriere = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChangerGrade = new System.Windows.Forms.Button();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.pnlCarriere = new System.Windows.Forms.Panel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnMettreAJour = new System.Windows.Forms.Button();
            this.lsbAffectationPassees = new System.Windows.Forms.ListBox();
            this.lsbHabilitation = new System.Windows.Forms.ListBox();
            this.cboAffectation = new System.Windows.Forms.ComboBox();
            this.lblAffectationPassees = new System.Windows.Forms.Label();
            this.lblHabilitation = new System.Windows.Forms.Label();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblCarriere = new System.Windows.Forms.Label();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.lblChoixPompier = new System.Windows.Forms.Label();
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.cboChoixPompier = new System.Windows.Forms.ComboBox();
            this.btnNouveauPompier = new System.Windows.Forms.Button();
            this.btnPlusInfo = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLoginTitre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.pnlTitre.SuspendLayout();
            this.pnlinfoPompier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgGrade)).BeginInit();
            this.grpCarriere.SuspendLayout();
            this.pnlCarriere.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTitre.Controls.Add(this.btnDeconexion);
            this.pnlTitre.Controls.Add(this.lblTitre);
            this.pnlTitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTitre.Location = new System.Drawing.Point(0, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1530, 133);
            this.pnlTitre.TabIndex = 2;
            // 
            // btnDeconexion
            // 
            this.btnDeconexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeconexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeconexion.Location = new System.Drawing.Point(1257, 39);
            this.btnDeconexion.Name = "btnDeconexion";
            this.btnDeconexion.Size = new System.Drawing.Size(250, 53);
            this.btnDeconexion.TabIndex = 17;
            this.btnDeconexion.Text = "Se Déconecter";
            this.btnDeconexion.UseVisualStyleBackColor = false;
            this.btnDeconexion.Click += new System.EventHandler(this.bntDeconexion_Click);
            this.btnDeconexion.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnDeconexion.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitre.Location = new System.Drawing.Point(582, 39);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(467, 54);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion du personnel";
            // 
            // pnlinfoPompier
            // 
            this.pnlinfoPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlinfoPompier.Controls.Add(this.lblMat);
            this.pnlinfoPompier.Controls.Add(this.pbImgGrade);
            this.pnlinfoPompier.Controls.Add(this.label6);
            this.pnlinfoPompier.Controls.Add(this.label5);
            this.pnlinfoPompier.Controls.Add(this.label4);
            this.pnlinfoPompier.Controls.Add(this.label3);
            this.pnlinfoPompier.Controls.Add(this.label2);
            this.pnlinfoPompier.Controls.Add(this.label1);
            this.pnlinfoPompier.Controls.Add(this.grpCarriere);
            this.pnlinfoPompier.Controls.Add(this.lblDateEmbauche);
            this.pnlinfoPompier.Controls.Add(this.lblType);
            this.pnlinfoPompier.Controls.Add(this.lblDateNaissance);
            this.pnlinfoPompier.Controls.Add(this.lblSexe);
            this.pnlinfoPompier.Controls.Add(this.lblPrenom);
            this.pnlinfoPompier.Controls.Add(this.lblNom);
            this.pnlinfoPompier.Controls.Add(this.lblMatricule);
            this.pnlinfoPompier.Location = new System.Drawing.Point(16, 340);
            this.pnlinfoPompier.Name = "pnlinfoPompier";
            this.pnlinfoPompier.Size = new System.Drawing.Size(718, 580);
            this.pnlinfoPompier.TabIndex = 3;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMat.Location = new System.Drawing.Point(342, 19);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(136, 36);
            this.lblMat.TabIndex = 15;
            this.lblMat.Text = "Matricule";
            // 
            // pbImgGrade
            // 
            this.pbImgGrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImgGrade.Location = new System.Drawing.Point(546, 19);
            this.pbImgGrade.Name = "pbImgGrade";
            this.pbImgGrade.Size = new System.Drawing.Size(149, 149);
            this.pbImgGrade.TabIndex = 14;
            this.pbImgGrade.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(79, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date d\'embauche : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(79, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(79, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de naissance : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(79, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sexe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(79, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(79, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom : ";
            // 
            // grpCarriere
            // 
            this.grpCarriere.Controls.Add(this.label9);
            this.grpCarriere.Controls.Add(this.label8);
            this.grpCarriere.Controls.Add(this.label7);
            this.grpCarriere.Controls.Add(this.btnChangerGrade);
            this.grpCarriere.Controls.Add(this.cboGrade);
            this.grpCarriere.Controls.Add(this.lblBip);
            this.grpCarriere.Controls.Add(this.lblTel);
            this.grpCarriere.Controls.Add(this.lblGrade);
            this.grpCarriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarriere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpCarriere.Location = new System.Drawing.Point(85, 374);
            this.grpCarriere.Name = "grpCarriere";
            this.grpCarriere.Size = new System.Drawing.Size(568, 187);
            this.grpCarriere.TabIndex = 7;
            this.grpCarriere.TabStop = false;
            this.grpCarriere.Text = "Carrière";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Téléphone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "BIP :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Grade : ";
            // 
            // btnChangerGrade
            // 
            this.btnChangerGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChangerGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangerGrade.Location = new System.Drawing.Point(411, 42);
            this.btnChangerGrade.Name = "btnChangerGrade";
            this.btnChangerGrade.Size = new System.Drawing.Size(144, 45);
            this.btnChangerGrade.TabIndex = 4;
            this.btnChangerGrade.Text = "Changer";
            this.btnChangerGrade.UseVisualStyleBackColor = false;
            this.btnChangerGrade.Click += new System.EventHandler(this.btnChangerGrade_Click);
            this.btnChangerGrade.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnChangerGrade.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(230, 42);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(172, 37);
            this.cboGrade.TabIndex = 3;
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(486, 131);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(63, 29);
            this.lblBip.TabIndex = 2;
            this.lblBip.Text = "BIP :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(180, 131);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(143, 29);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(131, 48);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(98, 29);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade : ";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEmbauche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDateEmbauche.Location = new System.Drawing.Point(358, 322);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(257, 32);
            this.lblDateEmbauche.TabIndex = 6;
            this.lblDateEmbauche.Text = "Date d\'embauche : ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblType.Location = new System.Drawing.Point(358, 275);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 32);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "type";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDateNaissance.Location = new System.Drawing.Point(358, 228);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(271, 32);
            this.lblDateNaissance.TabIndex = 4;
            this.lblDateNaissance.Text = "Date de naissance : ";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSexe.Location = new System.Drawing.Point(357, 181);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(101, 32);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPrenom.Location = new System.Drawing.Point(355, 134);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(135, 32);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblNom.Location = new System.Drawing.Point(355, 87);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(95, 32);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : ";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMatricule.Location = new System.Drawing.Point(163, 19);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(173, 36);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule n°";
            // 
            // pnlCarriere
            // 
            this.pnlCarriere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCarriere.Controls.Add(this.cboStatus);
            this.pnlCarriere.Controls.Add(this.btnMettreAJour);
            this.pnlCarriere.Controls.Add(this.lsbAffectationPassees);
            this.pnlCarriere.Controls.Add(this.lsbHabilitation);
            this.pnlCarriere.Controls.Add(this.cboAffectation);
            this.pnlCarriere.Controls.Add(this.lblAffectationPassees);
            this.pnlCarriere.Controls.Add(this.lblHabilitation);
            this.pnlCarriere.Controls.Add(this.lblAffectation);
            this.pnlCarriere.Controls.Add(this.lblCarriere);
            this.pnlCarriere.Location = new System.Drawing.Point(788, 340);
            this.pnlCarriere.Name = "pnlCarriere";
            this.pnlCarriere.Size = new System.Drawing.Size(718, 580);
            this.pnlCarriere.TabIndex = 8;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(79, 506);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(162, 37);
            this.cboStatus.TabIndex = 8;
            // 
            // btnMettreAJour
            // 
            this.btnMettreAJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMettreAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettreAJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMettreAJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMettreAJour.Location = new System.Drawing.Point(483, 506);
            this.btnMettreAJour.Name = "btnMettreAJour";
            this.btnMettreAJour.Size = new System.Drawing.Size(235, 58);
            this.btnMettreAJour.TabIndex = 7;
            this.btnMettreAJour.Text = "Mettre à jour";
            this.btnMettreAJour.UseVisualStyleBackColor = false;
            this.btnMettreAJour.Click += new System.EventHandler(this.btnMettreAJour_Click);
            this.btnMettreAJour.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnMettreAJour.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // lsbAffectationPassees
            // 
            this.lsbAffectationPassees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbAffectationPassees.FormattingEnabled = true;
            this.lsbAffectationPassees.ItemHeight = 29;
            this.lsbAffectationPassees.Location = new System.Drawing.Point(79, 360);
            this.lsbAffectationPassees.Name = "lsbAffectationPassees";
            this.lsbAffectationPassees.Size = new System.Drawing.Size(578, 120);
            this.lsbAffectationPassees.TabIndex = 6;
            // 
            // lsbHabilitation
            // 
            this.lsbHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbHabilitation.FormattingEnabled = true;
            this.lsbHabilitation.ItemHeight = 29;
            this.lsbHabilitation.Location = new System.Drawing.Point(79, 178);
            this.lsbHabilitation.Name = "lsbHabilitation";
            this.lsbHabilitation.Size = new System.Drawing.Size(578, 120);
            this.lsbHabilitation.TabIndex = 5;
            // 
            // cboAffectation
            // 
            this.cboAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAffectation.FormattingEnabled = true;
            this.cboAffectation.Location = new System.Drawing.Point(391, 87);
            this.cboAffectation.Name = "cboAffectation";
            this.cboAffectation.Size = new System.Drawing.Size(266, 37);
            this.cboAffectation.TabIndex = 4;
            // 
            // lblAffectationPassees
            // 
            this.lblAffectationPassees.AutoSize = true;
            this.lblAffectationPassees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffectationPassees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAffectationPassees.Location = new System.Drawing.Point(79, 320);
            this.lblAffectationPassees.Name = "lblAffectationPassees";
            this.lblAffectationPassees.Size = new System.Drawing.Size(233, 29);
            this.lblAffectationPassees.TabIndex = 3;
            this.lblAffectationPassees.Text = "Affectation passées :";
            // 
            // lblHabilitation
            // 
            this.lblHabilitation.AutoSize = true;
            this.lblHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblHabilitation.Location = new System.Drawing.Point(79, 138);
            this.lblHabilitation.Name = "lblHabilitation";
            this.lblHabilitation.Size = new System.Drawing.Size(151, 29);
            this.lblHabilitation.TabIndex = 2;
            this.lblHabilitation.Text = "Habilitation : ";
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffectation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAffectation.Location = new System.Drawing.Point(79, 90);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(294, 29);
            this.lblAffectation.TabIndex = 1;
            this.lblAffectation.Text = "Caserne de ratachement : ";
            // 
            // lblCarriere
            // 
            this.lblCarriere.AutoSize = true;
            this.lblCarriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarriere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCarriere.Location = new System.Drawing.Point(240, 17);
            this.lblCarriere.Name = "lblCarriere";
            this.lblCarriere.Size = new System.Drawing.Size(273, 32);
            this.lblCarriere.TabIndex = 0;
            this.lblCarriere.Text = "Informations carrière";
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.BackColor = System.Drawing.Color.Transparent;
            this.lblChoixCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixCaserne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblChoixCaserne.Location = new System.Drawing.Point(10, 179);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(456, 32);
            this.lblChoixCaserne.TabIndex = 9;
            this.lblChoixCaserne.Text = "Veuillez sélectionner une caserne :";
            // 
            // lblChoixPompier
            // 
            this.lblChoixPompier.AutoSize = true;
            this.lblChoixPompier.BackColor = System.Drawing.Color.Transparent;
            this.lblChoixPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixPompier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblChoixPompier.Location = new System.Drawing.Point(10, 262);
            this.lblChoixPompier.Name = "lblChoixPompier";
            this.lblChoixPompier.Size = new System.Drawing.Size(442, 32);
            this.lblChoixPompier.TabIndex = 10;
            this.lblChoixPompier.Text = "Veuillez sélectionner un pompier :";
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(491, 176);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(330, 39);
            this.cboChoixCaserne.TabIndex = 11;
            this.cboChoixCaserne.SelectedValueChanged += new System.EventHandler(this.cboChoixCaserne_SelectedValueChanged);
            // 
            // cboChoixPompier
            // 
            this.cboChoixPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChoixPompier.FormattingEnabled = true;
            this.cboChoixPompier.Location = new System.Drawing.Point(491, 259);
            this.cboChoixPompier.Name = "cboChoixPompier";
            this.cboChoixPompier.Size = new System.Drawing.Size(330, 39);
            this.cboChoixPompier.TabIndex = 12;
            this.cboChoixPompier.SelectedValueChanged += new System.EventHandler(this.cboChoixPompier_SelectedValueChanged);
            // 
            // btnNouveauPompier
            // 
            this.btnNouveauPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouveauPompier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveauPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauPompier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNouveauPompier.Location = new System.Drawing.Point(1252, 154);
            this.btnNouveauPompier.Name = "btnNouveauPompier";
            this.btnNouveauPompier.Size = new System.Drawing.Size(254, 86);
            this.btnNouveauPompier.TabIndex = 13;
            this.btnNouveauPompier.Text = "Nouveau Pompier";
            this.btnNouveauPompier.UseVisualStyleBackColor = false;
            this.btnNouveauPompier.Click += new System.EventHandler(this.btnNouveauPompier_Click);
            this.btnNouveauPompier.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnNouveauPompier.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // btnPlusInfo
            // 
            this.btnPlusInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlusInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPlusInfo.Location = new System.Drawing.Point(788, 340);
            this.btnPlusInfo.Name = "btnPlusInfo";
            this.btnPlusInfo.Size = new System.Drawing.Size(280, 68);
            this.btnPlusInfo.TabIndex = 15;
            this.btnPlusInfo.Text = "Plus d\'information";
            this.btnPlusInfo.UseVisualStyleBackColor = false;
            this.btnPlusInfo.Click += new System.EventHandler(this.btnPlusInfo_Click);
            this.btnPlusInfo.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnPlusInfo.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLogin.Controls.Add(this.panel3);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.btnValider);
            this.pnlLogin.Controls.Add(this.btnRetour);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1530, 950);
            this.pnlLogin.TabIndex = 16;
            this.pnlLogin.Visible = false;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lblLoginTitre);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1530, 133);
            this.panel3.TabIndex = 8;
            // 
            // lblLoginTitre
            // 
            this.lblLoginTitre.AutoSize = true;
            this.lblLoginTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblLoginTitre.Location = new System.Drawing.Point(610, 57);
            this.lblLoginTitre.Name = "lblLoginTitre";
            this.lblLoginTitre.Size = new System.Drawing.Size(309, 46);
            this.lblLoginTitre.TabIndex = 5;
            this.lblLoginTitre.Text = "Connectez-vous";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(522, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 524);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtMdp);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblMdp);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 514);
            this.panel1.TabIndex = 6;
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(41, 390);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(415, 53);
            this.txtMdp.TabIndex = 4;
            this.txtMdp.UseSystemPasswordChar = true;
            this.txtMdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMdp_KeyDown);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(41, 156);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(415, 53);
            this.txtId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblId.Location = new System.Drawing.Point(33, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(191, 46);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Identifiant";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMdp.Location = new System.Drawing.Point(35, 308);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(270, 46);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de passe ";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnValider.Location = new System.Drawing.Point(1217, 835);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(203, 69);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            this.btnValider.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnValider.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRetour.Location = new System.Drawing.Point(110, 835);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(203, 69);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnRetour.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnRetour.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnActualiser.Location = new System.Drawing.Point(972, 154);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(254, 86);
            this.btnActualiser.TabIndex = 17;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            this.btnActualiser.MouseEnter += new System.EventHandler(this.btnNouveauPompier_MouseEnter);
            this.btnActualiser.MouseLeave += new System.EventHandler(this.btnNouveauPompier_MouseLeave);
            // 
            // ucGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryUserControl.Properties.Resources.fond1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.btnPlusInfo);
            this.Controls.Add(this.btnNouveauPompier);
            this.Controls.Add(this.cboChoixPompier);
            this.Controls.Add(this.cboChoixCaserne);
            this.Controls.Add(this.lblChoixPompier);
            this.Controls.Add(this.lblChoixCaserne);
            this.Controls.Add(this.pnlCarriere);
            this.Controls.Add(this.pnlinfoPompier);
            this.Controls.Add(this.pnlTitre);
            this.Name = "ucGestionPersonnel";
            this.Size = new System.Drawing.Size(1530, 950);
            this.Load += new System.EventHandler(this.ucGestionPersonnel_Load);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.pnlinfoPompier.ResumeLayout(false);
            this.pnlinfoPompier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgGrade)).EndInit();
            this.grpCarriere.ResumeLayout(false);
            this.grpCarriere.PerformLayout();
            this.pnlCarriere.ResumeLayout(false);
            this.pnlCarriere.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlinfoPompier;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.GroupBox grpCarriere;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnChangerGrade;
        private System.Windows.Forms.Panel pnlCarriere;
        private System.Windows.Forms.Label lblAffectationPassees;
        private System.Windows.Forms.Label lblHabilitation;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblCarriere;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.Label lblChoixPompier;
        private System.Windows.Forms.ComboBox cboChoixCaserne;
        private System.Windows.Forms.ComboBox cboChoixPompier;
        private System.Windows.Forms.Button btnNouveauPompier;
        private System.Windows.Forms.ListBox lsbHabilitation;
        private System.Windows.Forms.ComboBox cboAffectation;
        private System.Windows.Forms.ListBox lsbAffectationPassees;
        private System.Windows.Forms.Button btnMettreAJour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlusInfo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLoginTitre;
        private System.Windows.Forms.Button btnDeconexion;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.PictureBox pbImgGrade;
        private System.Windows.Forms.Label lblMat;
    }
}
