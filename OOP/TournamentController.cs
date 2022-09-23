using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    public static class TournamentController
    {
        public static List<Tournament> GetTournaments()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tournament`", db.GetConnection());
            DataTable table = db.SelectRequest(cmd);

            List<Tournament> tournaments = new List<Tournament>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                tournaments.Add(new Tournament()
                {
                    name = table.Rows[i][0].ToString(),
                    type = table.Rows[i][1].ToString(),
                    sexSeparation = table.Rows[i][2].ToString() == "True",
                    isFinished = table.Rows[i][3].ToString() == "True",
                    isStarted = table.Rows[i][4].ToString() == "True"
                });
            }

            return tournaments;
        }

        public static void CreateTournament(string name, string type, bool sexSeparation)
        {
            DB db = new DB();
            db.ChangeData("INSERT INTO `tournament` (`name`, `type`, `sex_separation`, `is_finished`, `is_started`) VALUES('"
                + name + "', '" + type + "', '"
                + (sexSeparation ? 1 : 0) + "', '0', '0')");
        }

        public static Tournament GetTournamentByName(string name)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tournament` WHERE `name` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = name;
            DataTable table = db.SelectRequest(cmd);

            if (table.Rows.Count == 0)
                return null;
            else
            {
                return new Tournament
                {
                    name = table.Rows[0][0].ToString(),
                    type = table.Rows[0][1].ToString(),
                    sexSeparation = table.Rows[0][2].ToString() == "True",
                    isFinished = table.Rows[0][3].ToString() == "True",
                    isStarted = table.Rows[0][4].ToString() == "True"
                };
            }
        }
    }
}
