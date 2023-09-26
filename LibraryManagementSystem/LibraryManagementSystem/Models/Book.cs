using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookId { get; set; }
        public string BookAuthor { get; set; }
        public string BookDescription { get; set; }
        public string BookStatus { get; set; }


        public Book()
        {

        }

        public Book(string bookName, string bookId)
        {
            BookName = bookName;
            BookId = bookId;
        }

        public Book(string bookName, string bookId, string bookAuthor, string bookDescription)
        {
            BookName = bookName;
            BookId = bookId;
            BookAuthor = bookAuthor;
            BookDescription = bookDescription;
        }

        public Book(string bookName, string bookId, string bookAuthor, string bookDescription, string bookStatus)
        {
            BookName = bookName;
            BookId = bookId;
            BookAuthor = bookAuthor;
            BookDescription = bookDescription;
            BookStatus = bookStatus;
        }
    }
}
