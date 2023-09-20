namespace Reproduction_Station
{
    /// <summary>
    ///  View class used for instantiating all gui related methods to help display things to the user
    /// </summary>
    internal class View
    {
        internal void Text(string text)
        {
            Console.WriteLine(text);
        }

        internal ConsoleKeyInfo RK()
        {
           return Console.ReadKey();
        }
    }
}
