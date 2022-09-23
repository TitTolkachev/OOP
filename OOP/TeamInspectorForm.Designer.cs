namespace OOP
{
    partial class TeamInspectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddedTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.ToTournamentBtn = new System.Windows.Forms.Button();
            this.AddTeamBtn = new System.Windows.Forms.Button();
            this.ToTeamBtn = new System.Windows.Forms.Button();
            this.TeamsListBox = new System.Windows.Forms.ListBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.RemoveTeamBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Команды:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название команды";
            // 
            // AddedTeamNameTextBox
            // 
            this.AddedTeamNameTextBox.Location = new System.Drawing.Point(613, 176);
            this.AddedTeamNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddedTeamNameTextBox.Name = "AddedTeamNameTextBox";
            this.AddedTeamNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.AddedTeamNameTextBox.TabIndex = 4;
            // 
            // ToTournamentBtn
            // 
            this.ToTournamentBtn.Location = new System.Drawing.Point(465, 369);
            this.ToTournamentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToTournamentBtn.Name = "ToTournamentBtn";
            this.ToTournamentBtn.Size = new System.Drawing.Size(179, 71);
            this.ToTournamentBtn.TabIndex = 8;
            this.ToTournamentBtn.Text = "В турнир";
            this.ToTournamentBtn.UseVisualStyleBackColor = true;
            this.ToTournamentBtn.Click += new System.EventHandler(this.ToTournamentBtnClick);
            // 
            // AddTeamBtn
            // 
            this.AddTeamBtn.Location = new System.Drawing.Point(612, 217);
            this.AddTeamBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddTeamBtn.Name = "AddTeamBtn";
            this.AddTeamBtn.Size = new System.Drawing.Size(156, 54);
            this.AddTeamBtn.TabIndex = 9;
            this.AddTeamBtn.Text = "Добавить команду";
            this.AddTeamBtn.UseVisualStyleBackColor = true;
            this.AddTeamBtn.Click += new System.EventHandler(this.AddTeamBtnClick);
            // 
            // ToTeamBtn
            // 
            this.ToTeamBtn.Location = new System.Drawing.Point(247, 283);
            this.ToTeamBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToTeamBtn.Name = "ToTeamBtn";
            this.ToTeamBtn.Size = new System.Drawing.Size(137, 57);
            this.ToTeamBtn.TabIndex = 12;
            this.ToTeamBtn.Text = "Перейти к команде";
            this.ToTeamBtn.UseVisualStyleBackColor = true;
            this.ToTeamBtn.Click += new System.EventHandler(this.ToTeamBtnClick);
            // 
            // TeamsListBox
            // 
            this.TeamsListBox.FormattingEnabled = true;
            this.TeamsListBox.ItemHeight = 16;
            this.TeamsListBox.Location = new System.Drawing.Point(247, 176);
            this.TeamsListBox.Name = "TeamsListBox";
            this.TeamsListBox.Size = new System.Drawing.Size(297, 100);
            this.TeamsListBox.TabIndex = 13;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TournamentNameLabel.Location = new System.Drawing.Point(241, 64);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(245, 31);
            this.TournamentNameLabel.TabIndex = 14;
            this.TournamentNameLabel.Text = "Название турнира";
            // 
            // RemoveTeamBtn
            // 
            this.RemoveTeamBtn.Location = new System.Drawing.Point(400, 283);
            this.RemoveTeamBtn.Name = "RemoveTeamBtn";
            this.RemoveTeamBtn.Size = new System.Drawing.Size(144, 57);
            this.RemoveTeamBtn.TabIndex = 15;
            this.RemoveTeamBtn.Text = "Расформировать";
            this.RemoveTeamBtn.UseVisualStyleBackColor = true;
            this.RemoveTeamBtn.Click += new System.EventHandler(this.RemoveTeamBtnClick);
            // 
            // TeamInspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RemoveTeamBtn);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.TeamsListBox);
            this.Controls.Add(this.ToTeamBtn);
            this.Controls.Add(this.AddTeamBtn);
            this.Controls.Add(this.ToTournamentBtn);
            this.Controls.Add(this.AddedTeamNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamInspectorForm";
            this.Text = "TeamInspectorForm";
            this.Load += new System.EventHandler(this.TeamInspectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddedTeamNameTextBox;
        private System.Windows.Forms.Button ToTournamentBtn;
        private System.Windows.Forms.Button AddTeamBtn;
        private System.Windows.Forms.Button ToTeamBtn;
        private System.Windows.Forms.ListBox TeamsListBox;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.Button RemoveTeamBtn;
    }
}