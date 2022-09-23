using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    public partial class PlayerEditorForm : Form
    {
        MainForm mainForm;
        Tournament tournament;
        Team team;
        List<Player> players;

        public PlayerEditorForm(MainForm mainForm, Tournament tournament, Team team)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournament = tournament;
            this.team = team;
            players = team.GetPlayers();
        }

        private void PlayerEditorForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < players.Count; i++)
                PlayersListBox.Items.Add(players[i].name + ' ' + players[i].surname);
        }

        private void ToTournamentBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TournamentForm(mainForm, tournament));
        }

        private void ToTeamBtnClick(object sender, EventArgs e)
        {
            mainForm.PanelForm(new TeamCompositionForm(mainForm, tournament, team));
        }

        private void CreatePlayerBtnClick(object sender, EventArgs e)
        {
            if (NameTextBox.Text != null && NameTextBox.Text.Trim(' ') != ""
                && SurnameTextBox.Text != null && SurnameTextBox.Text.Trim(' ') != ""
                && BirthdayDateTimePicker.Text != null && BirthdayDateTimePicker.Text.Trim(' ') != ""
                && NumberTextBox.Text != null && NumberTextBox.Text.Trim(' ') != ""
                && WeightTextBox.Text != null && WeightTextBox.Text.Trim(' ') != ""
                && HeightTextBox.Text != null && HeightTextBox.Text.Trim(' ') != "")
            {
                Controller.AddPlayer(new Player()
                {
                    name = NameTextBox.Text,
                    surname = SurnameTextBox.Text,
                    birthday = DateTime.Parse(BirthdayDateTimePicker.Text),
                    sex = SexMaleRadioBtn.Checked ? "Муж" : "Жен",
                    number = int.Parse(NumberTextBox.Text),
                    weight = int.Parse(WeightTextBox.Text),
                    height = int.Parse(HeightTextBox.Text),
                    teamId = team.id,
                });

                mainForm.PanelForm(new PlayerEditorForm(mainForm, tournament, team));
            }
            else
                MessageBox.Show("Ошибка ввода");
        }
    }
}
