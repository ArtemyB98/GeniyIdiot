namespace GeniyIdiot.Common
{
    public class TestTask
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public TestTask(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}
