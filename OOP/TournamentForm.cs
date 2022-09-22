using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class TournamentForm : Form
    {
        private MainForm mainForm;
        private string tournamentName;
        private DataTable gamesTable;

        public TournamentForm(MainForm mainForm, string tournamentName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT `type` FROM `tournament` WHERE `name` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = tournamentName;
            DataTable table = db.SelectRequest(cmd);

            db.ChangeData($"DELETE FROM `game` WHERE `tournament_name` = '{tournamentName}'");
            DataTable teams = db.SelectRequest(new MySqlCommand(
                $"SELECT * FROM `team` WHERE `tournament` = '{tournamentName}'",
                db.GetConnection()));

            int index;
            if (table.Rows[0][0]?.ToString() == "Circular")
            {
                for(int i = 1; i < teams.Rows.Count; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        db.ChangeData($"INSERT INTO `game` (`id`, `tournament_name`, `date`, `is_finished`) VALUES (NULL, '{tournamentName}', NULL, '0')");
                        index = int.Parse(db.SelectRequest(new MySqlCommand("SELECT MAX(`id`) FROM `game`", db.GetConnection()))?.Rows[0][0]?.ToString());
                        db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams.Rows[i][0]}', '{teams.Rows[i][1]}', '{index}', '0')");
                        db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams.Rows[j][0]}', '{teams.Rows[j][1]}', '{index}', '0')");
                    }
                }
            }
            else if(table.Rows[0][0]?.ToString() == "BattleRoyal")
            {
                //for (int i = 1; i < teams.Rows.Count; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        db.ChangeData($"INSERT INTO `game` (`id`, `tournament_name`, `date`, `is_finished`) VALUES (NULL, '{tournamentName}', NULL, '0')");
                //        index = int.Parse(db.SelectRequest(new MySqlCommand("SELECT MAX(`id`) FROM `game`", db.GetConnection()))?.Rows[0][0]?.ToString());
                //        db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams.Rows[i][0]}', '{teams.Rows[i][1]}', '{index}', '0')");
                //        db.ChangeData($"INSERT INTO `game-team` (`team_id`, `team_name`, `game_id`, `team_points`) VALUES ('{teams.Rows[j][0]}', '{teams.Rows[j][1]}', '{index}', '0')");
                //    }
                //}
            }

            mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.PanelForm(new LobbyForm(mainForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
                mainForm.PanelForm(new TeamInspectorForm(mainForm, tournamentName));
        }

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Турнир: " + tournamentName;

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT `id`, `date`, `is_finished` FROM `game` WHERE `tournament_name` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = tournamentName;
            gamesTable = db.SelectRequest(cmd);

            for (int i = 0; i < gamesTable.Rows.Count; i++)
            {
                if(gamesTable.Rows[i][1].ToString() != "") 
                    listBox1.Items.Add($"Game {i + 1}: date - {gamesTable.Rows[i][1]}, is finished - {gamesTable.Rows[i][2]}");
                else
                    listBox1.Items.Add($"Game {i + 1}: date - not set, is finished - {gamesTable.Rows[i][2]}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //подвести итоги
        }

        private void ShowGameDialogForm(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                if (mainForm != null && tournamentName != null)
                    mainForm.PanelForm(new GameDialogForm(mainForm, gamesTable.Rows[listBox1.SelectedIndex][0]?.ToString()));
            }
        }
    }
}
