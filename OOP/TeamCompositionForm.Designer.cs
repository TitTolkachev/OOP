namespace OOP
{
    partial class TeamCompositionForm
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
            this.AddPlayerBtn = new System.Windows.Forms.Button();
            this.PlayersComboBox = new System.Windows.Forms.ComboBox();
            this.ToPlayerEditorBtn = new System.Windows.Forms.Button();
            this.ToToutnamentBtn = new System.Windows.Forms.Button();
            this.RemovePlayerBtn = new System.Windows.Forms.Button();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.ToTeamsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Состав";
            // 
            // AddPlayerBtn
            // 
            this.AddPlayerBtn.Location = new System.Drawing.Point(564, 169);
            this.AddPlayerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddPlayerBtn.Name = "AddPlayerBtn";
            this.AddPlayerBtn.Size = new System.Drawing.Size(100, 28);
            this.AddPlayerBtn.TabIndex = 2;
            this.AddPlayerBtn.Text = "Добавить";
            this.AddPlayerBtn.UseVisualStyleBackColor = true;
            this.AddPlayerBtn.Click += new System.EventHandler(this.AddPlayerBtnClick);
            // 
            // PlayersComboBox
            // 
            this.PlayersComboBox.FormattingEnabled = true;
            this.PlayersComboBox.Location = new System.Drawing.Point(564, 110);
            this.PlayersComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlayersComboBox.Name = "PlayersComboBox";
            this.PlayersComboBox.Size = new System.Drawing.Size(160, 24);
            this.PlayersComboBox.TabIndex = 3;
            // 
            // ToPlayerEditorBtn
            // 
            this.ToPlayerEditorBtn.Location = new System.Drawing.Point(644, 306);
            this.ToPlayerEditorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToPlayerEditorBtn.Name = "ToPlayerEditorBtn";
            this.ToPlayerEditorBtn.Size = new System.Drawing.Size(147, 52);
            this.ToPlayerEditorBtn.TabIndex = 4;
            this.ToPlayerEditorBtn.Text = "Редактор игроков";
            this.ToPlayerEditorBtn.UseVisualStyleBackColor = true;
            this.ToPlayerEditorBtn.Click += new System.EventHandler(this.ToPlayerEditorBtnClick);
            // 
            // ToToutnamentBtn
            // 
            this.ToToutnamentBtn.Location = new System.Drawing.Point(268, 306);
            this.ToToutnamentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToToutnamentBtn.Name = "ToToutnamentBtn";
            this.ToToutnamentBtn.Size = new System.Drawing.Size(160, 52);
            this.ToToutnamentBtn.TabIndex = 6;
            this.ToToutnamentBtn.Text = "В турнир";
            this.ToToutnamentBtn.UseVisualStyleBackColor = true;
            this.ToToutnamentBtn.Click += new System.EventHandler(this.ToToutnamentBtnClick);
            // 
            // RemovePlayerBtn
            // 
            this.RemovePlayerBtn.Location = new System.Drawing.Point(351, 159);
            this.RemovePlayerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RemovePlayerBtn.Name = "RemovePlayerBtn";
            this.RemovePlayerBtn.Size = new System.Drawing.Size(100, 28);
            this.RemovePlayerBtn.TabIndex = 8;
            this.RemovePlayerBtn.Text = "Выгнать";
            this.RemovePlayerBtn.UseVisualStyleBackColor = true;
            this.RemovePlayerBtn.Click += new System.EventHandler(this.RemovePlayerBtnClick);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamNameLabel.Location = new System.Drawing.Point(377, 35);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(257, 31);
            this.TeamNameLabel.TabIndex = 10;
            this.TeamNameLabel.Text = "Название команды";
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.ItemHeight = 16;
            this.PlayersListBox.Location = new System.Drawing.Point(162, 113);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(166, 164);
            this.PlayersListBox.TabIndex = 11;
            // 
            // ToTeamsBtn
            // 
            this.ToTeamsBtn.Location = new System.Drawing.Point(462, 306);
            this.ToTeamsBtn.Name = "ToTeamsBtn";
            this.ToTeamsBtn.Size = new System.Drawing.Size(151, 52);
            this.ToTeamsBtn.TabIndex = 12;
            this.ToTeamsBtn.Text = "Команды";
            this.ToTeamsBtn.UseVisualStyleBackColor = true;
            this.ToTeamsBtn.Click += new System.EventHandler(this.ToTeamsBtnClick);
            // 
            // TeamCompositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ToTeamsBtn);
            this.Controls.Add(this.PlayersListBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.RemovePlayerBtn);
            this.Controls.Add(this.ToToutnamentBtn);
            this.Controls.Add(this.ToPlayerEditorBtn);
            this.Controls.Add(this.PlayersComboBox);
            this.Controls.Add(this.AddPlayerBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamCompositionForm";
            this.Text = "TeamCompositionForm";
            this.Load += new System.EventHandler(this.TeamCompositionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPlayerBtn;
        private System.Windows.Forms.ComboBox PlayersComboBox;
        private System.Windows.Forms.Button ToPlayerEditorBtn;
        private System.Windows.Forms.Button ToToutnamentBtn;
        private System.Windows.Forms.Button RemovePlayerBtn;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.Button ToTeamsBtn;
    }
}