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
    public partial class MainForm : Form
    {
        private Form active;

        public MainForm()
        {
            InitializeComponent();
        }

        public void PanelForm(Form form)
        {
            if (active != null)
                active.Close();

            active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PanelForm(new LobbyForm(this));
        }
    }
}
