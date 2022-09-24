namespace OOP
{
    public class GameTeamRelation
    {
        public int teamId;
        public string teamName;
        public int gameId;
        public int teamPoints;

        public void SetTeamPoints(int teamPoints)
        {
            DB db = new DB();
            db.ChangeData($"UPDATE `game-team` SET `team_points` = '{teamPoints}' WHERE (`game-team`.`game_id` = {gameId} AND `game-team`.`team_id` = {teamId})");
        }
    }
}
