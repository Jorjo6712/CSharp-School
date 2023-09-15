namespace Planets
{
    /// <summary>
    /// Entry point for the program where Controller is run which handles all logic
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.MainController();
        }
    }
}