using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    public partial class LobbyForm : Form
    {
        MainForm mainForm;
        List<Tournament> tournaments;

        public LobbyForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void LobbyForm_Load(object sender, EventArgs e)
        {
            tournaments = Controller.GetTournaments();
            for (int i = 0; i < tournaments.Count; i++)
                comboBox1.Items.Add(tournaments[i].name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mainForm != null)
                mainForm.PanelForm(new CreateTournamentForm(mainForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null && comboBox1.SelectedItem != null)
            {
                if (!tournaments[comboBox1.SelectedIndex].isFinished)
                    mainForm.PanelForm(new TournamentForm(mainForm, tournaments[comboBox1.SelectedIndex]));
                else
                    mainForm.PanelForm(new FinishedTournamentForm(mainForm, comboBox1.SelectedItem.ToString()));
            }
            else
                MessageBox.Show("Выберете турнир или создайте новый!");
        }
    }
}
