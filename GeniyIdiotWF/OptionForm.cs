using GeniyIdiot.Common;

namespace GeniyIdiotWF
{
    public partial class OptionForm : Form
    {
        public List<TestTask> Tasks;
        public OptionForm()
        {
            InitializeComponent();
        }
        private void OptionForm_Load(object sender, EventArgs e)
        {
            Tasks = TestTasks.Get();
            foreach (var task in Tasks)
            {
                questionsDataGridView.Rows.Add(task.Question, task.Answer);
            }
            questionsDataGridView.AllowUserToAddRows = false;
        }

        private void questionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var deleteQuestionIndex = e.RowIndex;
                {
                    var confirmation = new ConfirmationForm();
                    confirmation.confirmationLabel.Text = "Do you want delete?";
                    confirmation.ShowDialog();
                    if (confirmation.Answer)
                    {
                        var currentTaskRow = questionsDataGridView.Rows[deleteQuestionIndex].Cells;
                        var questionCell = currentTaskRow[0].Value.ToString();
                        var answerCell = currentTaskRow[1].Value.ToString();
                        foreach (var task in Tasks)
                        {
                            if (task.Question == questionCell && task.Answer == answerCell)
                            {
                                TestTasks.RemoveTask(task, Tasks);
                                questionsDataGridView.Rows.RemoveAt(deleteQuestionIndex);
                                break;
                            }
                        }
                    }
                }
                Refresh();
            }
        }
        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addQusetionButton_Click(object sender, EventArgs e)
        {
            if (newQustionTextBox.Text != "" && newAnswerTextBox.Text != "")
            {
                TestTasks.AddNewTask(new TestTask(newQustionTextBox.Text, newAnswerTextBox.Text));
                questionsDataGridView.Rows.Add(newQustionTextBox.Text, newAnswerTextBox.Text);
                Tasks = TestTasks.Get();
            }
            else
            {
                MessageBox.Show("Fill all of spaces");
            }
            newQustionTextBox.Clear();
            newAnswerTextBox.Clear();
            Update();
            Refresh();
        }
    }
}
