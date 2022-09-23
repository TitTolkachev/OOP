namespace OOP
{
    partial class GameDialogForm
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
            this.UpdateDateBtn = new System.Windows.Forms.Button();
            this.TeamsTextBox = new System.Windows.Forms.ListBox();
            this.FinishGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamPointsTextBox = new System.Windows.Forms.TextBox();
            this.SetTeamPointsBtn = new System.Windows.Forms.Button();
            this.GameDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateDateBtn
            // 
            this.UpdateDateBtn.Location = new System.Drawing.Point(666, 163);
            this.UpdateDateBtn.Name = "UpdateDateBtn";
            this.UpdateDateBtn.Size = new System.Drawing.Size(111, 61);
            this.UpdateDateBtn.TabIndex = 0;
            this.UpdateDateBtn.Text = "Обновить дату";
            this.UpdateDateBtn.UseVisualStyleBackColor = true;
            this.UpdateDateBtn.Click += new System.EventHandler(this.UpdateDateBtnClick);
            // 
            // TeamsTextBox
            // 
            this.TeamsTextBox.FormattingEnabled = true;
            this.TeamsTextBox.ItemHeight = 16;
            this.TeamsTextBox.Location = new System.Drawing.Point(255, 70);
            this.TeamsTextBox.Name = "TeamsTextBox";
            this.TeamsTextBox.Size = new System.Drawing.Size(227, 148);
            this.TeamsTextBox.TabIndex = 1;
            // 
            // FinishGameBtn
            // 
            this.FinishGameBtn.Location = new System.Drawing.Point(665, 245);
            this.FinishGameBtn.Name = "FinishGameBtn";
            this.FinishGameBtn.Size = new System.Drawing.Size(112, 61);
            this.FinishGameBtn.TabIndex = 2;
            this.FinishGameBtn.Text = "Завершить матч";
            this.FinishGameBtn.UseVisualStyleBackColor = true;
            this.FinishGameBtn.Click += new System.EventHandler(this.FinishGameBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Очки";
            // 
            // TeamPointsTextBox
            // 
            this.TeamPointsTextBox.Location = new System.Drawing.Point(255, 274);
            this.TeamPointsTextBox.Name = "TeamPointsTextBox";
            this.TeamPointsTextBox.Size = new System.Drawing.Size(100, 22);
            this.TeamPointsTextBox.TabIndex = 4;
            // 
            // SetTeamPointsBtn
            // 
            this.SetTeamPointsBtn.Location = new System.Drawing.Point(382, 264);
            this.SetTeamPointsBtn.Name = "SetTeamPointsBtn";
            this.SetTeamPointsBtn.Size = new System.Drawing.Size(100, 43);
            this.SetTeamPointsBtn.TabIndex = 5;
            this.SetTeamPointsBtn.Text = "Задать";
            this.SetTeamPointsBtn.UseVisualStyleBackColor = true;
            this.SetTeamPointsBtn.Click += new System.EventHandler(this.SetTeamPointsBtnClick);
            // 
            // GameDateTimePicker
            // 
            this.GameDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.GameDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GameDateTimePicker.Location = new System.Drawing.Point(625, 107);
            this.GameDateTimePicker.Name = "GameDateTimePicker";
            this.GameDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.GameDateTimePicker.TabIndex = 6;
            this.GameDateTimePicker.Value = new System.DateTime(2022, 9, 9, 0, 0, 0, 0);
            // 
            // ToTournamentBtn
            // 
            this.ToTournamentBtn.Location = new System.Drawing.Point(505, 344);
            this.ToTournamentBtn.Name = "ToTournamentBtn";
            this.ToTournamentBtn.Size = new System.Drawing.Size(133, 50);
            this.ToTournamentBtn.TabIndex = 7;
            this.ToTournamentBtn.Text = "В турнир";
            this.ToTournamentBtn.UseVisualStyleBackColor = true;
            this.ToTournamentBtn.Click += new System.EventHandler(this.ToTournamentBtnClick);
            // 
            // GameDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ToTournamentBtn);
            this.Controls.Add(this.GameDateTimePicker);
            this.Controls.Add(this.SetTeamPointsBtn);
            this.Controls.Add(this.TeamPointsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishGameBtn);
            this.Controls.Add(this.TeamsTextBox);
            this.Controls.Add(this.UpdateDateBtn);
            this.Name = "GameDialogForm";
            this.Text = "GameDialogForm";
            this.Load += new System.EventHandler(this.GameDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateDateBtn;
        private System.Windows.Forms.ListBox TeamsTextBox;
        private System.Windows.Forms.Button FinishGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeamPointsTextBox;
        private System.Windows.Forms.Button SetTeamPointsBtn;
        private System.Windows.Forms.DateTimePicker GameDateTimePicker;
        private System.Windows.Forms.Button ToTournamentBtn;
    }
}