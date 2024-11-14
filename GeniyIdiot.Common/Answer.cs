
namespace GeniyIdiot.Common
{
    public class Answer
    {
        public static bool CheckAnswer(string answer)
        {
            if (answer == null || answer == "") return false;
            var adequateIndex = 2;
            for (int i = 0; i < answer.Length; i++)
            {
                if (Char.IsDigit(answer[i]) && i < adequateIndex)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
