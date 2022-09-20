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
    public partial class LobbyForm : Form
    {
        private MainForm mainForm;

        public LobbyForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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

        private void LobbyForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand cmd = new MySqlCommand("SELECT `name` FROM `tournament`", db.GetConnection());

            DataTable table = db.SelectRequest(cmd);

            for (int i = 0; i < table.Rows.Count; i++)
                this.comboBox1.Items.Add(table.Rows[i][0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.comboBox1.SelectedItem != null)
                mainForm.PanelForm(new TournamentForm(mainForm, this.comboBox1.SelectedItem.ToString()));
            else
                MessageBox.Show("Выберете турнир или создайте новый!");
        }
    }
}
