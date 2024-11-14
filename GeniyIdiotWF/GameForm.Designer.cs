namespace GeniyIdiotWF
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            userAnswerTextBox = new TextBox();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            nextButton = new Button();
            questionTimer = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            SuspendLayout();
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.BackColor = Color.DarkSlateGray;
            userAnswerTextBox.BorderStyle = BorderStyle.None;
            userAnswerTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userAnswerTextBox.ForeColor = Color.Red;
            userAnswerTextBox.Location = new Point(260, 435);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(303, 32);
            userAnswerTextBox.TabIndex = 0;
            userAnswerTextBox.TextAlign = HorizontalAlignment.Center;
            userAnswerTextBox.TextChanged += textBox1_TextChanged;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.BackColor = Color.Transparent;
            questionNumberLabel.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionNumberLabel.ForeColor = Color.Red;
            questionNumberLabel.Location = new Point(12, 32);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(220, 46);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Question 1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.BackColor = Color.DarkSlateGray;
            questionTextLabel.FlatStyle = FlatStyle.Flat;
            questionTextLabel.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionTextLabel.ForeColor = Color.Red;
            questionTextLabel.Location = new Point(59, 402);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(151, 23);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Text of question...";
            questionTextLabel.Click += questionTextLabel_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.Transparent;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.Red;
            nextButton.Location = new Point(233, 494);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(350, 94);
            nextButton.TabIndex = 3;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // questionTimer
            // 
            questionTimer.Interval = 1000;
            questionTimer.Tick += questionTimer_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = Color.Red;
            timerLabel.Location = new Point(635, 502);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(99, 79);
            timerLabel.TabIndex = 4;
            timerLabel.Text = "10";
            timerLabel.Click += timerLabel_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 600);
            Controls.Add(timerLabel);
            Controls.Add(questionTextLabel);
            Controls.Add(nextButton);
            Controls.Add(questionNumberLabel);
            Controls.Add(userAnswerTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeniyIdiot";
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userAnswerTextBox;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private Button nextButton;
        private System.Windows.Forms.Timer questionTimer;
        private Label timerLabel;
    }
}
