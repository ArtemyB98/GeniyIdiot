namespace GeniyIdiot.Common
{
    public class Game
    {
        public List<TestTask> Tasks;
        public TestTask CurrentTestTask;
        public User Pacient;
        public int QuestionsCount;
        public Diagnoses DiagnosticList = new Diagnoses();
        public int QuestionNumber = 0;
        public Game(string name)
        {
            Tasks = TestTasks.Get();
            QuestionsCount = Tasks.Count;
            Pacient = new User (name);
        }

        public TestTask GetNextTestTask()
        {
            var random = new Random();
            Tasks = Tasks.OrderBy(item => random.Next()).ToList();
            CurrentTestTask = Tasks[0];

            QuestionNumber++;

            return CurrentTestTask;
        }

        public string GetTaskNumber()
        {
            return $"Question {QuestionNumber}";
        }

        public void AcceptAnswer (string answerPacient)
        {
            if (answerPacient == CurrentTestTask.Answer)
            {
                Pacient.AcceptRightAnswer();
            }
            Tasks.Remove(CurrentTestTask);
        }

        public string ShowDiagnose()
        {
            var diagnose = DiagnosticList.GetDiagnose(Pacient.CountRightAnswer, QuestionsCount);
            Pacient.Diagnose = diagnose;
            UserResultsStorage.Append(Pacient);
            return $"{Pacient.Name}, your diagnose: {diagnose}";
        }
        public bool End()
        {
            return Tasks.Count == 0;
        }
    }
}
