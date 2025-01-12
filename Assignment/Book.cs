using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Book
    {
        
        #region Proprties

        public string? Title { get; set; }

        public string? Author { get; set; }

        public int ISBN { get; set; }

        #endregion

        #region Constructors

        public Book(string? title, string? author, int iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        

        #endregion
    }
}
