using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Title
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Title: {_info}");
        }
    }
}
