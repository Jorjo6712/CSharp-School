using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
    internal class Controller
    {
        internal void MainController()
        {
            View view = new View();

            Character character = new Character();

            character.people.Add("Anakin", false);

            character.people.Remove("Rey");

            foreach (var person in character.people) 
            {
                view.Text($"\n Person: {person.Key} is sith? {person.Value}");
            }

        }
    }
}
