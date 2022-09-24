using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    public partial class GameDialogForm : Form
    {
        MainForm mainForm;
        Tournament tournament;
        Game game;
        List<GameTeamRelation> gameTeamRelations;

        public GameDialogForm(MainForm mainForm, Game game)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.game = game;
            tournament = Controller.GetTournamentByName(game.tournament_name);
            gameTeamRelations = game.GetRelations();
        }

        private void GameDialogForm_Load(object sender, EventArgs e)
        {
            if (game.isFinished)
            {
                UpdateDateBtn.Enabled = false;
                FinishGameBtn.Enabled = false;
                SetTeamPointsBtn.Enabled = false;
            }

            for (int i = 0; i < gameTeamRelations.Count; i++)
                TeamsTextBox.Items.Add(gameTeamRelations[i].teamName + " - " + gameTeamRelations[i].teamPoints.ToString());
        }

        private void ToTournamentBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void UpdateDateBtnClick(object sender, EventArgs e)
        {
            game.date = GameDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void FinishGameBtnClick(object sender, EventArgs e)
        {
            game.Finish();
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void SetTeamPointsBtnClick(object sender, EventArgs e)
        {
            if (TeamPointsTextBox.Text != "" && TeamsTextBox.SelectedItem != null)
            {
                gameTeamRelations[TeamsTextBox.SelectedIndex].SetTeamPoints(int.Parse(TeamPointsTextBox.Text));
                mainForm.PanelForm(new GameDialogForm(mainForm, game));
            }
        }
    }
}
