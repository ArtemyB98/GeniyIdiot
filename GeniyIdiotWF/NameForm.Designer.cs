namespace GeniyIdiotWF
{
    partial class NameForm
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
            nameTextBox = new TextBox();
            startGameButton = new Button();
            nameLabel = new Label();
            startInformationLable = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.ForeColor = Color.Red;
            nameTextBox.Location = new Point(112, 65);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(159, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // startGameButton
            // 
            startGameButton.BackColor = Color.Transparent;
            startGameButton.FlatAppearance.BorderSize = 0;
            startGameButton.FlatStyle = FlatStyle.Flat;
            startGameButton.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGameButton.Location = new Point(138, 103);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(100, 35);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "START";
            startGameButton.UseVisualStyleBackColor = false;
            startGameButton.Click += startGameButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.Red;
            nameLabel.Location = new Point(36, 23);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(311, 27);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Hello! What is your name?";
            nameLabel.Click += nameLabel_Click;
            // 
            // startInformationLable
            // 
            startInformationLable.AutoSize = true;
            startInformationLable.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startInformationLable.Location = new Point(12, 149);
            startInformationLable.Name = "startInformationLable";
            startInformationLable.Size = new Size(0, 20);
            startInformationLable.TabIndex = 3;
            startInformationLable.Click += startInformationLable_Click;
            // 
            // NameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(384, 273);
            Controls.Add(startInformationLable);
            Controls.Add(nameLabel);
            Controls.Add(startGameButton);
            Controls.Add(nameTextBox);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "NameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NameForm";
            Load += NameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox nameTextBox;
        private Button startGameButton;
        private Label nameLabel;
        private Label startInformationLable;
    }
}