using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    /// <summary>
    /// Used for writing GUI text and reading input from user
    /// </summary>
    internal class View
    {
        internal void Text(string text)
        {
            Console.WriteLine(text);
        }

        internal string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}