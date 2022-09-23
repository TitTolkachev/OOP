using System.Collections.Generic;

namespace OOP
{
    public static class Controller
    {
        public static List<Tournament> GetTournaments()
        {
            return TournamentController.GetTournaments();
        }

        public static void CreateTournament(string name, string type, bool sexSeparation)
        {
            TournamentController.CreateTournament(name, type, sexSeparation);
        }

        public static Tournament GetTournamentByName(string name)
        {
            return TournamentController.GetTournamentByName(name);
        }

        public static void GenerateGrid(Tournament tournament)
        {
            GameController.GenerateGrid(tournament);
        }

        public static List<Game> GetGames(Tournament tournament)
        {
            return GameController.GetGames(tournament);
        }

        public static List<Player> GetFreePlayers()
        {
            return PlayerController.GetFreePlayers();
        }

        public static void AddPlayer(Player player)
        {
            PlayerController.AddPlayer(player);
        }
    }
}
