namespace Reproduction_Station
{
    /// <summary>
    /// Main entry point for program where controller is called and program is ran through MainController method
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