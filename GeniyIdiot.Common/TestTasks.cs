using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class TestTasks
    {
        public static string Path = "JsonUserTestTasks.json";

        public static List<TestTask> Get()
        {
            var TasksList = new List<TestTask>();
            if (FileProvider.Exists(Path))
            {
                var value = FileProvider.GetValue(Path);
                TasksList = JsonConvert.DeserializeObject<List<TestTask>>(value);

            }
            else
            {
                TasksList.Add(new TestTask("Сколько будет два плюс два умноженное на два?", "6"));
                TasksList.Add(new TestTask("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", "9"));
                TasksList.Add(new TestTask("На двух руках 10 пальцев.Сколько пальцев на 5 руках ?", "25"));
                TasksList.Add(new TestTask("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", "60"));
                TasksList.Add(new TestTask("Пять свечей горело, две потухли.Сколько свечей осталось ? ", "3"));
                SaveTasks(TasksList);
            }
            return TasksList;
        }

        private static void SaveTasks(List<TestTask> TasksList)
        {
            var jsonData = JsonConvert.SerializeObject(TasksList, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }

        public static void AddNewTask(TestTask testTask)
        {
            var testTasks = Get();
            testTasks.Add(testTask);
            SaveTasks(testTasks);
        }
        public static void RemoveTask(TestTask testTask, List<TestTask> testTasks)
        {
            testTasks.Remove(testTask);
            SaveTasks(testTasks);
        }

       
    }
}
