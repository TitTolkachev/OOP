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
    public partial class CreateTournamentForm : Form
    {
        private MainForm mainForm;

        public CreateTournamentForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.PanelForm(new LobbyForm(mainForm));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand cmd = new MySqlCommand("SELECT `name` FROM `team` WHERE `tournament` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = textBox1.Text;

            DataTable table = db.SelectRequest(cmd);

            if (table.Rows.Count == 0)
            {
                if (textBox1.Text.Trim(' ') != "")
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        string tournamentType;
                        if (comboBox1.SelectedIndex == 0)
                            tournamentType = "Olympic";
                        else if (comboBox1.SelectedIndex == 1)
                            tournamentType = "Circular";
                        else
                            tournamentType = "BattleRoyal";

                        db.ChangeData("INSERT INTO `tournament` (`name`, `type`, `sex_separation`, `is_finished`) VALUES('"
                            + textBox1.Text + "', '" + tournamentType + "', '"
                            + (checkBox1.Checked ? 1 : 0).ToString() + "', '0')");

                        if (mainForm != null)
                            mainForm.PanelForm(new TeamInspectorForm(mainForm, this.textBox1.Text.ToString()));
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
