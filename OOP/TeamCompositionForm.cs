using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    public partial class TeamCompositionForm : Form
    {
        MainForm mainForm;
        Tournament tournament;
        Team team;
        List<Player> players;
        List<Player> freePlayers;

        public TeamCompositionForm(MainForm mainForm, Tournament tournament, Team team)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournament = tournament;
            this.team = team;
            players = team.GetPlayers();
            freePlayers = Controller.GetFreePlayers();
        }

        private void TeamCompositionForm_Load(object sender, EventArgs e)
        {
            TeamNameLabel.Text = "Команда: " + team.name;

            for (int i = 0; i < players.Count; i++)
                PlayersListBox.Items.Add(players[i].name + ' ' + players[i].surname);

            for (int i = 0; i < freePlayers.Count; i++)
                PlayersComboBox.Items.Add(freePlayers[i].name + ' ' + freePlayers[i].surname);
        }

        private void ToToutnamentBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void ToTeamsBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TeamInspectorForm(mainForm, tournament));
        }

        private void ToPlayerEditorBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new PlayerEditorForm(mainForm, tournament, team));
        }

        private void AddPlayerBtnClick(object sender, EventArgs e)
        {
            if (PlayersComboBox.SelectedItem != null)
            {
                team.Add(freePlayers[PlayersComboBox.SelectedIndex]);
                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournament, team));
            }
        }

        private void RemovePlayerBtnClick(object sender, EventArgs e)
        {
            if (PlayersListBox.SelectedItem != null)
            {
                team.Remove(players[PlayersListBox.SelectedIndex]);
                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournament, team));
            }
        }
    }
}
