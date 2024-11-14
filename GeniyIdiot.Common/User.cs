namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; }
        public int CountRightAnswer = 0;
        public string Diagnose { get; set; } = "Неизвестно";
        public User(string name)
        {
            Name = name;
        }
        public void AcceptRightAnswer()
        {
            CountRightAnswer++;
        }
    }
}
