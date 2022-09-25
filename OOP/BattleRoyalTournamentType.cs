using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace OOP
{
    public class BattleRoyalTournamentType : ITournamentType
    {
        public void GenerateGrid(Tournament tournament)
        {
            DB db = new DB();
            List<Team> teams = tournament.GetTeams();

            int index;

            db.ChangeData($"INSERT INTO `game` (`id`, `tournament_name`, `date`, `is_finished`) VALUES (NULL, '{tournament.name}', NULL, '0')");
            index = int.Parse(db.SelectRequest(new MySqlCommand("SELECT MAX(`id`) FROM `game`", db.GetConnection()))?.Rows[0][0]?.ToString());
            for (int i = 0; i < teams.Count; i++)
                db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams[i].id}', '{teams[i].name}', '{index}', '0')");
        }
    }
}
