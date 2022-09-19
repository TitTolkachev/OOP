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
        string teamName;

        public PlayerEditorForm(MainForm mainForm, string tournamentName, string teamName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tournamentName = tournamentName;
            this.teamName = teamName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null)
                mainForm.PanelForm(new TournamentForm(mainForm, this.tournamentName));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm != null && this.tournamentName != null && this.teamName != null)
                mainForm.PanelForm(new TeamCompositionForm(mainForm, this.tournamentName, this.teamName));
        }
    }
}
