using GeniyIdiot.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GeniyIdiot
{
    public class UserResultsStorage
    {
        public static string Path = "JsonResults.json";
        public static void Append(User pacient)
        {
            var userResults = GetPacientsResults();
            userResults.Add(pacient);
            Save(userResults);
        }

        public static List<User> GetPacientsResults()
        {
            if (!FileProvider.Exists(Path))
            {
                return new List<User>();
            }
            var pacientsResults = new List<User>();
            var value = FileProvider.GetValue(Path);
            pacientsResults = JsonConvert.DeserializeObject<List<User>>(value);
            
            return pacientsResults;
        }

        static void Save (List <User> pacientResults)
        {
            var jsonData = JsonConvert.SerializeObject(pacientResults, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }

    }
}
