using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tournamentName { get; set; }
        public int teamWins { get; set; }
        public int teamPoints { get; set; }

        private DB db;

        public Team()
        {
            db = new DB();
        }

        public List<Player> GetPlayers()
        {
            DataTable teamPlayersTable = db.SelectRequest(new MySqlCommand(
                "SELECT * FROM `player` WHERE `team_id`=" + id, 
                db.GetConnection()));

            List<Player> players = new List<Player>();
            for (int i = 0; i < teamPlayersTable.Rows.Count; i++)
            {
                players.Add(new Player()
                {
                    id = int.Parse(teamPlayersTable.Rows[i][0].ToString()),
                    name = teamPlayersTable.Rows[i][1].ToString(),
                    surname = teamPlayersTable.Rows[i][2].ToString(),
                    birthday = teamPlayersTable.Rows[i][3].ToString(),
                    sex = teamPlayersTable.Rows[i][4].ToString(),
                    number = int.Parse(teamPlayersTable.Rows[i][5].ToString()),
                    weight = int.Parse(teamPlayersTable.Rows[i][6].ToString()),
                    height = int.Parse(teamPlayersTable.Rows[i][7].ToString()),
                    teamId = int.Parse(teamPlayersTable.Rows[i][8].ToString())
                });
            }

            return players;
        }

        public void Add(Player player)
        {
            db.ChangeData($"UPDATE `player` SET `team_id`= '{id}' WHERE `id`= '{player.id}'");
        }

        public void Remove(Player player)
        {
            db.ChangeData($"UPDATE `player` SET `team_id` = null WHERE `id`= '{player.id}'");
        }
    }
}
