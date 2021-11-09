using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Rectangle
    {
        private double _side1;
        private double _side2;
        private double _area;
        private double _perimeter;

        public double Area
        {
            get
            {
                return _area;
            }
        }
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }

        //Конструктор, который принимает значения сторон
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        //Отображение значений сторон первого прямоугольника
        public void GetInfo()
        {
            Console.WriteLine(" RectangleOne");
            Console.WriteLine($"First side: {_side1}\n"+ $"Second side: {_side2}\n");
        }

        // Вычисление площади; проверка, что введдёные числа >= 0;
        public void AreaCalculator()       
        {
            if ((_side1 >= 0) && (_side2 >= 0))
            {
                _area = _side1 * _side2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered wrong values");       
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        //Вычисление периметра 
        public void PerimeterCalculator()
        {
            if ((_side1 >= 0) && (_side2 >= 0))
            {
                _perimeter = _side1 + _side2;
            }
        }
    }
}