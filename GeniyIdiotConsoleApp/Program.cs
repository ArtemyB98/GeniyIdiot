using GeniyIdiot.Common;
using System.Xml.Linq;

namespace GeniyIdiot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Здравствуйте, господин(жа) хороший(ая), как к Вам можно обращаться по имени?");
                var game = new Game(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(StartInformation.Get(game.Pacient.Name) + "\nДля продолжения нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
                while (game.Tasks.Count > 0) 
                {
                    var task = game.GetNextTestTask();
                    Console.Clear();
                    Console.WriteLine($"Вопрос №{game.QuestionNumber}: \n{task.Question}");
                    if (GetAnswer(task)) game.Pacient.AcceptRightAnswer();
                    game.Tasks.Remove(task);
                    Console.Clear();
                }

                game.Pacient.Diagnose = game.DiagnosticList.GetDiagnose(game.Pacient.CountRightAnswer, game.QuestionsCount);
                UserResultsStorage.Append(game.Pacient);
                Console.WriteLine($"Уважаемый(ая), {game.Pacient.Name}, Ваш диагноз: {game.Pacient.Diagnose}\nХотите посмотреть все результаты?");
                var confirmation = GetYesNo("Хотите посмотреть все результаты?");
                if (confirmation)
                {
                    Console.Clear();
                    ShowPacientsResults();
                }
                Console.Clear();

                Console.WriteLine($"Уважаемый(ая), {game.Pacient.Name}, хотите добавить вопрос?");
                confirmation = GetYesNo("Хотите добавить вопрос?");
                if (confirmation)
                {
                    AddNewQuestion();

                }
                Console.Clear();

                Console.WriteLine($"Уважаемый(ая), {game.Pacient.Name}, хотите удалить вопрос?");
                confirmation = GetYesNo("Хотите удалить вопрос?");
                if (confirmation)
                {
                    RemoveQuestion();
                }
                Console.Clear();

                Console.WriteLine("Хотите пройти тест ещё раз?");
                confirmation = GetYesNo("Хотите пройти тест ещё раз?");
                if (!confirmation)
                {
                    Console.Clear();
                    Console.WriteLine("Заверешение программы");
                    break;
                }
                Console.Clear();
            }
        }

        private static void RemoveQuestion()
        {
            Console.Clear();
            Console.WriteLine("Введите номер удаляемого вопроса:");
            var questions = TestTasks.Get();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Question}");
            }
            while (true)
            {
                var removeQuestionNumber = Console.ReadLine();
                if (Answer.CheckAnswer(removeQuestionNumber)&&Convert.ToInt32(removeQuestionNumber)>0&& Convert.ToInt32(removeQuestionNumber)<= questions.Count)
                {
                    TestTasks.RemoveTask(questions[Convert.ToInt32(removeQuestionNumber)-1], questions);
                    Console.WriteLine("Вопрос удалён, для продолжение нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine($"Ответом должно быть число от 1 до {questions.Count}");
                }
            }
            
        }

        static void AddNewQuestion()
        {
            Console.Clear();
            Console.WriteLine("Введите текст вопроса:");
            var newQuestion = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос:");
            while (true)
            {
                var answerNewQustion = Console.ReadLine();
                if (Answer.CheckAnswer(answerNewQustion))
                {
                    TestTasks.AddNewTask(new TestTask(newQuestion, answerNewQustion));
                    Console.WriteLine("Вопрос добавлен, для продолжение нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Ответом должно быть число не превышеющие 100");
                }
            }
        }


        static bool GetYesNo(string textQuestions)
        {
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput.ToUpper() == "ДА")
                {
                    return true;
                }
                Console.Clear();
                if (userInput.ToUpper() == "НЕТ")
                {
                    return false;
                }
                Console.Clear();
                Console.WriteLine($"Ответьте \"Да\" или \"Нет\"\n{textQuestions}");
            }
        }
        static bool GetAnswer(TestTask task)
        {
            while (true)
            {
                var answerPacient = Console.ReadLine();
                if (!Answer.CheckAnswer(answerPacient))
                {
                    Console.Clear();
                    Console.WriteLine($"Введите, пожалуйста, число не превышающее 100\n\nВопрос: {task.Question}");
                    Console.SetCursorPosition(0, 1);
                    continue;
                }
                return answerPacient == task.Answer;
            }
        }

        public static List<User> ShowPacientsResults()
        {
            var pacientsResults = UserResultsStorage.GetPacientsResults();
            Console.Clear();
            string outputFormat = "{0,-20}{1,20}{2,20}";
            Console.WriteLine(outputFormat, "Имя", "Количество ответов", "Диагноз");
            foreach (var pacient in pacientsResults)
            {
                Console.WriteLine(outputFormat, pacient.Name, pacient.CountRightAnswer, pacient.Diagnose);
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
            return pacientsResults;
        }
    }
}
