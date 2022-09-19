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
    public partial class TeamCompositionForm : Form
    {
        MainForm mainForm;
        string tournamentName;
        string teamName;

        public TeamCompositionForm(MainForm mainForm, string tournamentName, string teamName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
            this.teamName = teamName;
        }

        private void TeamCompositionForm_Load(object sender, EventArgs e)
        {
            if (this.teamName != null)
                this.label2.Text = "Команда: " + teamName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, this.tournamentName));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null)
                mainForm.PanelForm(new TeamInspectorForm(mainForm, this.tournamentName));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null && this.teamName != null)
                mainForm.PanelForm(new PlayerEditorForm(mainForm, this.tournamentName, this.teamName));
        }
    }
}
