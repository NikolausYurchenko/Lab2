using System;

namespace task2
{
    class Program
    {
        static double FirstSide() //Получение первой стороны
        {
            Console.WriteLine("Enter the values of the sides");
            Console.Write("First side: ");
            string text1 = Console.ReadLine();
            double side1 = double.Parse(text1);
            return side1;
        }
        static double SecondSide() //Получение второй стороны
        {
            Console.Write("Second side ");
            string text2 = Console.ReadLine();
            double side2 = double.Parse(text2);
            return side2;
        }
        static void Main(string[] args)
        {
            Rectangle rectangleOne = new Rectangle(5, 8);      //Создание первого прямоугольника
            rectangleOne.GetInfo();

              //Второй прямоугольник, с возможностью ввода значений сторон пользователем; вычисление площади и периметра
            Console.WriteLine(" RectangleTwo");
            double side1 = FirstSide();
            double side2 = SecondSide();
            Rectangle rectangleTwo = new Rectangle(side1 , side2);
            rectangleTwo.AreaCalculator();
            rectangleTwo.PerimeterCalculator();
            Console.WriteLine($"Rectangle area: {rectangleTwo.Area}");
            Console.WriteLine($"Rectangle perimeter: {rectangleTwo.Perimeter}");
            Console.ReadKey();
        }
    }
}
