using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    public class Game
    {
        public int id { get; set; }
        public string tournament_name { get; set; }
        private string _date;
        public string date
        {
            get { return _date; }
            set
            {
                if (value != null && value != "")
                {
                    _date = value;
                    DB db = new DB();
                    db.ChangeData($"UPDATE `game` SET `date` = '{value}' WHERE `game`.`id` = {id}");
                }
            }
        }
        public bool isFinished { get; set; }

        public void Finish()
        {
            isFinished = true;

            DB db = new DB();
            db.ChangeData($"UPDATE `game` SET `is_finished` = '1' WHERE `game`.`id` = {id}");

            List<GameTeamRelation> gameTeamRelations = GetRelations();

            int teamPoints;
            int maxPoints = 0;
            for (int i = 0; i < gameTeamRelations.Count; i++)
            {
                teamPoints = int.Parse(db.SelectRequest(new MySqlCommand($"SELECT `points` FROM `team` WHERE `id`='{gameTeamRelations[i].teamId}'", db.GetConnection()))?.Rows[0][0]?.ToString());
                teamPoints += gameTeamRelations[i].teamPoints;
                db.ChangeData($"UPDATE `team` SET `points` = '{teamPoints}' WHERE `team`.`id` = '{gameTeamRelations[i].teamId}'");
                if (gameTeamRelations[i].teamPoints > maxPoints)
                    maxPoints = gameTeamRelations[i].teamPoints;
            }

            int teamWins;
            for (int i = 0; i < gameTeamRelations.Count; i++)
            {
                if (gameTeamRelations[i].teamPoints == maxPoints)
                {
                    teamWins = int.Parse(db.SelectRequest(new MySqlCommand($"SELECT `wins` FROM `team` WHERE `id`='{gameTeamRelations[i].teamId}'", db.GetConnection()))?.Rows[0][0]?.ToString());
                    db.ChangeData($"UPDATE `team` SET `wins` = '{teamWins + 1}' WHERE `team`.`id` = '{gameTeamRelations[i].teamId}'");
                }
            }
        }

        public List<GameTeamRelation> GetRelations()
        {
            DB db = new DB();
            DataTable gameTeamTable = db.SelectRequest(new MySqlCommand("SELECT * FROM `game-team` WHERE `game_id` = " + id + " ORDER BY `team_points` DESC", db.GetConnection()));

            List<GameTeamRelation> relations = new List<GameTeamRelation>();
            for (int i = 0; i < gameTeamTable.Rows.Count; i++)
            {
                relations.Add(new GameTeamRelation()
                {
                    teamId = int.Parse(gameTeamTable.Rows[i][0].ToString()),
                    teamName = gameTeamTable.Rows[i][1].ToString(),
                    gameId = int.Parse(gameTeamTable.Rows[i][2].ToString()),
                    teamPoints = int.Parse(gameTeamTable.Rows[i][3].ToString())
                });
            }

            return relations;
        }
    }
}
