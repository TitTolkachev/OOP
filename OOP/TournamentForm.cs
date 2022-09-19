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
    public partial class TournamentForm : Form
    {
        private MainForm mainForm;
        private string tournamentName;

        public TournamentForm(MainForm mainForm, string tournamentName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
            this.label1.Text = "Турнир: " + tournamentName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tournamentName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.PanelForm(new LobbyForm(mainForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null)
                mainForm.PanelForm(new TeamInspectorForm(mainForm, this.tournamentName));
        }
    }
}
