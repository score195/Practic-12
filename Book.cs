using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Book
    {
        private readonly string _isbn; 
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            _isbn = isbn; 
        }
        public string ISBN
        {
            get { return _isbn; }
        }
        public string GetBookInfo()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }
}
