namespace GeniyIdiotWF
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            resultsDataGridView = new DataGridView();
            backButton = new Button();
            nameColumn = new DataGridViewTextBoxColumn();
            rightAnswersCntColumn = new DataGridViewTextBoxColumn();
            diagnoseColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.BackgroundColor = Color.DarkSlateGray;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameColumn, rightAnswersCntColumn, diagnoseColumn });
            resultsDataGridView.GridColor = Color.DarkSlateGray;
            resultsDataGridView.Location = new Point(68, 22);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.Size = new Size(643, 472);
            resultsDataGridView.TabIndex = 0;
            resultsDataGridView.CellContentClick += resutlsDataGridView_CellContentClick;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(319, 522);
            backButton.Name = "backButton";
            backButton.Size = new Size(159, 48);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // nameColumn
            // 
            dataGridViewCellStyle1.BackColor = Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateGray;
            nameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 400;
            // 
            // rightAnswersCntColumn
            // 
            dataGridViewCellStyle2.BackColor = Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateGray;
            rightAnswersCntColumn.DefaultCellStyle = dataGridViewCellStyle2;
            rightAnswersCntColumn.HeaderText = "Right Answers";
            rightAnswersCntColumn.Name = "rightAnswersCntColumn";
            // 
            // diagnoseColumn
            // 
            dataGridViewCellStyle3.BackColor = Color.Chocolate;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            diagnoseColumn.DefaultCellStyle = dataGridViewCellStyle3;
            diagnoseColumn.HeaderText = "Diagnose";
            diagnoseColumn.Name = "diagnoseColumn";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 600);
            Controls.Add(backButton);
            Controls.Add(resultsDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Results";
            Load += Results_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
        private Button backButton;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn rightAnswersCntColumn;
        private DataGridViewTextBoxColumn diagnoseColumn;
    }
}