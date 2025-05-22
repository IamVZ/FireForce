using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace LibraryUserControl
{
    public partial class TableauDeBord : UserControl
    {

        //Tout les delegates nécessaire que ça soit pour terminer la mission, ou remplir les infos selon si EnCours checked.
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
            //Initialiser toutes les missions avec chacune une case
            pnlMission.Controls.Clear();
            //Position de départ
            int x = 100;
            int y = 20;
            //Pour chaque id dans la liste
            foreach (int id in idMissions)
            {
                //Test pour voir si mon délégué était bien définis
                if (GetMissionInfos == null)
                    throw new InvalidOperationException("eeee probleme de délégué la nan ?.");
                //Le delegate s'occupera de ramener les infos ici dans un tableau
                string[] infos = GetMissionInfos(id);
                //Si l'info est null on peut juste skip 
                if (infos == null )
                    continue;
                //Instanciation d'une case et des boutons ainsi que leur fonction associé    
                ucTableauDeBordCase mission = new ucTableauDeBordCase();
                mission.remplirLabel(infos[0], infos[1], infos[2], infos[3], infos[4]);

                Button boutonPDF = new Button { Size = new Size(60, 60), Text = "PDF" };
                boutonPDF.Click += (s, e) =>
                {
                    ExporterMissionEnPDF(mission);
                };

                Button boutonValider = new Button { Size = new Size(60, 60), Text = "Terminer !!!!" };
                boutonValider.Click += (s, e) =>
                {
                    if (ValiderMission != null)
                    {
                        
                        string idStr = mission.IDMission.Replace("ID mission : ", "");
                        if (int.TryParse(idStr, out int idMission))
                        {
                            ValiderMission(idMission);
                        }
                    }
                };


                mission.Location = new Point(x, y);
                boutonPDF.Location = new Point(x + mission.Width + 10, y);
                boutonValider.Location = new Point(x + mission.Width + 10, y + boutonPDF.Height + 10);

                pnlMission.Controls.Add(mission);
                pnlMission.Controls.Add(boutonPDF);
                pnlMission.Controls.Add(boutonValider);

                y += Math.Max(mission.Height, boutonPDF.Height + boutonValider.Height) + 20;
            }

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

                            var titreFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                            var labelFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD);
                            var normalFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);

                            doc.Add(new Paragraph("Rapport de Mission", titreFont));
                            doc.Add(new Paragraph(" "));

                            string idStr = mission.IDMission.Replace("ID mission : ", "");
                            if (int.TryParse(idStr, out int idMission))
                            {
                                DataRow missionRow = dataSet.Tables["Mission"].Select($"id = {idMission}").FirstOrDefault();
                                if (missionRow != null)
                                {
                                    string retour = missionRow["dateHeureRetour"]?.ToString();
                                    string adresse = missionRow["adresse"]?.ToString();
                                    string cp = missionRow["cp"]?.ToString();
                                    string ville = missionRow["ville"]?.ToString();
                                    string compteRendu = missionRow["compteRendu"]?.ToString();

                                    doc.Add(new Paragraph("Identifiant de la mission :", labelFont));
                                    doc.Add(new Paragraph(mission.IDMission, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Heure de départ :", labelFont));
                                    doc.Add(new Paragraph(mission.Debut, normalFont));
                                    doc.Add(new Paragraph(" "));

                                    doc.Add(new Paragraph("Motif de l’appel :", labelFont));
                                    doc.Add(new Paragraph(mission.Cause, normalFont));
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
                                    doc.Add(new Paragraph(compteRendu ?? "Non renseigné", normalFont));
                                    doc.Add(new Paragraph(" "));

                                    // Engins mobilisés (via PartirAvec)
                                    var engins = dataSet.Tables["PartirAvec"].Select($"idMission = {idMission}");
                                    if (engins.Length > 0)
                                    {
                                        doc.Add(new Paragraph("Engins mobilisés :", labelFont));
                                        foreach (var engin in engins)
                                        {
                                            string codeType = engin["codeTypeEngin"]?.ToString();
                                            string numero = engin["numeroEngin"]?.ToString();

                                            // Optionnel : aller chercher le nom du type d'engin depuis TypeEngin
                                            var typeRow = dataSet.Tables["TypeEngin"].Select($"code = '{codeType}'").FirstOrDefault();
                                            string nomType = typeRow?["nom"]?.ToString();

                                            doc.Add(new Paragraph($"- {nomType ?? codeType} n°{numero}", normalFont));
                                        }
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
                        Location = new Point(150, 100),
                        ForeColor = Color.DarkRed
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
