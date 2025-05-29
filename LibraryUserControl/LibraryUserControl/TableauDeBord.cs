using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace LibraryUserControl
{

    public partial class TableauDeBord : UserControl
    {







        //Tout les delegates nécessaire que ça soit pour terminer la mission, ou remplir les infos selon si EnCours checked (comme ça je m'entraine sur les delegate).
        public delegate string[] DelegateObtenirInfosMission(int idMission);
        public DelegateObtenirInfosMission GetMissionInfos { get; set; }

        public delegate void DelegateValiderMission(int idMission);
        public DelegateValiderMission ValiderMission { get; set; }

        public delegate List<int> DelegateObtenirIdMissionsEnCours();
        public DelegateObtenirIdMissionsEnCours GetMissionsEnCours { get; set; }

        public delegate List<int> DelegateObtenirIDtoutMission();
        public DelegateObtenirIDtoutMission GetAllMission { get; set; }

        private DataSet dataSet;

        public TableauDeBord()
        {
            InitializeComponent();
        }

        public TableauDeBord(DataSet ds)
        {
            InitializeComponent();
            dataSet = ds;

        }

        public void InitialiserCasesAvecMissions(List<int> idMissions)
        {
            // Initialiser toutes les missions avec chacune une case
            pnlMission.Controls.Clear();

            // Suspend la mise en page pour éviter les refreshs multiples
            pnlMission.SuspendLayout();

            // Position de départ
            int x = 200;
            int y = 20;
            idMissions.Sort();        
            idMissions.Reverse();      
            // Pour chaque id dans la liste
            foreach (int id in idMissions)
            {
                if (GetMissionInfos == null)
                    throw new InvalidOperationException("eeee probleme de délégué la nan ?.");

                string[] infos = GetMissionInfos(id);
                if (infos == null)
                    continue;

                ucTableauDeBordCase mission = new ucTableauDeBordCase();
                mission.remplirLabel(infos[0], infos[1], infos[2], infos[3], infos[4]);

                Button boutonPDF = new Button
                {
                    Size = new Size(150, 60),
                    Text = "Convertir\n en PDF",
                    Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold),
                    BackColor = Color.FromArgb(50, 0, 0),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                boutonPDF.Click += (s, e) =>
                {
                    ExporterMissionEnPDF(mission);
                };

                bool missionTerminee = false;
                DataRow row = dataSet.Tables["Mission"].Select($"id = {id}").FirstOrDefault();
                if (Convert.ToInt32(row["terminee"]) == 1 )
                {
                    missionTerminee = true;
                }
                Button boutonAction;

                if (missionTerminee)
                {
                    boutonAction = new Button
                    {
                        Size = new Size(150, 60),
                        Text = "Mission déjà terminée",
                        Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold),
                        BackColor = Color.Gray,
                        ForeColor = Color.White,
                        Enabled = false,
                        FlatStyle = FlatStyle.Flat
                    };
                }
                else 
                {
                    boutonAction = new Button
                    {
                        Size = new Size(150, 60),
                        Text = "Terminer",
                        Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold),
                        BackColor = Color.FromArgb(0, 0, 107),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand
                    };
                    boutonAction.Click += (s, e) =>
                    {
                        if (ValiderMission != null)
                        {
                            string idStr = mission.IDMission.Replace("ID mission : ", "");
                            if (int.TryParse(idStr, out int idMission))
                            {
                                ValiderMission(idMission);
                                chkEnCours_CheckedChanged(chkEnCours, EventArgs.Empty);
                            }
                        }
                    };

                }

               

                mission.ImageMission = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("_" + infos[5]);

                mission.Location = new Point(x, y);
                boutonPDF.Location = new Point(x + mission.Width + 10, y);
                boutonAction.Location = new Point(x + mission.Width + 10, y + boutonPDF.Height + 10);

                pnlMission.Controls.Add(mission);
                pnlMission.Controls.Add(boutonPDF);
                pnlMission.Controls.Add(boutonAction);

                y += Math.Max(mission.Height, boutonPDF.Height + boutonAction.Height) + 20;
            }

            pnlMission.ResumeLayout();

            pnlMission.AutoScroll = true;
        }


        private void ExporterMissionEnPDF(ucTableauDeBordCase mission)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fichier PDF (*.pdf)|*.pdf";
                sfd.FileName = $"{mission.IDMission.Replace("ID mission : ", "")}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string cheminFichier = sfd.FileName;

                    try
                    {
                        using (var fs = new System.IO.FileStream(cheminFichier, System.IO.FileMode.Create))
                        {
                            var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 50);
                            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Définition des polices
                            var titreFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                            var sectionFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                            var labelFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                            var normalFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);

                            // Titre du document
                            doc.Add(new Paragraph("Rapport de Mission", titreFont));
                            doc.Add(new Paragraph(" "));

                            // Récupération de l'ID de la mission
                            string idStr = mission.IDMission.Replace("ID mission : ", "");
                            if (int.TryParse(idStr, out int idMission))
                            {
                                DataRow missionRow = dataSet.Tables["Mission"].Select($"id = {idMission}").FirstOrDefault();
                                if (missionRow != null)
                                {
                                    // Récupération des informations générales
                                    string depart = missionRow["dateHeureDepart"]?.ToString() ?? "Non renseigné";
                                    string retour = missionRow["dateHeureRetour"]?.ToString();
                                    string adresse = missionRow["adresse"]?.ToString() ?? "Non renseignée";
                                    string cp = missionRow["cp"]?.ToString() ?? "";
                                    string ville = missionRow["ville"]?.ToString() ?? "";
                                    string motif = missionRow["motifAppel"]?.ToString() ?? "Non précisé";
                                    string compteRendu = missionRow["compteRendu"]?.ToString() ?? "Non renseigné";

                                    // SECTION : Informations générales
                                    doc.Add(new Paragraph("Informations Générales", sectionFont));
                                    doc.Add(new Paragraph(" ", normalFont));

                                    doc.Add(new Paragraph("Identifiant de la mission :", labelFont));
                                    doc.Add(new Paragraph(mission.IDMission, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Heure de départ :", labelFont));
                                    doc.Add(new Paragraph(depart, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Motif de l’appel :", labelFont));
                                    doc.Add(new Paragraph(motif, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Description de la mission :", labelFont));
                                    doc.Add(new Paragraph(mission.Description, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Adresse :", labelFont));
                                    doc.Add(new Paragraph($"{adresse}, {cp} {ville}", normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Heure de retour :", labelFont));
                                    doc.Add(new Paragraph(retour ?? "Non disponible", normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Compte-rendu :", labelFont));
                                    doc.Add(new Paragraph(compteRendu, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    // SECTION : Engins Mobilisés
                                    var engins = dataSet.Tables["PartirAvec"].Select($"idMission = {idMission}");
                                    if (engins.Length > 0)
                                    {
                                        doc.Add(new Paragraph("Engins Mobilisés", sectionFont));
                                        doc.Add(new Paragraph(" "));

                                        // Création d'un tableau PDF avec 3 colonnes
                                        iTextSharp.text.pdf.PdfPTable tableEngins = new iTextSharp.text.pdf.PdfPTable(3);
                                        tableEngins.WidthPercentage = 100;
                                        tableEngins.SetWidths(new float[] { 3, 1, 3 });

                                        // En-têtes du tableau
                                        tableEngins.AddCell(new iTextSharp.text.Phrase("Type d'engin", labelFont));
                                        tableEngins.AddCell(new iTextSharp.text.Phrase("Numéro", labelFont));
                                        tableEngins.AddCell(new iTextSharp.text.Phrase("Commentaires", labelFont));

                                        foreach (DataRow engin in engins)
                                        {
                                            string codeType = engin["codeTypeEngin"]?.ToString();
                                            string numero = engin["numeroEngin"]?.ToString();

                                            // Récupérer le nom depuis la table TypeEngin
                                            var typeRow = dataSet.Tables["TypeEngin"].Select($"code = '{codeType}'").FirstOrDefault();
                                            string nomType = typeRow?["nom"]?.ToString() ?? codeType;

                                            // Pour les commentaires ou réparations éventuelles (si la colonne existe)
                                            string commentaires = engin.Table.Columns.Contains("reparationsEventuelles")
                                                ? engin["reparationsEventuelles"]?.ToString()
                                                : "";

                                            tableEngins.AddCell(new iTextSharp.text.Phrase(nomType, normalFont));
                                            tableEngins.AddCell(new iTextSharp.text.Phrase(numero, normalFont));
                                            tableEngins.AddCell(new iTextSharp.text.Phrase(commentaires, normalFont));
                                        }

                                        doc.Add(tableEngins);
                                        doc.Add(new Paragraph(" "));
                                    }
                                    else
                                    {
                                        doc.Add(new Paragraph("Aucun engin mobilisé.", normalFont));
                                        doc.Add(new Paragraph(" "));
                                    }

                                    // SECTION : Pompiers Mobilisés
                                    var mobilises = dataSet.Tables["Mobiliser"].Select($"idMission = {idMission}");
                                    if (mobilises.Length > 0)
                                    {
                                        doc.Add(new Paragraph("Pompiers Mobilisés", sectionFont));
                                        doc.Add(new Paragraph(" "));

                                        // Création d'un tableau avec 3 colonnes
                                        iTextSharp.text.pdf.PdfPTable tablePompiers = new iTextSharp.text.pdf.PdfPTable(3);
                                        tablePompiers.WidthPercentage = 100;
                                        tablePompiers.SetWidths(new float[] { 3, 3, 2 });

                                        // En-têtes
                                        tablePompiers.AddCell(new iTextSharp.text.Phrase("Nom", labelFont));
                                        tablePompiers.AddCell(new iTextSharp.text.Phrase("Prénom", labelFont));
                                        tablePompiers.AddCell(new iTextSharp.text.Phrase("Matricule", labelFont));

                                        foreach (DataRow mobilise in mobilises)
                                        {
                                            // Supposons que la table Mobiliser contient le matricule
                                            string matricule = mobilise["matriculePompier"]?.ToString();

                                            // Récupérer les infos du pompier depuis la table Pompier
                                            var pompierRow = dataSet.Tables["Pompier"].Select($"matricule = {matricule}").FirstOrDefault();
                                            string nom = pompierRow?["nom"]?.ToString() ?? "-";
                                            string prenom = pompierRow?["prenom"]?.ToString() ?? "-";

                                            tablePompiers.AddCell(new iTextSharp.text.Phrase(nom, normalFont));
                                            tablePompiers.AddCell(new iTextSharp.text.Phrase(prenom, normalFont));
                                            tablePompiers.AddCell(new iTextSharp.text.Phrase(matricule, normalFont));
                                        }

                                        doc.Add(tablePompiers);
                                        doc.Add(new Paragraph(" "));
                                    }
                                    else
                                    {
                                        doc.Add(new Paragraph("Aucun pompier mobilisé.", normalFont));
                                        doc.Add(new Paragraph(" "));
                                    }
                                }
                            }

                            doc.Close();
                        }

                        MessageBox.Show("PDF généré avec succès !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message);
                    }
                }
            }
        }





        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnCours.Checked)
            {
                if (GetMissionsEnCours == null)
                {
                    MessageBox.Show("Le délégué pour obtenir les missions en cours n'est pas défini.");
                    return;
                }

                List<int> missionsEnCours = GetMissionsEnCours();

                if (missionsEnCours.Count == 0)
                {
                    pnlMission.Controls.Clear();
                    Label lbl = new Label()
                    {
                        Text = "Aucune mission en cours",
                        AutoSize = true,
                        Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold),
                        Location = new Point(pnlMission.Width/2, pnlMission.Height/2),
                        ForeColor = Color.White
                    };
                    pnlMission.Controls.Add(lbl);
                }
                else
                {
                    InitialiserCasesAvecMissions(missionsEnCours);
               
                }
            }
            else
            {
                // hmmm faudrait la logique pour tt recharger ducoup la
                List<int> TouteLesMissions = GetAllMission();
                InitialiserCasesAvecMissions(TouteLesMissions);
            }
        }


        private void chkEnCours_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
