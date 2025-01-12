using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class EBook : Book
    {
        public int FileSize { get; set; }

        public EBook( string title , string author , int isbn , int FS) : base( title , author , isbn)
        {
            FileSize = FS;
        }

        public override string ToString()
        {
            return $"Book name : {Title}\nAuthor : {Author}\nISBN : {ISBN}\nFile Size : {FileSize}";
        }
    }
}
