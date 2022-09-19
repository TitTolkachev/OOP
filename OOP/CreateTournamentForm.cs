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
            if (mainForm != null)
                mainForm.PanelForm(new TeamInspectorForm(mainForm, this.textBox1.Text.ToString()));
        }
    }
}
