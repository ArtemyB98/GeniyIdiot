using GeniyIdiot;
using GeniyIdiot.Common;

namespace GeniyIdiotWF
{
    public partial class GameForm : Form
    {
        Game game;
        int second = 10;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            var name = new NameForm();
            name.ShowDialog();
            game = new Game(name.nameTextBox.Text);
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            questionTimer.Start();
            questionTextLabel.Text = game.GetNextTestTask().Question;
            questionNumberLabel.Text = game.GetTaskNumber();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            game.AcceptAnswer(userAnswerTextBox.Text);

            if (game.End())
            {
                questionTimer.Stop();
                MessageBox.Show(game.ShowDiagnose());
                Close();
                return;
            }
            userAnswerTextBox.Clear();
            second = 10;
            ShowNextQuestion();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void questionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            second--;
            timerLabel.Text = second.ToString();
            if (second == 0) 
            {
                questionTimer.Stop();
                nextButton_Click(null,null);
                second = 10;
            }

        }

        private void timerLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
