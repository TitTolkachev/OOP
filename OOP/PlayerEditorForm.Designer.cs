namespace OOP
{
    partial class PlayerEditorForm
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
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.CreatePlayerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SexMaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.SexFemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.NumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.WeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ToTournamentBtn = new System.Windows.Forms.Button();
            this.ToTeamBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.ItemHeight = 16;
            this.PlayersListBox.Location = new System.Drawing.Point(179, 113);
            this.PlayersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(243, 164);
            this.PlayersListBox.TabIndex = 0;
            // 
            // CreatePlayerBtn
            // 
            this.CreatePlayerBtn.Location = new System.Drawing.Point(657, 295);
            this.CreatePlayerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreatePlayerBtn.Name = "CreatePlayerBtn";
            this.CreatePlayerBtn.Size = new System.Drawing.Size(100, 28);
            this.CreatePlayerBtn.TabIndex = 2;
            this.CreatePlayerBtn.Text = "Создать";
            this.CreatePlayerBtn.UseVisualStyleBackColor = true;
            this.CreatePlayerBtn.Click += new System.EventHandler(this.CreatePlayerBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Рост";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(640, 50);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 22);
            this.NameTextBox.TabIndex = 10;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(640, 84);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(132, 22);
            this.SurnameTextBox.TabIndex = 11;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(640, 121);
            this.BirthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.BirthdayDateTimePicker.TabIndex = 12;
            this.BirthdayDateTimePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // SexMaleRadioBtn
            // 
            this.SexMaleRadioBtn.AutoSize = true;
            this.SexMaleRadioBtn.Checked = true;
            this.SexMaleRadioBtn.Location = new System.Drawing.Point(640, 151);
            this.SexMaleRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SexMaleRadioBtn.Name = "SexMaleRadioBtn";
            this.SexMaleRadioBtn.Size = new System.Drawing.Size(54, 20);
            this.SexMaleRadioBtn.TabIndex = 13;
            this.SexMaleRadioBtn.TabStop = true;
            this.SexMaleRadioBtn.Text = "муж";
            this.SexMaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SexFemaleRadioBtn
            // 
            this.SexFemaleRadioBtn.AutoSize = true;
            this.SexFemaleRadioBtn.Location = new System.Drawing.Point(704, 151);
            this.SexFemaleRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SexFemaleRadioBtn.Name = "SexFemaleRadioBtn";
            this.SexFemaleRadioBtn.Size = new System.Drawing.Size(53, 20);
            this.SexFemaleRadioBtn.TabIndex = 14;
            this.SexFemaleRadioBtn.Text = "жен";
            this.SexFemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(640, 181);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.NumberTextBox.TabIndex = 15;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(640, 214);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.WeightTextBox.TabIndex = 16;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.AllowPromptAsInput = false;
            this.HeightTextBox.BeepOnError = true;
            this.HeightTextBox.Location = new System.Drawing.Point(640, 244);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.HeightTextBox.TabIndex = 17;
            // 
            // ToTournamentBtn
            // 
            this.ToTournamentBtn.Location = new System.Drawing.Point(355, 357);
            this.ToTournamentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToTournamentBtn.Name = "ToTournamentBtn";
            this.ToTournamentBtn.Size = new System.Drawing.Size(125, 44);
            this.ToTournamentBtn.TabIndex = 18;
            this.ToTournamentBtn.Text = "В турнир";
            this.ToTournamentBtn.UseVisualStyleBackColor = true;
            this.ToTournamentBtn.Click += new System.EventHandler(this.ToTournamentBtnClick);
            // 
            // ToTeamBtn
            // 
            this.ToTeamBtn.Location = new System.Drawing.Point(519, 357);
            this.ToTeamBtn.Name = "ToTeamBtn";
            this.ToTeamBtn.Size = new System.Drawing.Size(127, 44);
            this.ToTeamBtn.TabIndex = 19;
            this.ToTeamBtn.Text = "Команда";
            this.ToTeamBtn.UseVisualStyleBackColor = true;
            this.ToTeamBtn.Click += new System.EventHandler(this.ToTeamBtnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(173, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Свободные игроки";
            // 
            // PlayerEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ToTeamBtn);
            this.Controls.Add(this.ToTournamentBtn);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.SexFemaleRadioBtn);
            this.Controls.Add(this.SexMaleRadioBtn);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreatePlayerBtn);
            this.Controls.Add(this.PlayersListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayerEditorForm";
            this.Text = "PlayerEditorForm";
            this.Load += new System.EventHandler(this.PlayerEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.Button CreatePlayerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.RadioButton SexMaleRadioBtn;
        private System.Windows.Forms.RadioButton SexFemaleRadioBtn;
        private System.Windows.Forms.MaskedTextBox NumberTextBox;
        private System.Windows.Forms.MaskedTextBox WeightTextBox;
        private System.Windows.Forms.MaskedTextBox HeightTextBox;
        private System.Windows.Forms.Button ToTournamentBtn;
        private System.Windows.Forms.Button ToTeamBtn;
        private System.Windows.Forms.Label label8;
    }
}