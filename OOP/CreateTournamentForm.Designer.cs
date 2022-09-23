namespace OOP
{
    partial class CreateTournamentForm
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
            this.TournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SexSeparationCheckBox = new System.Windows.Forms.CheckBox();
            this.ToLobbyBtn = new System.Windows.Forms.Button();
            this.CreateTournamentBtn = new System.Windows.Forms.Button();
            this.TournamentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TournamentNameTextBox
            // 
            this.TournamentNameTextBox.Location = new System.Drawing.Point(119, 111);
            this.TournamentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TournamentNameTextBox.Name = "TournamentNameTextBox";
            this.TournamentNameTextBox.Size = new System.Drawing.Size(220, 22);
            this.TournamentNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название турнира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Система проведения турнира";
            // 
            // SexSeparationCheckBox
            // 
            this.SexSeparationCheckBox.AutoSize = true;
            this.SexSeparationCheckBox.Location = new System.Drawing.Point(119, 282);
            this.SexSeparationCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SexSeparationCheckBox.Name = "SexSeparationCheckBox";
            this.SexSeparationCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SexSeparationCheckBox.Size = new System.Drawing.Size(183, 20);
            this.SexSeparationCheckBox.TabIndex = 4;
            this.SexSeparationCheckBox.Text = "Гендерное разделение";
            this.SexSeparationCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToLobbyBtn
            // 
            this.ToLobbyBtn.Location = new System.Drawing.Point(184, 374);
            this.ToLobbyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToLobbyBtn.Name = "ToLobbyBtn";
            this.ToLobbyBtn.Size = new System.Drawing.Size(100, 28);
            this.ToLobbyBtn.TabIndex = 5;
            this.ToLobbyBtn.Text = "Домой";
            this.ToLobbyBtn.UseVisualStyleBackColor = true;
            this.ToLobbyBtn.Click += new System.EventHandler(this.ToLobbyBtnClick);
            // 
            // CreateTournamentBtn
            // 
            this.CreateTournamentBtn.Location = new System.Drawing.Point(345, 374);
            this.CreateTournamentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTournamentBtn.Name = "CreateTournamentBtn";
            this.CreateTournamentBtn.Size = new System.Drawing.Size(100, 28);
            this.CreateTournamentBtn.TabIndex = 6;
            this.CreateTournamentBtn.Text = "Далее";
            this.CreateTournamentBtn.UseVisualStyleBackColor = true;
            this.CreateTournamentBtn.Click += new System.EventHandler(this.CreateTournamentBtnClick);
            // 
            // TournamentTypeComboBox
            // 
            this.TournamentTypeComboBox.FormattingEnabled = true;
            this.TournamentTypeComboBox.Items.AddRange(new object[] {
            "Круговая",
            "Королевская битва"});
            this.TournamentTypeComboBox.Location = new System.Drawing.Point(123, 210);
            this.TournamentTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TournamentTypeComboBox.Name = "TournamentTypeComboBox";
            this.TournamentTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.TournamentTypeComboBox.TabIndex = 7;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.TournamentTypeComboBox);
            this.Controls.Add(this.CreateTournamentBtn);
            this.Controls.Add(this.ToLobbyBtn);
            this.Controls.Add(this.SexSeparationCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTournamentForm";
            this.Text = "TournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TournamentNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SexSeparationCheckBox;
        private System.Windows.Forms.Button ToLobbyBtn;
        private System.Windows.Forms.Button CreateTournamentBtn;
        private System.Windows.Forms.ComboBox TournamentTypeComboBox;
    }
}