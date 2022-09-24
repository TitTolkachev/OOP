using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace OOP
{
    public static class GameController
    {
        public static void GenerateGrid(Tournament tournament)
        {
            DB db = new DB();
            List<Team> teams = tournament.GetTeams();

            int index;
            if (tournament.type == "Circular")
            {
                for (int i = 1; i < teams.Count; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        db.ChangeData($"INSERT INTO `game` (`id`, `tournament_name`, `date`, `is_finished`) VALUES (NULL, '{tournament.name}', NULL, '0')");
                        index = int.Parse(db.SelectRequest(new MySqlCommand("SELECT MAX(`id`) FROM `game`", db.GetConnection()))?.Rows[0][0]?.ToString());
                        db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams[i].id}', '{teams[i].name}', '{index}', '0')");
                        db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams[j].id}', '{teams[j].name}', '{index}', '0')");
                    }
                }
            }
            else if (tournament.type == "BattleRoyal")
            {
                db.ChangeData($"INSERT INTO `game` (`id`, `tournament_name`, `date`, `is_finished`) VALUES (NULL, '{tournament.name}', NULL, '0')");
                index = int.Parse(db.SelectRequest(new MySqlCommand("SELECT MAX(`id`) FROM `game`", db.GetConnection()))?.Rows[0][0]?.ToString());
                for (int i = 0; i < teams.Count; i++)
                    db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams[i].id}', '{teams[i].name}', '{index}', '0')");
            }

            tournament.isStarted = true;
        }

        public static List<Game> GetGames(Tournament tournament)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `game` WHERE `tournament_name` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = tournament.name;
            DataTable gamesTable = db.SelectRequest(cmd);

            List<Game> games = new List<Game>();
            for (int i = 0; i < gamesTable.Rows.Count; i++)
            {
                Game game = new Game
                {
                    id = int.Parse(gamesTable.Rows[i][0].ToString()),
                    tournament_name = gamesTable.Rows[i][1].ToString(),
                    date = (gamesTable.Rows[i][2] is DateTime) ? ((DateTime)gamesTable.Rows[i][2]).ToString("yyyy-MM-dd hh:mm:ss") : null,
                    isFinished = gamesTable.Rows[i][3].ToString() == "True"
                };
                games.Add(game);
            }

            return games;
        }
    }
}
