using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class Point
    {
        private int _x;
        private int _y;
        private string _symbol;
        public int X
        {
            get
            {
                return _x;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
        }
        public string Symbol
        {
            get
            {
                return _symbol; }
        }
        public Point(int A, int B, string C)
        {
            _x = A;
            _y = B;
            _symbol = C;
        }
    }
}
