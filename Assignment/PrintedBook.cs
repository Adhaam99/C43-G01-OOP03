using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PrintedBook : Book
    {
        public int PageCount { get ; set; }

        public PrintedBook(string title, string author, int isbn, int PC) : base(title, author, isbn)
        {
            PageCount = PC;
        }

        public override string ToString()
        {
            return $"Book name : {Title}\nAuthor : {Author}\nISBN : {ISBN}\nFile Size : {PageCount}";
        }
    }
}
