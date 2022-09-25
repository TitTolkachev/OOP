using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    public static class GameController
    {
        public static void GenerateGrid(Tournament tournament)
        {
            ITournamentType gridGenerator;

            if (tournament.type == "Circular")
                gridGenerator = new CircularTournamentType();
            else
                gridGenerator = new BattleRoyalTournamentType();

            gridGenerator.GenerateGrid(tournament);
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
                    tournamentName = gamesTable.Rows[i][1].ToString(),
                    date = (gamesTable.Rows[i][2] is DateTime) ? ((DateTime)gamesTable.Rows[i][2]).ToString("yyyy-MM-dd hh:mm:ss") : null,
                    isFinished = gamesTable.Rows[i][3].ToString() == "True"
                };
                games.Add(game);
            }

            return games;
        }
    }
}
