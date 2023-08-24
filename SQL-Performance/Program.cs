namespace SqlTest
{
  class Program
  {
    static void Main()
    {
      Controller();
    }

    static void Controller()
    {

      Random number = new Random();

      int id = 0;

      for (int i = 0; i <= 1000000; i++)
      {
        int random = number.Next(0, 9999);
        Model(id, random);
        Text(id);
        id++;
      }
    }

    static void Text(int id)
    {
      Console.WriteLine(id);
    }

    static void Model(int id, int random)
    {
      string path = @"C:\Users\Administrator\Desktop\sqltest\data.txt";
      using (StreamWriter sw = File.AppendText(path))
      {
        if (id == 0)
        {
          sw.WriteLine("id, randomValue");
        }
        sw.WriteLine($"{id} , {random}");
      }
    }
  }
}
