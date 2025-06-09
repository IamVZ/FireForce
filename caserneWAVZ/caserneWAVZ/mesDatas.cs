using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace caserneWAVZ
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
        public static DataSet DsGlobal { get { return MesDatas.dsGlobal; } }

        public static void FillDs()
        {
            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");

            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i][2].ToString();
                string req = "SELECT * FROM " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(req, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
                da.Fill(dsGlobal, nomTable);

                if (nomTable == "Mission")
                {
                    dsGlobal.Tables["Mission"].PrimaryKey = new DataColumn[] {
                        dsGlobal.Tables["Mission"].Columns["id"]
                    };
                }

                if (nomTable == "Pompier")
                {
                    dsGlobal.Tables["Pompier"].PrimaryKey = new DataColumn[] {
                        dsGlobal.Tables["Pompier"].Columns["matricule"]
                    };
                }

                if (nomTable == "Engin")
                {
                    DataTable tbl = dsGlobal.Tables["Engin"];
                    tbl.PrimaryKey = new DataColumn[] {
                        tbl.Columns["idCaserne"],
                        tbl.Columns["codeTypeEngin"],
                        tbl.Columns["numero"]
                    };
                }

                if (nomTable == "Mobiliser")
                {
                    DataTable tbl = dsGlobal.Tables["Mobiliser"];
                    tbl.PrimaryKey = new DataColumn[] {
                        tbl.Columns["matriculePompier"],
                        tbl.Columns["idMission"]
                    };
                }

                if (nomTable == "PartirAvec")
                {
                    DataTable tbl = dsGlobal.Tables["PartirAvec"];
                    tbl.PrimaryKey = new DataColumn[] {
                        tbl.Columns["idCaserne"],
                        tbl.Columns["codeTypeEngin"],
                        tbl.Columns["numeroEngin"],
                        tbl.Columns["idMission"]
                    };
                }
            }

            dsGlobal.Relations.Add("Mission_Caserne",
                dsGlobal.Tables["Caserne"].Columns["id"],
                dsGlobal.Tables["Mission"].Columns["idCaserne"]);

            dsGlobal.Relations.Add("Mission_Sinistre",
                dsGlobal.Tables["NatureSinistre"].Columns["id"],
                dsGlobal.Tables["Mission"].Columns["idNatureSinistre"]);
        }
    }
}
