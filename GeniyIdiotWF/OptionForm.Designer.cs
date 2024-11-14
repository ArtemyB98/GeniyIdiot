



namespace GeniyIdiotWF
{
    partial class OptionForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            questionsDataGridView = new DataGridView();
            questionColumn = new DataGridViewButtonColumn();
            answerColumn = new DataGridViewButtonColumn();
            backMenuButton = new Button();
            addQuestionButton = new Button();
            newQustionTextBox = new TextBox();
            newQuestionLabel = new Label();
            newAnswerLabel = new Label();
            newAnswerTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            questionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            questionsDataGridView.BackgroundColor = Color.DarkSlateGray;
            questionsDataGridView.BorderStyle = BorderStyle.None;
            questionsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            questionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { questionColumn, answerColumn });
            questionsDataGridView.GridColor = Color.DarkSlateGray;
            questionsDataGridView.Location = new Point(29, 12);
            questionsDataGridView.MultiSelect = false;
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.Size = new Size(743, 243);
            questionsDataGridView.TabIndex = 0;
            questionsDataGridView.CellContentClick += questionsDataGridView_CellContentClick;
            // 
            // questionColumn
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Chocolate;
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            questionColumn.DefaultCellStyle = dataGridViewCellStyle3;
            questionColumn.HeaderText = "Question";
            questionColumn.Name = "questionColumn";
            questionColumn.Width = 500;
            // 
            // answerColumn
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Chocolate;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSlateGray;
            answerColumn.DefaultCellStyle = dataGridViewCellStyle4;
            answerColumn.HeaderText = "Answer";
            answerColumn.Name = "answerColumn";
            answerColumn.Resizable = DataGridViewTriState.True;
            answerColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            answerColumn.Width = 200;
            // 
            // backMenuButton
            // 
            backMenuButton.BackColor = Color.Transparent;
            backMenuButton.FlatAppearance.BorderSize = 0;
            backMenuButton.FlatStyle = FlatStyle.Flat;
            backMenuButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backMenuButton.ForeColor = Color.Red;
            backMenuButton.Location = new Point(303, 495);
            backMenuButton.Name = "backMenuButton";
            backMenuButton.Size = new Size(190, 54);
            backMenuButton.TabIndex = 1;
            backMenuButton.Text = "Back";
            backMenuButton.UseVisualStyleBackColor = false;
            backMenuButton.Click += backMenuButton_Click;
            // 
            // addQuestionButton
            // 
            addQuestionButton.BackColor = Color.Transparent;
            addQuestionButton.FlatAppearance.BorderSize = 0;
            addQuestionButton.FlatStyle = FlatStyle.Flat;
            addQuestionButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addQuestionButton.ForeColor = Color.Red;
            addQuestionButton.Location = new Point(220, 435);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(344, 54);
            addQuestionButton.TabIndex = 2;
            addQuestionButton.Text = "ADD NEW TASK";
            addQuestionButton.UseVisualStyleBackColor = false;
            addQuestionButton.Click += addQusetionButton_Click;
            // 
            // newQustionTextBox
            // 
            newQustionTextBox.BackColor = Color.DarkSlateGray;
            newQustionTextBox.Location = new Point(75, 303);
            newQustionTextBox.Name = "newQustionTextBox";
            newQustionTextBox.Size = new Size(645, 23);
            newQustionTextBox.TabIndex = 3;
            // 
            // newQuestionLabel
            // 
            newQuestionLabel.AutoSize = true;
            newQuestionLabel.BackColor = Color.Transparent;
            newQuestionLabel.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newQuestionLabel.ForeColor = Color.Red;
            newQuestionLabel.Location = new Point(75, 258);
            newQuestionLabel.Name = "newQuestionLabel";
            newQuestionLabel.Size = new Size(212, 33);
            newQuestionLabel.TabIndex = 5;
            newQuestionLabel.Text = "New Question";
            newQuestionLabel.UseMnemonic = false;
            // 
            // newAnswerLabel
            // 
            newAnswerLabel.AutoSize = true;
            newAnswerLabel.BackColor = Color.Transparent;
            newAnswerLabel.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newAnswerLabel.ForeColor = Color.Red;
            newAnswerLabel.Location = new Point(75, 352);
            newAnswerLabel.Name = "newAnswerLabel";
            newAnswerLabel.Size = new Size(125, 33);
            newAnswerLabel.TabIndex = 7;
            newAnswerLabel.Text = "Answer";
            newAnswerLabel.UseMnemonic = false;
            // 
            // newAnswerTextBox
            // 
            newAnswerTextBox.BackColor = Color.DarkSlateGray;
            newAnswerTextBox.Location = new Point(75, 397);
            newAnswerTextBox.Name = "newAnswerTextBox";
            newAnswerTextBox.Size = new Size(645, 23);
            newAnswerTextBox.TabIndex = 6;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 600);
            Controls.Add(newAnswerLabel);
            Controls.Add(newAnswerTextBox);
            Controls.Add(newQuestionLabel);
            Controls.Add(newQustionTextBox);
            Controls.Add(addQuestionButton);
            Controls.Add(backMenuButton);
            Controls.Add(questionsDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            Load += OptionForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView questionsDataGridView;
        private Button backMenuButton;
        private Button addQuestionButton;
        private TextBox newQustionTextBox;
        private Label newQuestionLabel;
        private Label newAnswerLabel;
        private TextBox newAnswerTextBox;
        private DataGridViewButtonColumn questionColumn;
        private DataGridViewButtonColumn answerColumn;
    }
}