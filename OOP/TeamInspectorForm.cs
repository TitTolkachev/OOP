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
    public partial class TeamInspectorForm : Form
    {
        private MainForm mainForm;
        private string tournamentName;

        public TeamInspectorForm(MainForm mainForm, string tournamentName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, this.tournamentName));
        }

        private void TeamInspectorForm_Load(object sender, EventArgs e)
        {
            if (this.tournamentName != null)
                this.label4.Text = "Турнир: " + this.tournamentName;


            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT `name` FROM `team` WHERE `tournament` = @tN", db.GetConnection());
            cmd.Parameters.Add("@tN", MySqlDbType.VarChar).Value = tournamentName;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
                this.listBox1.Items.Add(table.Rows[i][0].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null && this.listBox1.SelectedItem != null)
                mainForm.PanelForm(new TeamCompositionForm(mainForm, this.tournamentName, this.listBox1.SelectedItem.ToString()));
        }
    }
}
