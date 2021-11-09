using System;

namespace task8
{
    class Program
    {
        // Выбор товара
        static void GetArticle(Invoice invoiceOne)
        {
            string text;
            Console.WriteLine("Please, choose article; Enter number from 1 to 5");
            for (int i = 1; i < 6; i++) 
            {
                Console.WriteLine($"{i}. {invoiceOne.Article[i-1]} sneakers: {invoiceOne.Cost[i-1]}$");
            }
            text = Console.ReadLine();
            invoiceOne.Number = int.Parse(text);
        }
        //получаем кол-во товара
        static void GetQuantity(Invoice invoiceOne)
        {
            Console.Write("Enter quantity: ");
            string text = Console.ReadLine();
            invoiceOne.Quantity = int.Parse(text);
        }
        static void Main(string[] args)
        {
            Invoice invoiceOne = new Invoice();
            GetArticle(invoiceOne); // Получаем название товара
            GetQuantity(invoiceOne); // Получаем кол-во товара
            invoiceOne.CalculateTotalCost(); // Вычисляем стоимость без НДС
            invoiceOne.CalculateWithNds(); // Вычисляем стоимость с НДС
            invoiceOne.GetInfo(); // Выводим на экран
            Console.ReadLine();
        }
    }
}
