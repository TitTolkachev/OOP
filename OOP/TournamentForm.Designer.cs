namespace OOP
{
    partial class TournamentForm
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
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.ToLobbyBtn = new System.Windows.Forms.Button();
            this.ToTeamsBtn = new System.Windows.Forms.Button();
            this.GamesListBox = new System.Windows.Forms.ListBox();
            this.GenerateGridBtn = new System.Windows.Forms.Button();
            this.SumUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TournamentNameLabel.Location = new System.Drawing.Point(293, 67);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(245, 31);
            this.TournamentNameLabel.TabIndex = 1;
            this.TournamentNameLabel.Text = "Название турнира";
            // 
            // ToLobbyBtn
            // 
            this.ToLobbyBtn.Location = new System.Drawing.Point(299, 356);
            this.ToLobbyBtn.Name = "ToLobbyBtn";
            this.ToLobbyBtn.Size = new System.Drawing.Size(129, 51);
            this.ToLobbyBtn.TabIndex = 2;
            this.ToLobbyBtn.Text = "Домой";
            this.ToLobbyBtn.UseVisualStyleBackColor = true;
            this.ToLobbyBtn.Click += new System.EventHandler(this.ToLobbyBtnClick);
            // 
            // ToTeamsBtn
            // 
            this.ToTeamsBtn.Location = new System.Drawing.Point(434, 356);
            this.ToTeamsBtn.Name = "ToTeamsBtn";
            this.ToTeamsBtn.Size = new System.Drawing.Size(145, 51);
            this.ToTeamsBtn.TabIndex = 3;
            this.ToTeamsBtn.Text = "Команды";
            this.ToTeamsBtn.UseVisualStyleBackColor = true;
            this.ToTeamsBtn.Click += new System.EventHandler(this.ToTeamsBtnClick);
            // 
            // GamesListBox
            // 
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.ItemHeight = 16;
            this.GamesListBox.Location = new System.Drawing.Point(299, 149);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(415, 148);
            this.GamesListBox.TabIndex = 4;
            this.GamesListBox.DoubleClick += new System.EventHandler(this.ShowGameDialogForm);
            // 
            // GenerateGridBtn
            // 
            this.GenerateGridBtn.Location = new System.Drawing.Point(741, 190);
            this.GenerateGridBtn.Name = "GenerateGridBtn";
            this.GenerateGridBtn.Size = new System.Drawing.Size(129, 72);
            this.GenerateGridBtn.TabIndex = 5;
            this.GenerateGridBtn.Text = "Сгенерировать сетку";
            this.GenerateGridBtn.UseVisualStyleBackColor = true;
            this.GenerateGridBtn.Click += new System.EventHandler(this.GenerateGridBtnClick);
            // 
            // SumUpBtn
            // 
            this.SumUpBtn.Location = new System.Drawing.Point(585, 356);
            this.SumUpBtn.Name = "SumUpBtn";
            this.SumUpBtn.Size = new System.Drawing.Size(129, 51);
            this.SumUpBtn.TabIndex = 6;
            this.SumUpBtn.Text = "Подвести итоги";
            this.SumUpBtn.UseVisualStyleBackColor = true;
            this.SumUpBtn.Click += new System.EventHandler(this.SumUpBtnClick);
            // 
            // TournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SumUpBtn);
            this.Controls.Add(this.GenerateGridBtn);
            this.Controls.Add(this.GamesListBox);
            this.Controls.Add(this.ToTeamsBtn);
            this.Controls.Add(this.ToLobbyBtn);
            this.Controls.Add(this.TournamentNameLabel);
            this.Name = "TournamentForm";
            this.Text = "TournamentForm";
            this.Load += new System.EventHandler(this.TournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.Button ToLobbyBtn;
        private System.Windows.Forms.Button ToTeamsBtn;
        private System.Windows.Forms.ListBox GamesListBox;
        private System.Windows.Forms.Button GenerateGridBtn;
        private System.Windows.Forms.Button SumUpBtn;
    }
}