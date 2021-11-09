using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Content
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content: {_info}");
        }
    }
}
