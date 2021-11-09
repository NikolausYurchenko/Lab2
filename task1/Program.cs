using ConsoleApp3;
using System;

namespace task1
{
    class Program
    {
        // Вносим данные в класс Address
        static void SetAddress(Address addressOne)
        {
            addressOne.Index = 26007;
            addressOne.Country = "Ukraine";
            addressOne.City = "Kyiv";
            addressOne.Street = "Magistralna";
            addressOne.House = 5;
            addressOne.Appartment = 112;
        }
        // вывод на экран результата работы программы
        static void GetInfo(Address addressOne)
        {
            Console.WriteLine("   AddressOne: ");
            Console.WriteLine($"Index: {addressOne.Index}");
            Console.WriteLine($"Country: {addressOne.Country}");
            Console.WriteLine($"City: {addressOne.City}");
            Console.WriteLine($"Street: {addressOne.Street}");
            Console.WriteLine($"House: {addressOne.House}");
            Console.WriteLine($"Appartment: {addressOne.Appartment}");
        }
        static void Main(string[] args)
        {
            Address addressOne = new Address();
            SetAddress(addressOne);
            GetInfo(addressOne);
            Console.ReadKey();
        }
    }
}
