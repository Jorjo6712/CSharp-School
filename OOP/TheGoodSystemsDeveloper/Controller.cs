using System.Runtime.CompilerServices;

namespace TheGoodSystemsDeveloper
{
    internal class Controller
    {
        internal void MainController()
        {
            View view = new View();

            string filePath = Environment.CurrentDirectory + @"\test.txt";

            MakeFile(filePath);
            view.Text(LogRead(filePath));
        }

        private string LogRead(string filePath)
        {
            
            StreamReader sr = new StreamReader(filePath);
            
            string logs = sr.ReadToEnd();

            return logs;
        }

        private void MakeFile(string filePath)
        {

            using (StreamWriter sw = new StreamWriter(filePath)) { }

            string[] logs = { "Beep Boop, access denided", "Beep Boop, access granted" };

            for (int i = 0; i < 5; i++)
            {
                File.WriteAllText(filePath, string.Join("\n", logs));
            }
        }
    }
}
