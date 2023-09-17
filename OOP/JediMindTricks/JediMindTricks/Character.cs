using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
    internal class Character
    {
        internal Dictionary<string, bool> people = new Dictionary<string, bool>()
        {
            {"Luke", false },
            {"Jabba", false },
            {"Rey", false },
            {"Kylo", true},
            {"Maul", true},
            {"Bane", true },
            {"Vader", true },
            {"Sidious", true },
        };

    }
}
