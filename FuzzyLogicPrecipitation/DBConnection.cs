using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    class DBConnection
    {
        private string path = Application.StartupPath;
        private string connString;
        ArrayList executedRules;

        public DBConnection(string dbName)
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "\\" + dbName + ";Integrated Security=True";
        }

        public ArrayList getRules(Cloudy cloudy, Pressure pressure)
        {
            if (executedRules == null)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    ArrayList cloudyRules = findActiveCloudyLevels(cloudy);
                    ArrayList pressureRules = findActivePressureLevels(pressure);
                    string sql = prepareSqlQuery(cloudyRules, pressureRules);
                    DataTable dt = findRulesInDB(conn, sql);
                    executedRules = new ArrayList();
                    fillExecutedRules(dt);
                }
            }
            return executedRules;
        }

        private DataTable findRulesInDB(SqlConnection conn, string sql)
        {
            conn.ConnectionString = connString;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "rules");
            conn.Close();
            return ds.Tables["rules"];
        }

        private void fillExecutedRules(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int[] ruleScores = new int[4];
                int counter = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    ruleScores[counter] = (int)row[col];
                    counter++;
                }
                executedRules.Add(ruleScores);
            }
        }

        public ArrayList findActiveCloudyLevels(Cloudy cloudy)
        {
            ArrayList cloudyRules = new ArrayList();
            if (cloudy.cloudless != 0) cloudyRules.Add(1);
            if (cloudy.small != 0) cloudyRules.Add(2);
            if (cloudy.cloudy != 0) cloudyRules.Add(3);
            if (cloudy.complete != 0) cloudyRules.Add(4);
            return cloudyRules;
        }

        public ArrayList findActivePressureLevels(Pressure pressure)
        {
            ArrayList pressureRules = new ArrayList();
            if (pressure.low != 0) pressureRules.Add(1);
            if (pressure.medium != 0) pressureRules.Add(2);
            if (pressure.high != 0) pressureRules.Add(3);
            return pressureRules;
        }

        private string prepareSqlQuery(ArrayList cloudyRules, ArrayList pressureRules)
        {
            return $"select * from rules where {prepareWhereBasedOnActiveVariableLevel(cloudyRules, "cloudy")} and {prepareWhereBasedOnActiveVariableLevel(pressureRules, "pressure")}";
        }

        private string prepareWhereBasedOnActiveVariableLevel(ArrayList list, string columnName)
        {
            string sqlStringFromArrayList = "";
            if (list.Count == 1)
            {
                sqlStringFromArrayList = $"({columnName} = {list[0]})";
            }
            else if (list.Count == 2)
            {
                sqlStringFromArrayList = $"({columnName} = {list[0]} or {columnName} = {list[1]})";
            }

            return sqlStringFromArrayList;
        }
    }
}
