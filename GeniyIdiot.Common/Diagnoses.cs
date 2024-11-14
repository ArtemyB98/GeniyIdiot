namespace GeniyIdiot.Common
{
    public class Diagnoses
    {
        public static List<string> Get()
        {
            return new List<string>
            {

                "Идиот",
                "Кретин",
                "Дурак",
                "Нормальный",
                "Талантливый",
                "Гений"
            };
        }


        public string GetDiagnose(int rightAnswerCount, int questionsCount)
        {
            double percentRightAnswerCount = (double)rightAnswerCount / questionsCount * 100;
            if (percentRightAnswerCount == 0)
            {
                return Get()[0];
            }
            if (percentRightAnswerCount < 40)
            {
                return Get()[1];
            }
            if (percentRightAnswerCount < 60)
            {
                return Get()[2];
            }
            if (percentRightAnswerCount < 80)
            {
                return Get()[3];
            }
            if (percentRightAnswerCount < 100)
            {
                return Get()[4];
            }
            return Get()[5];
        }
    }
}
