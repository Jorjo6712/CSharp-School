namespace TheFirm
{
    /// <summary>
    /// Main entrypoint for program where Controller is instanciated and the MainController method is called to control
    /// the program
    /// </summary>
   internal class Program
    {
        internal static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.MainController();
        }
    }
}