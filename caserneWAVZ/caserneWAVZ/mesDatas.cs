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
                string req = "select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(req, Connexion.Connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
                da.Fill(dsGlobal, nomTable);
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
