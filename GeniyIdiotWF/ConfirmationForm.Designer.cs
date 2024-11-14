namespace GeniyIdiotWF
{
    partial class ConfirmationForm
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
            confirmationLabel = new Label();
            yesButton = new Button();
            noButton = new Button();
            SuspendLayout();
            // 
            // confirmationLabel
            // 
            confirmationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            confirmationLabel.AutoSize = true;
            confirmationLabel.BackColor = Color.Transparent;
            confirmationLabel.FlatStyle = FlatStyle.Flat;
            confirmationLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmationLabel.ForeColor = Color.Red;
            confirmationLabel.Location = new Point(29, 44);
            confirmationLabel.Name = "confirmationLabel";
            confirmationLabel.Size = new Size(132, 15);
            confirmationLabel.TabIndex = 0;
            confirmationLabel.Text = "Confirmation text";
            confirmationLabel.Click += confirmationLabel_Click;
            // 
            // yesButton
            // 
            yesButton.BackColor = Color.Transparent;
            yesButton.FlatAppearance.BorderSize = 0;
            yesButton.FlatStyle = FlatStyle.Flat;
            yesButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yesButton.ForeColor = Color.Red;
            yesButton.Location = new Point(16, 100);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(75, 23);
            yesButton.TabIndex = 1;
            yesButton.Text = "yes";
            yesButton.UseVisualStyleBackColor = false;
            yesButton.Click += yesButton_Click;
            // 
            // noButton
            // 
            noButton.BackColor = Color.Transparent;
            noButton.FlatAppearance.BorderSize = 0;
            noButton.FlatStyle = FlatStyle.Flat;
            noButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noButton.ForeColor = Color.Red;
            noButton.Location = new Point(97, 100);
            noButton.Name = "noButton";
            noButton.Size = new Size(75, 23);
            noButton.TabIndex = 2;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = false;
            noButton.Click += noButton_Click;
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(184, 161);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(confirmationLabel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmationForm";
            Load += ConfirmationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label confirmationLabel;
        private Button yesButton;
        private Button noButton;
    }
}