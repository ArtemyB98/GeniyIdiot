
using System.Xml.Linq;

namespace GeniyIdiot.Common
{
    public class StartInformation
    {
        public static string Get(string name)
        {
            return $"Давайте приступим, {name}, к выполнению теста! \nВам будут заданы поочередно пять вопросов.\nНа каждый вопрос будет выделено 10 секунд.";
        }
    }
}
