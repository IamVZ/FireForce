using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Ocsp;

namespace LibraryUserControl
{


    public partial class ucStatistique : UserControl
    {


        private SQLiteConnection connection;
        public ucStatistique()
        {
            InitializeComponent();

        }


        public ucStatistique(SQLiteConnection connect)
        {
            InitializeComponent();
            connection = connect;
        }
        public void ChargerCaserne()
        {
            List<itemBdd> casernes = new List<itemBdd>();
            string req = "SELECT Id, Nom FROM Caserne";

            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            SQLiteDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    casernes.Add(new itemBdd
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nom = reader["Nom"].ToString()
                    });
                }

                cbxCaserne.DataSource = casernes;
                cbxCaserne.DisplayMember = "Nom";
                cbxCaserne.ValueMember = "Id";
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                cmd.Dispose();
            }
        }



        public void ChargerEnginPlusUtilise()
        {
            pnlEnginplus.Controls.Clear(); // Vide les anciens labels

            string idCaserne = cbxCaserne.SelectedValue.ToString();

            string req = @"
        SELECT 
            e.numero,
            e.codeTypeEngin,
            COUNT(*) AS Nombre_utilisation
        FROM 
            Engin e
        JOIN 
            PartirAvec pa 
            ON pa.idCaserne = e.idCaserne 
            AND pa.codeTypeEngin = e.codeTypeEngin 
            AND pa.numeroEngin = e.numero
        WHERE
            e.idCaserne = @idCaserne
        GROUP BY 
            e.idCaserne,
            e.codeTypeEngin,
            e.numero
        ORDER BY 
            Nombre_utilisation DESC;";

            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            cmd.Parameters.AddWithValue("@idCaserne", idCaserne);

            SQLiteDataReader reader = null;
            int compteur = 0;
            int x = 0;
            int y = 53;
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read() && compteur < 3)
                {
                    string code = reader["codeTypeEngin"].ToString();
                    string numero = reader["numero"].ToString();
                    int nbUtilisation = Convert.ToInt32(reader["Nombre_utilisation"]);

                    Label lbl = new Label();
                    lbl.Text = $"{compteur+1}.Engin {code} n°{numero} — Utilisé {nbUtilisation} fois";
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(x, y);

                    pnlEnginplus.Controls.Add(lbl);
                    compteur++;
                    y += 100;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur lors du chargement des engins : " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                cmd.Dispose();
            }
        }


        public void EnginParHeureUtil()
        {
            pnlHeure.Controls.Clear();
            string idCaserne = cbxCaserne.SelectedValue.ToString();
            string req = @"SELECT 
                            e.idCaserne,
                            e.codeTypeEngin,
                            e.numero,
                            SUM((julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart)) * 24) AS total_heures_utilisation
                           FROM Engin e
                           JOIN 
                            PartirAvec pa 
                            ON pa.idCaserne = e.idCaserne 
                            AND pa.codeTypeEngin = e.codeTypeEngin 
                            AND pa.numeroEngin = e.numero
                           JOIN Mission m 
                            ON m.id = pa.idMission
                           WHERE m.dateHeureDepart IS NOT NULL 
                            AND m.dateHeureRetour IS NOT NULL
                            AND e.idCaserne = @idCaserne
                            GROUP BY e.idCaserne, e.codeTypeEngin, e.numero
                            ORDER BY total_heures_utilisation DESC;";
            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            cmd.Parameters.AddWithValue("@idCaserne", idCaserne);

            SQLiteDataReader reader = null;
            int compteur = 0;
            int x = 0;
            int y = 53;
            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string code = reader["codeTypeEngin"].ToString();
                    string numero = reader["numero"].ToString();
                    double totalHeures = Convert.ToDouble(reader["total_heures_utilisation"]);
                    int heures = (int)totalHeures;
                    int minutes = (int)Math.Round((totalHeures - heures) * 60);

                    string tempsFormate = $"{heures} h {minutes:D2}";


                    Label lbl = new Label();
                    lbl.Text = $"{compteur + 1}.Engin {code} n°{numero} — {tempsFormate} min";
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(x, y);

                    pnlHeure.Controls.Add(lbl);
                    compteur++;
                    y += 50;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur lors du chargement des engins : " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                cmd.Dispose();
            }
        }


        public void ChargerNombreIntervention()
        {
            pnlIntervention.Controls.Clear();

            string req = @"SELECT ns.libelle,ns.id,COUNT(m.idNatureSinistre) 
                           FROM NatureSinistre ns
                           LEFT JOIN Mission m ON m.idNatureSinistre = ns.id
                           GROUP BY ns.libelle
                           ORDER BY 3 DESC";
            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            SQLiteDataReader reader = null;
            int x = 20;
            int y = 0;
            try 
            {
                reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    string natureS = reader["libelle"].ToString();
                    string idImage = reader["id"].ToString();
                    string nbIntervention = reader[2].ToString();
                    string nbInterventionTexte = nbIntervention == "1" ? "1 intervention" : $"{nbIntervention} interventions";
                    Label lbl = new Label() ;
                    PictureBox pictureBox = new PictureBox() ;
                    pictureBox.Size = new Size(30, 30);
                    pictureBox.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("_" + idImage);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    lbl.Text = $"{natureS} : {nbInterventionTexte}";
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    if (x >= pnlIntervention.Width-100)
                    {
                        x = 20;
                        y += 30;
                    }
                    pictureBox.Location = new Point(x,y);

                    lbl.Location = new Point(x+30, y);

                    pnlIntervention.Controls.Add(lbl);
                    pnlIntervention.Controls.Add(pictureBox);

                    x += 500;

                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur lors du chargement du nombre interv : " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                cmd.Dispose();
            }
        }


        public void ChargerHabilitationLaPlusSolicite()
        {
            lblResHabilitation.Text = "bug moment ?";
            string req = @"SELECT lib,MAX(comptage) AS habilitation_plus_sollicite
                           FROM (
                            SELECT idHabilitation as habit,libelle as lib ,COUNT(m.idHabilitation) AS comptage
                            FROM Habilitation h
                            JOIN Mobiliser m ON h.id = m.idHabilitation
                            GROUP BY h.libelle
                            );";
            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            SQLiteDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read()) 
                { 
                    string habilitation = reader[0].ToString();
                    string nbHabilitation = reader[1].ToString();
                    lblResHabilitation.Text = $"{habilitation} ({nbHabilitation} pompiers)";
                }
                reader.Close();
            }
            catch (SQLiteException ex) 
            {
                MessageBox.Show("Erreur lors du chargement de l'habilitation la plus sollicité" + ex.Message);
            }


        }
        public void ChargerHabilitation()
        {
            List<itemBdd> habilitation = new List<itemBdd>();
            string req = "SELECT id, libelle FROM Habilitation";

            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            SQLiteDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    habilitation.Add(new itemBdd
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Nom = reader[1].ToString()
                    });
                }

                cbxHabilitation.DataSource = habilitation;
                cbxHabilitation.DisplayMember = "Nom";
                cbxHabilitation.ValueMember = "Id";
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                cmd.Dispose();
            }
        }

        public void ChargerPompierParHabilitation()
        {
            pnlListePompier.Controls.Clear();

            if (cbxHabilitation.SelectedValue == null)
                return;

            string idHabilitation = cbxHabilitation.SelectedValue.ToString();

            string req = @"SELECT p.nom, p.prenom, c.nom
                   FROM Pompier p
                   JOIN Passer pa ON pa.matriculePompier = p.matricule
                   JOIN Affectation a ON a.matriculePompier = p.matricule
                   JOIN Caserne c ON c.id = a.idCaserne
                   WHERE idHabilitation = @idHabilitation";

            SQLiteCommand cmd = new SQLiteCommand(req, connection);
            cmd.Parameters.AddWithValue("@idHabilitation", idHabilitation);
            SQLiteDataReader reader = null;

            int x = 20;
            int y = 0;
            bool found = false;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    found = true;

                    string nomPompier = reader[0].ToString();
                    string prenomPompier = reader[1].ToString();
                    string nomCaserne = reader[2].ToString();

                    Label lbl = new Label();
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(30, 30);
                    pictureBox.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject("pompier");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    lbl.Text = $"{nomCaserne} : {nomPompier} {prenomPompier}";
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    lbl.ForeColor = Color.White;

                    if (x >= pnlListePompier.Width - 100)
                    {
                        x = 20;
                        y += 30;
                    }

                    pictureBox.Location = new Point(x, y);
                    lbl.Location = new Point(x + 30, y);

                    pnlListePompier.Controls.Add(lbl);
                    pnlListePompier.Controls.Add(pictureBox);

                    x += 500;
                }

                // Si aucun pompier trouvé
                if (!found)
                {
                    Label lbl = new Label();
                    lbl.Text = "Aucun pompier pour cette habilitation.";
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(20, 20);
                    pnlListePompier.Controls.Add(lbl);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur lors du chargement des pompiers : " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                cmd.Dispose();
            }
        }


        //Comme ça c'est bien plus simple pour garder l'id pour la suite
        public class itemBdd
        {
            public int Id { get; set; }
            public string Nom { get; set; }

            public override string ToString()
            {
                return Nom;
            }
        }


        private void cbxCaserne_SelectedValueChanged(object sender, EventArgs e)
        {
            ChargerEnginPlusUtilise();
            EnginParHeureUtil();
            
            
        }

        private void cbxHabilitation_SelectedValueChanged(object sender, EventArgs e)
        {
            ChargerPompierParHabilitation();
        }
    }



}
