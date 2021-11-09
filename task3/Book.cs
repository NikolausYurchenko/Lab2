using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Book 
    {
        private string _book;
        private string _title;
        private string _author;
        private string _content;
        public string Title
        {
            set
            {
                _title = value;
            }
        }
        public string Author
        {
            set
            {
                _author = value;
            }
        }
        public string Content
        {
            set
            {
                _content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  {_book}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Title: {_title}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author: {_author}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content: {_content}");
        }

        //Конструктор, который указывает на номер создаваемой книги
        public Book(string book)
        {
            _book = book;
        }
    }
}
