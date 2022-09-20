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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    public partial class TeamCompositionForm : Form
    {
        MainForm mainForm;
        string tournamentName;
        string teamId;
        DataTable teamPlayersTable;
        DataTable freePlayersTable;

        public TeamCompositionForm(MainForm mainForm, string tournamentName, string teamId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
            this.teamId = teamId;
        }

        private void TeamCompositionForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            teamPlayersTable = db.SelectRequest(new MySqlCommand("SELECT `id`, `name`, `surname` FROM `player` WHERE `team_id`=" + teamId, db.GetConnection()));
            freePlayersTable = db.SelectRequest(new MySqlCommand("SELECT `id`, `name`, `surname` FROM `player` WHERE `team_id` IS null", db.GetConnection()));

            for (int i = 0; i < teamPlayersTable.Rows.Count; i++)
                listBox1.Items.Add(teamPlayersTable.Rows[i][1].ToString() + ' ' + teamPlayersTable.Rows[i][2].ToString());
            for (int i = 0; i < freePlayersTable.Rows.Count; i++)
                comboBox1.Items.Add(freePlayersTable.Rows[i][1].ToString() + ' ' + freePlayersTable.Rows[i][2].ToString());

            if (teamId != null)
            {
                DataTable table = db.SelectRequest(new MySqlCommand("SELECT `name` FROM `team` WHERE `id`=" + teamId, db.GetConnection()));

                label2.Text = "Команда: " + table?.Rows[0][0]?.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
                mainForm.PanelForm(new TeamInspectorForm(mainForm, tournamentName));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null && teamId != null)
                mainForm.PanelForm(new PlayerEditorForm(mainForm, tournamentName, teamId));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                DB db = new DB();
                db.ChangeData("UPDATE `player` SET `team_id`="+teamId+" WHERE `id`=" + freePlayersTable.Rows[comboBox1.SelectedIndex][0].ToString());

                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournamentName, teamId));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DB db = new DB();
                db.ChangeData("UPDATE `player` SET `team_id`=null WHERE `id`=" + teamPlayersTable.Rows[listBox1.SelectedIndex][0].ToString());

                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournamentName, teamId));
            }
        }
    }
}
