using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    /// <summary>
    /// All book data properites and fields to be instanciated into seperate objects later inside the list found in Library
    /// </summary>
    internal class Book
    {
        private string _bookName;
        private string _bookReleaseDate;
        private string _genre;
        private string _author;

        internal string BookRelease
        {
            get { return _bookReleaseDate; }
            set { _bookReleaseDate = value; }
        }

        internal string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        internal string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        internal string Author
        {
            get { return _author; }
            set { _author = value; }
        }
    }
}
