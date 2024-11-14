namespace GeniyIdiotWF
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            welcomeLabel = new Label();
            startGameButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.Red;
            welcomeLabel.ImageAlign = ContentAlignment.MiddleRight;
            welcomeLabel.Location = new Point(114, 513);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(540, 46);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "GENIY                                            IDIOT";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            welcomeLabel.Click += startGameButton_Click;
            // 
            // startGameButton
            // 
            startGameButton.BackColor = Color.Transparent;
            startGameButton.FlatStyle = FlatStyle.Popup;
            startGameButton.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startGameButton.ForeColor = Color.Red;
            startGameButton.Location = new Point(294, 482);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(200, 77);
            startGameButton.TabIndex = 1;
            startGameButton.Text = "CHECK";
            startGameButton.UseVisualStyleBackColor = false;
            startGameButton.Click += startGameButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 561);
            Controls.Add(startGameButton);
            Controls.Add(welcomeLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button startGameButton;
    }
}