using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    /// <summary>
    /// Used for containing available library books inside list and instanciating new objects
    /// </summary>
    internal class Library
    {
        internal List<Book> books = new List<Book>()
        {
            new Book()
            {
                BookName = "The Hundredth Queen",
                Genre = "Fantasy Fiction, Young adult fiction",
                BookRelease = "June 1, 2017",
                Author = "Emily R. King"
            }
            
            ,

            new Book()
            {
                BookName = "The Nix",
                Genre = "Novel, Domestic Fiction",
                BookRelease = "August 30, 2016",
                Author = "Nathan Hill"
            }

            ,

            new Book()
            {
                BookName = "Dark Matter",
                Genre = "Science fiction, Novel, Thriller, Suspense",
                BookRelease = "July 26, 2016",
                Author = "Blake Crouch"
            }

            ,

            new Book()
            {
                BookName = "One Word Kill",
                Genre = "Science fiction, Fantasy Fiction, Time Travel Fiction",
                BookRelease = "May 1, 2019",
                Author = "Mark Lawrence"
            }

            ,

            new Book()
            {
                BookName = "Good Omens",
                Genre = "Humor, Comedy, Fantasy Fiction, Horror fiction, Humorous Fiction, Fantasy",
                BookRelease = "May 10, 1990",
                Author = "Neil Gaiman, Terry Pratchett"
            }

        };
    }
}
