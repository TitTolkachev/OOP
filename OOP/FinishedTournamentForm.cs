using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OOP
{
    public partial class FinishedTournamentForm : Form
    {
        private MainForm mainForm;
        private string tournamentName;
        private DataTable teamsTable;

        public FinishedTournamentForm(MainForm mainForm, string tournamentName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.PanelForm(new LobbyForm(mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FinishedTournamentForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Турнир: {tournamentName}";

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT `id`, `name`, `wins`, `points` FROM `team` WHERE `tournament` = @tN ORDER BY `wins` DESC, `points` DESC", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = tournamentName;

            teamsTable = db.SelectRequest(cmd);

            for (int i = 0; i < teamsTable.Rows.Count; i++)
                listBox1.Items.Add($"{i+1} место - {teamsTable.Rows[i][2]} wins, {teamsTable.Rows[i][3]} points - {teamsTable.Rows[i][1]}");
        }

        private void ShowTeamComposition(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if(listBox1.SelectedItem != null)
            {
                int selectedTeamIndex = int.Parse(teamsTable.Rows[listBox1.SelectedIndex][0].ToString());

                DB db = new DB();
                MySqlCommand cmd = new MySqlCommand("SELECT `id`, `name`, `surname` FROM `player` WHERE `team_id` = @tI", db.GetConnection());
                cmd.Parameters.Add("@tI", MySqlDbType.VarChar).Value = selectedTeamIndex;

                DataTable table = db.SelectRequest(cmd);

                for (int i = 0; i < table.Rows.Count; i++)
                    listBox2.Items.Add($"{i+1}: {table.Rows[i][1]} {table.Rows[i][2]}");
            }
        }
    }
}
