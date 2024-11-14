using System.Text;

namespace GeniyIdiot.Common
{
    public class FileProvider
    {
        public static void Append(string fileName, string value)
        {
            var streamWriter = new StreamWriter(fileName, true, Encoding.UTF8);
            streamWriter.WriteLine(value);
            streamWriter.Close();
        }

        public static void Replace(string fileName, string value)
        {
            var streamWriter = new StreamWriter(fileName, false, Encoding.UTF8);
            streamWriter.WriteLine(value);
            streamWriter.Close();
        }

        public static string GetValue(string fileName)
        {
            var reader = new StreamReader(fileName, Encoding.UTF8);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void Clear(string fileName)
        {
            File.Delete(fileName);
            using (File.Create(fileName)) ;
        }
    }
}