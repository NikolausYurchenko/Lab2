using System;

namespace task4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Создание 4 точек, 5 закоммендирована, можно раскомменировать и передать в конструктор Figure значение E
            Point A = new Point(4, 5, "A");
            Point B = new Point(7, 9, "B");
            Point C = new Point(11, 2, "C");
            Point D = new Point(8, -4, "D");
           // Point E = new Point(2, 1, "E");
            Figure figureOne = new Figure(A,B,C,D);
            Console.WriteLine($"Type of figure: {figureOne.TypeFigure}\nPerimeter: {figureOne.Perimeter}");
            Console.ReadKey();
        }
    }
}
