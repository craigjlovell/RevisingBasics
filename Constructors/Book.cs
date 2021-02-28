using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            pages = aPages;
            author = aAuthor;
        }
    }
}
