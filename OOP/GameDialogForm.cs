using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace OOP
{
    public partial class GameDialogForm : Form
    {
        MainForm mainForm;
        Tournament tournament;
        Game game;

        DataTable gameTeamsTable;

        public GameDialogForm(MainForm mainForm, Game game)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.game = game;
            tournament = Controller.GetTournamentByName(game.tournament_name);
        }

        private void GameDialogForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            gameTeamsTable = db.SelectRequest(new MySqlCommand("SELECT `team_id`, `team_name`, `team_points` FROM `game-team` WHERE `game_id` = " + game.id + " ORDER BY `team_points` DESC", db.GetConnection()));

            GameDateTimePicker.Text = game.date.ToString();

            if (game.isFinished)
            {
                UpdateDateBtn.Enabled = false;
                FinishGameBtn.Enabled = false;
                SetTeamPointsBtn.Enabled = false;
            }

            for (int i = 0; i < gameTeamsTable.Rows.Count; i++)
                TeamsTextBox.Items.Add(gameTeamsTable.Rows[i][1].ToString() + " - " + gameTeamsTable.Rows[i][2].ToString());
        }

        private void ToTournamentBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void UpdateDateBtnClick(object sender, EventArgs e)
        {
            game.date = DateTime.Parse(GameDateTimePicker.Text);
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void FinishGameBtnClick(object sender, EventArgs e)
        {
            DB db = new DB();
            db.ChangeData($"UPDATE `game` SET `is_finished` = '1' WHERE `game`.`id` = {game.id}");

            int teamPonts;
            int maxPoints = 0;
            for (int i = 0; i < gameTeamsTable.Rows.Count; i++)
            {
                teamPonts = int.Parse(db.SelectRequest(new MySqlCommand($"SELECT `points` FROM `team` WHERE `id`='{gameTeamsTable?.Rows[i][0]}'", db.GetConnection()))?.Rows[0][0]?.ToString());
                teamPonts += int.Parse(gameTeamsTable?.Rows[i][2]?.ToString());
                db.ChangeData($"UPDATE `team` SET `points` = '{teamPonts}' WHERE `team`.`id` = '{gameTeamsTable?.Rows[i][0]}'");
                if (int.Parse(gameTeamsTable?.Rows[i][2]?.ToString()) > maxPoints)
                    maxPoints = int.Parse(gameTeamsTable?.Rows[i][2]?.ToString());
            }

            int teamWins;
            for (int i = 0; i < gameTeamsTable.Rows.Count; i++)
            {
                if (int.Parse(gameTeamsTable?.Rows[i][2]?.ToString()) == maxPoints)
                {
                    teamWins = int.Parse(db.SelectRequest(new MySqlCommand($"SELECT `wins` FROM `team` WHERE `id`='{gameTeamsTable?.Rows[i][0]}'", db.GetConnection()))?.Rows[0][0]?.ToString());
                    db.ChangeData($"UPDATE `team` SET `wins` = '{teamWins + 1}' WHERE `team`.`id` = '{gameTeamsTable?.Rows[i][0]}'");
                }
            }

            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void SetTeamPointsBtnClick(object sender, EventArgs e)
        {
            if (TeamPointsTextBox.Text != "" && TeamsTextBox.SelectedItem != null)
            {
                DB db = new DB();
                db.ChangeData($"UPDATE `game-team` SET `team_points` = '{TeamPointsTextBox.Text}' WHERE (`game-team`.`game_id` = {game.id} AND `game-team`.`team_id` = {gameTeamsTable.Rows[TeamsTextBox.SelectedIndex][0]})");

                mainForm.PanelForm(new GameDialogForm(mainForm, game));
            }
        }
    }
}
