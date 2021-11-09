using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Author
    {
        private string _info;
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                _info = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Author: {_info}");
        }
    }
}
