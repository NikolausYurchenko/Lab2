using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class Figure
    {
        // создание сторон 
        private double _perimeter;
        private string _figure;
        private double _AB;
        private double _BC;
        private double _AC;
        private double _CD;
        private double _AD;
        private double _DE;
        private double _AE;
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }
        public string TypeFigure
        {
            get
            {
                return _figure;
            }
        }
        public Figure(Point A, Point B, Point C) //конструктор для треугольника
        {
            _figure = "triangle";
            _AB = LengthSide(A, B);
            _BC = LengthSide(B, C);
            _AC = LengthSide(A, C);
            _perimeter = PerimeterCalculator(_AB, _BC, _AC, 0, 0);
        }
        public Figure(Point A, Point B, Point C, Point D) :this(A,B,C) //конструктор для четырёхугольника
        {
            _figure = "quadrangle"; 
            _CD = LengthSide(C, D);
            _AD = LengthSide(A, D);
            _perimeter = PerimeterCalculator(_AB, _BC, _CD, _AD, 0);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E) :this(A,B,C,D) //конструктор для пятиугольника
        {
            _figure = "pentagon";
            _DE = LengthSide(D, E);
            _AE = LengthSide(A, E);
            _perimeter = PerimeterCalculator(_AB, _BC, _CD, _DE, _AE);
        }
        // Высчитывание стороны
        public double LengthSide(Point A, Point B)
        {
            double a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)); //Расчёт растояния между двумя точками
            return a;
        }
        // Высчитывание периметра
        public double PerimeterCalculator(double a, double b, double c, double d, double e)
        {
            double perimeter = a + b + c + d + e;
            return perimeter;
        }
    }
}
