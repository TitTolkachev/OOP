using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    public class Tournament
    {
        public string name { get; set; }
        public string type { get; set; }
        public bool sexSeparation { get; set; }
        private bool _isFinished;
        public bool isFinished
        {
            get { return _isFinished; }
            set
            {
                if (value == true && _isFinished == false)
                {
                    _isFinished = value;
                    db.ChangeData($"UPDATE `tournament` SET `is_finished` = 1 WHERE `tournament`.`name` = '{name}'");
                }
            }
        }
        private bool _isStarted;
        public bool isStarted
        {
            get { return _isStarted; }
            set
            {
                if (value == true && _isStarted == false)
                {
                    _isStarted = true;
                    db.ChangeData($"UPDATE `tournament` SET `is_started` = 1 WHERE `tournament`.`name` = '{name}'");
                }
            }
        }

        private DB db;

        public Tournament()
        {
            db = new DB();
        }

        public List<Team> GetTeams()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `team` WHERE `tournament` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = name;
            DataTable teamsTable = db.SelectRequest(cmd);

            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamsTable.Rows.Count; i++)
            {
                Team team = new Team
                {
                    id = int.Parse(teamsTable.Rows[i][0].ToString()),
                    name = teamsTable.Rows[i][1].ToString(),
                    tournamentName = teamsTable.Rows[i][2].ToString(),
                    teamWins = int.Parse(teamsTable.Rows[i][3].ToString()),
                    teamPoints = int.Parse(teamsTable.Rows[i][4].ToString())
                };
                teams.Add(team);
            }

            return teams;
        }

        public void AddTeam(string teamName)
        {
            db.ChangeData($"INSERT INTO `team` (`name`, `tournament`, `wins`, `points`) VALUES('{teamName}', '{name}', '0', '0')");
        }

        public void RemoveTeam(int teamId)
        {
            db.ChangeData($"DELETE FROM `team` WHERE `id` = '{teamId}'");
        }

        public List<Game> GetGames()
        {
            return Controller.GetGames(this);
        }
    }
}
