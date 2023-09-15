namespace TheLibrary
{
    internal class Program
    {
        
        /// <summary>
        /// Main program entry point where controller gets called
        /// </summary>

        internal static void Main(string[] args) 
        {
            Controller controller = new Controller();
            controller.MainController();
        }
    }
}