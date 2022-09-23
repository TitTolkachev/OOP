using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    public partial class TeamInspectorForm : Form
    {
        MainForm mainForm;
        Tournament tournament;
        List<Team> teams;

        public TeamInspectorForm(MainForm mainForm, Tournament tournament)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournament = tournament;
            teams = tournament.GetTeams();
        }

        private void ToTournamentBtnClick(object sender, EventArgs e)
        {
            if (mainForm != null && tournament.name != null)
                mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void TeamInspectorForm_Load(object sender, EventArgs e)
        {
            if (tournament.name != null)
                TournamentNameLabel.Text = "Турнир: " + tournament.name;

            for (int i = 0; i < teams.Count; i++)
                TeamsListBox.Items.Add(teams[i].name);
        }

        private void ToTeamBtnClick(object sender, EventArgs e)
        {
            if (mainForm != null && tournament.name != null && TeamsListBox.SelectedItem != null)
                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournament, teams[TeamsListBox.SelectedIndex]));
        }

        private void AddTeamBtnClick(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < teams.Count; i++)
                if (teams[i].name == AddedTeamNameTextBox.Text.Trim(' '))
                    flag = false;

            if (flag)
            {
                if (AddedTeamNameTextBox.Text.Trim(' ') != "")
                {
                    tournament.AddTeam(AddedTeamNameTextBox.Text.Trim(' '));
                    mainForm.PanelForm(new TeamInspectorForm(mainForm, tournament));
                }
                else
                    MessageBox.Show("Название команды не может быть пустым!");
            }
            else
                MessageBox.Show("Команда с таким названием уже существует!");
        }

        private void RemoveTeamBtnClick(object sender, EventArgs e)
        {
            if(TeamsListBox.SelectedItem != null)
            {
                tournament.RemoveTeam(teams[TeamsListBox.SelectedIndex].id);
                mainForm.PanelForm(new TeamInspectorForm(mainForm, tournament));
            }
        }
    }
}
