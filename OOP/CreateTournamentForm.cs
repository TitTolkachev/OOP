using System;
using System.Windows.Forms;

namespace OOP
{
    public partial class CreateTournamentForm : Form
    {
        private MainForm mainForm;

        public CreateTournamentForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ToLobbyBtnClick(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.PanelForm(new LobbyForm(mainForm));
        }

        private void CreateTournamentBtnClick(object sender, EventArgs e)
        {
            if (Controller.GetTournamentByName(TournamentNameTextBox.Text.Trim(' ')) == null)
            {
                if (TournamentNameTextBox.Text.Trim(' ') != "")
                {
                    if (TournamentTypeComboBox.SelectedItem != null)
                    {
                        string tournamentType;
                        if (TournamentTypeComboBox.SelectedIndex == 0)
                            tournamentType = "Circular";
                        else
                            tournamentType = "BattleRoyal";

                        Controller.CreateTournament(TournamentNameTextBox.Text.Trim(' '), tournamentType, SexSeparationCheckBox.Checked);

                        if (mainForm != null)
                            mainForm.PanelForm(new TeamInspectorForm(mainForm, Controller.GetTournamentByName(TournamentNameTextBox.Text.ToString())));
                    }
                    else
                        MessageBox.Show("Выберите тип турнира!");
                }
                else
                    MessageBox.Show("Название турнира не может быть пустым!");
            }
            else
                MessageBox.Show("Турнир с таким названием уже существует!");
        }
    }
}
