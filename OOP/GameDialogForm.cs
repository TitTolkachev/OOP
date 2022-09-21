using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class GameDialogForm : Form
    {
        private MainForm mainForm;
        private string gameId;
        private string tournamentName;
        private string gameDate;
        private bool gameIsFinished;
        DataTable gameTeamsTable;

        public GameDialogForm(MainForm mainForm, string gameId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.gameId = gameId;
        }

        private void GameDialogForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = db.SelectRequest(new MySqlCommand("SELECT `tournament_name`, `date`, `is_finished` FROM `game` WHERE `id` = " + gameId, db.GetConnection()));
            tournamentName = table.Rows[0][0]?.ToString();
            gameDate = table.Rows[0][1]?.ToString();
            gameIsFinished = table.Rows[0][2]?.ToString() == "True";

            gameTeamsTable = db.SelectRequest(new MySqlCommand("SELECT `team_id`, `team_name`, `team_points` FROM `game-team` WHERE `game_id` = " + gameId, db.GetConnection()));

            dateTimePicker1.Text = gameDate;

            if (gameIsFinished)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }

            for (int i = 0; i < gameTeamsTable.Rows.Count; i++)
                listBox1.Items.Add(gameTeamsTable.Rows[i][1].ToString() + " - " + gameTeamsTable.Rows[i][2].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
            {
                DB db = new DB();
                db.ChangeData($"UPDATE `game` SET `date` = '{dateTimePicker1.Text}' WHERE `game`.`id` = {gameId}");

                mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
            {
                DB db = new DB();
                db.ChangeData($"UPDATE `game` SET `is_finished` = '1' WHERE `game`.`id` = {gameId}");

                mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null && textBox1.Text != "" && listBox1.SelectedItem != null)
            {
                DB db = new DB();
                db.ChangeData($"UPDATE `game-team` SET `team_points` = '{textBox1.Text}' WHERE (`game-team`.`game_id` = {gameId} AND `game-team`.`team_id` = {gameTeamsTable.Rows[listBox1.SelectedIndex][0]})");

                mainForm.PanelForm(new GameDialogForm(mainForm, gameId));
            }
        }
    }
}
