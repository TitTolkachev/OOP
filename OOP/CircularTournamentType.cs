using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace OOP
{
    public class CircularTournamentType : ITournamentType
    {
        public void GenerateGrid(Tournament tournament)
        {
            DB db = new DB();
            List<Team> teams = tournament.GetTeams();

            int index;
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
    }
}
