namespace GeniyIdiotWF
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            newGameButton = new Button();
            userResultsButton = new Button();
            optionButton = new Button();
            exitGameButton = new Button();
            restartButton = new Button();
            SuspendLayout();
            // 
            // newGameButton
            // 
            newGameButton.BackColor = Color.Transparent;
            newGameButton.FlatAppearance.BorderSize = 0;
            newGameButton.FlatStyle = FlatStyle.Flat;
            newGameButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newGameButton.ForeColor = Color.Red;
            newGameButton.Location = new Point(200, 80);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(400, 48);
            newGameButton.TabIndex = 0;
            newGameButton.Text = "New game";
            newGameButton.UseVisualStyleBackColor = false;
            newGameButton.Click += newGameButton_Click;
            // 
            // userResultsButton
            // 
            userResultsButton.BackColor = Color.Transparent;
            userResultsButton.FlatAppearance.BorderSize = 0;
            userResultsButton.FlatStyle = FlatStyle.Flat;
            userResultsButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userResultsButton.ForeColor = Color.Red;
            userResultsButton.Location = new Point(200, 134);
            userResultsButton.Name = "userResultsButton";
            userResultsButton.Size = new Size(400, 48);
            userResultsButton.TabIndex = 1;
            userResultsButton.Text = "Results";
            userResultsButton.UseVisualStyleBackColor = false;
            userResultsButton.Click += userResultsButton_Click;
            // 
            // optionButton
            // 
            optionButton.BackColor = Color.Transparent;
            optionButton.FlatAppearance.BorderSize = 0;
            optionButton.FlatStyle = FlatStyle.Flat;
            optionButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optionButton.ForeColor = Color.Red;
            optionButton.Location = new Point(200, 188);
            optionButton.Name = "optionButton";
            optionButton.Size = new Size(400, 48);
            optionButton.TabIndex = 2;
            optionButton.Text = "Options";
            optionButton.UseVisualStyleBackColor = false;
            optionButton.Click += optionButton_Click;
            // 
            // exitGameButton
            // 
            exitGameButton.BackColor = Color.Transparent;
            exitGameButton.FlatAppearance.BorderSize = 0;
            exitGameButton.FlatStyle = FlatStyle.Flat;
            exitGameButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitGameButton.ForeColor = Color.Red;
            exitGameButton.Location = new Point(200, 296);
            exitGameButton.Name = "exitGameButton";
            exitGameButton.Size = new Size(400, 48);
            exitGameButton.TabIndex = 4;
            exitGameButton.Text = "Exit";
            exitGameButton.UseVisualStyleBackColor = false;
            exitGameButton.Click += exitGameButton_Click;
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Transparent;
            restartButton.FlatAppearance.BorderSize = 0;
            restartButton.FlatStyle = FlatStyle.Flat;
            restartButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restartButton.ForeColor = Color.Red;
            restartButton.Location = new Point(200, 242);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(400, 48);
            restartButton.TabIndex = 5;
            restartButton.Text = "RESTART";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 600);
            Controls.Add(restartButton);
            Controls.Add(exitGameButton);
            Controls.Add(optionButton);
            Controls.Add(userResultsButton);
            Controls.Add(newGameButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newGameButton;
        private Button userResultsButton;
        private Button optionButton;
        private Button exitGameButton;
        private Button restartButton;
    }
}