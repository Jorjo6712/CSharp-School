using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLibrary
{
    internal class Controller
    {
        Stack<Book> loanedBooks = new Stack<Book>(); // Creating stack collection for books loaned by user
        View view = new View(); // Instanciating view class object
        internal void MainController() // Main controller where methods get run
        {
           GetBooks();
           LoanABook();
           view.ReadLine();
        }

        private void GetBooks() // Get books method used for creating library list object 
        {                       // and temporarily holding books then getting them removed later when pushed to stack for loaning
            Library library = new Library();

            foreach (Book book in library.books)
            {
                view.Text("\t" + book.BookName);
                view.Text("\t" + book.Genre);
                view.Text("\t" + book.Author);
                view.Text("\t" + book.BookRelease);
                view.Text("\t----------------------");
            }

            view.Text("\n Pick books to loan. Then press enter once more when you've picked.");

            while (true)
            {
                string  input = view.ReadLine();

                if (input == "")
                {
                    break;
                }
                else
                {
                    foreach (Book book in library.books)
                    {
                        if (book.BookName.Contains(input))
                        {
                            loanedBooks.Push(book);
                            library.books.Remove(book);

                            break;
                        }
                    }
                }

            }

        }

        void LoanABook() // Method for checking loaned books and making use of the stack collection Pop and Peek methods
        {

            view.Text("\nChecking books to loan. ");

            while (loanedBooks.Count > 0)
            {
                view.Text(loanedBooks.Peek().BookName);
                loanedBooks.Pop();
            }
        }


    }
}
