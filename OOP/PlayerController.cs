using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    public static class PlayerController
    {
        public static List<Player> GetFreePlayers()
        {
            DB db = new DB();
            DataTable freePlayersTable = db.SelectRequest(new MySqlCommand("SELECT * FROM `player` WHERE `team_id` IS null", db.GetConnection()));

            List<Player> freePlayers = new List<Player>();
            for (int i = 0; i < freePlayersTable.Rows.Count; i++)
            {
                freePlayers.Add(new Player()
                {
                    id = int.Parse(freePlayersTable.Rows[i][0].ToString()),
                    name = freePlayersTable.Rows[i][1].ToString(),
                    surname = freePlayersTable.Rows[i][2].ToString(),
                    birthday = DateTime.Parse(freePlayersTable.Rows[i][3].ToString()),
                    sex = freePlayersTable.Rows[i][4].ToString(),
                    number = int.Parse(freePlayersTable.Rows[i][5].ToString()),
                    weight = int.Parse(freePlayersTable.Rows[i][6].ToString()),
                    height = int.Parse(freePlayersTable.Rows[i][7].ToString()),
                    teamId = int.Parse(freePlayersTable.Rows[i][8].ToString())
                });
            }

            return freePlayers;
        }

        public static void AddPlayer(Player player)
        {
            DB db = new DB();
            db.ChangeData("INSERT INTO `player` (`name`, `surname`, `birthday`, `sex`, `number`, `weight`, `height`, `team_id`) VALUES('"
                + player.name + "', '" + player.surname + "', '" + player.birthday + "', '"
            + player.sex + "', '0', '" + player.number + "', '" + player.weight + "', '" + player.height + "', '" + player.id + "')");
        }
    }
}
