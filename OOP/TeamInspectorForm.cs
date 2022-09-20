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
using MySqlX.XDevAPI.Relational;

namespace OOP
{
    public partial class TeamInspectorForm : Form
    {
        MainForm mainForm;
        string tournamentName;
        DataTable teamsTable;

        public TeamInspectorForm(MainForm mainForm, string tournamentName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
        }

        private void TeamInspectorForm_Load(object sender, EventArgs e)
        {
            if (tournamentName != null)
                label4.Text = "Турнир: " + tournamentName;

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT `id`, `name` FROM `team` WHERE `tournament` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = tournamentName;

            teamsTable = db.SelectRequest(cmd);

            for (int i = 0; i < teamsTable.Rows.Count; i++)
                listBox1.Items.Add(teamsTable.Rows[i][1].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null && listBox1.SelectedItem != null)
                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournamentName, teamsTable.Rows[listBox1.SelectedIndex][0].ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < teamsTable.Rows.Count; i++)
                if (teamsTable?.Rows[i][1]?.ToString() == textBox1.Text.Trim(' '))
                    flag = false;

            if (flag)
            {
                if (textBox1.Text.Trim(' ') != "")
                {
                    DB db = new DB();
                    db.ChangeData("INSERT INTO `team` (`name`, `tournament`) VALUES('"
                        + textBox1.Text.Trim(' ') + "', '" + tournamentName + "')");

                    mainForm.PanelForm(new TeamInspectorForm(mainForm, tournamentName));
                }
                else
                    MessageBox.Show("Название команды не может быть пустым!");
            }
            else
                MessageBox.Show("Команда с таким названием уже существует!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                DB db = new DB();
                db.ChangeData("DELETE FROM `team` WHERE `id`=" + teamsTable.Rows[listBox1.SelectedIndex][0].ToString());

                mainForm.PanelForm(new TeamInspectorForm(mainForm, tournamentName));
            }
        }
    }
}
