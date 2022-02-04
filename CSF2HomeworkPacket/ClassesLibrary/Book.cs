using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //FIELDS
        private int _numberOfPages;

        //PROPERTIES
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //CTOR
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book()
        {

        }

        //METHOD
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\nTitle: {0}\n" +
                "Author: {1}\n" +
                "Number of pages: {2}\n", Title, Author, NumberOfPages);
        }
    }
}
