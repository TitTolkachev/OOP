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
    public partial class PlayerEditorForm : Form
    {
        MainForm mainForm;
        string tournamentName;
        string teamId;
        DataTable playersTable;

        public PlayerEditorForm(MainForm mainForm, string tournamentName, string teamId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
            this.teamId = teamId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, tournamentName));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null && teamId != null)
                mainForm.PanelForm(new TeamCompositionForm(mainForm, tournamentName, teamId));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null && teamId != null)
            {
                if (textBox1.Text != null && textBox1.Text.Trim(' ') != ""
                    && textBox2.Text != null && textBox2.Text.Trim(' ') != ""
                    && dateTimePicker1.Text != null && dateTimePicker1.Text.Trim(' ') != ""
                    && maskedTextBox1.Text != null && maskedTextBox1.Text.Trim(' ') != ""
                    && maskedTextBox2.Text != null && maskedTextBox2.Text.Trim(' ') != ""
                    && maskedTextBox3.Text != null && maskedTextBox3.Text.Trim(' ') != "")
                {
                    DB db = new DB();

                    db.ChangeData("INSERT INTO `player` (`name`, `surname`, `birthday`, `sex`, `self_time`, `number`, `weight`, `height`, `points`) VALUES('"
                        + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker1.Text + "', '"
                    + (radioButton1.Checked ? "Муж" : "Жен") + "', '0', '" + maskedTextBox1.Text + "', '" + maskedTextBox2.Text + "', '" + maskedTextBox3.Text + "', '0')");

                    mainForm.PanelForm(new PlayerEditorForm(mainForm, tournamentName, teamId));
                }
                else
                    MessageBox.Show("Ошибка ввода");
            }
        }

        private void PlayerEditorForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            playersTable = db.SelectRequest(new MySqlCommand("SELECT `id`, `name`, `surname` FROM `player`", db.GetConnection()));

            for (int i = 0; i < playersTable.Rows.Count; i++)
                listBox1.Items.Add(playersTable.Rows[i][1].ToString() + ' ' + playersTable.Rows[i][2].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm != null && tournamentName != null && teamId != null && listBox1.SelectedItem != null)
            {
                DB db = new DB();

                db.ChangeData("DELETE FROM `player` WHERE `id`=" + playersTable.Rows[listBox1.SelectedIndex][0].ToString());

                mainForm.PanelForm(new PlayerEditorForm(mainForm, tournamentName, teamId));
            }
        }
    }
}
