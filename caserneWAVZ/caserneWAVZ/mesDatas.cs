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

    public static void ChargerTables()
    {
        var conn = Connexion.Connec;

        new SQLiteDataAdapter("SELECT * FROM Mission", conn).Fill(dsGlobal, "Mission");
        new SQLiteDataAdapter("SELECT * FROM Caserne", conn).Fill(dsGlobal, "Caserne");
        new SQLiteDataAdapter("SELECT * FROM NatureSinistre", conn).Fill(dsGlobal, "NatureSinistre");
        


        dsGlobal.Relations.Add("Mission_Caserne",
            dsGlobal.Tables["Caserne"].Columns["id"],
            dsGlobal.Tables["Mission"].Columns["idCaserne"]);

        dsGlobal.Relations.Add("Mission_Sinistre",
            dsGlobal.Tables["NatureSinistre"].Columns["id"],
            dsGlobal.Tables["Mission"].Columns["idNatureSinistre"]);
    }
}

}
