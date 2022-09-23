using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    public partial class TournamentForm : Form
    {
        private MainForm mainForm;
        private Tournament tournament;
        private List<Game> games;

        public TournamentForm(MainForm mainForm, Tournament tournament)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournament = tournament;
            games = tournament.GetGames();
        }

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            TournamentNameLabel.Text = "Турнир: " + tournament.name;

            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].date.ToString() != "")
                    GamesListBox.Items.Add($"Game {i + 1}: date - {games[i].date}, is finished - {games[i].isFinished}");
                else
                    GamesListBox.Items.Add($"Game {i + 1}: date - not set, is finished - {games[i].isFinished}");
            }

            if (tournament.isStarted)
            {
                GenerateGridBtn.Enabled = false;
                ToTeamsBtn.Enabled = false;
            }
        }

        private void GenerateGridBtnClick(object sender, EventArgs e)
        {
            Controller.GenerateGrid(tournament);
            tournament.isStarted = true;
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void ToLobbyBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new LobbyForm(mainForm));
        }

        private void ToTeamsBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TeamInspectorForm(mainForm, tournament));
        }

        private void SumUpBtnClick(object sender, EventArgs e)
        {
            tournament.isFinished = true;
            mainForm.PanelForm(new FinishedTournamentForm(mainForm, tournament.name));
        }

        private void ShowGameDialogForm(object sender, EventArgs e)
        {
            if (GamesListBox.SelectedItem != null)
                mainForm.PanelForm(new GameDialogForm(mainForm, games[GamesListBox.SelectedIndex]));
        }
    }
}
