using System;

namespace task6
{
    class Program
    {
        /*write "uah" if you want to convert from UAH; "usd" - from USD; "eur" - from EUR, "rub" - from RUB
          then write "uah" if you want to convert to UAH; "usd" - to USD; "eur" - to EUR, "rub" - to RUB*/

        static void ConvertCurrency(Converter convert) // метод выполняет конвертацию, есть возможность выбора валюты для конвертации (from/to)
        {
            Console.Write("Select currensy for exchange\n" +        
                "From: ");                                          
            string text = Console.ReadLine();
            string text1;
            if (text == "uah")
            {
                Console.Write("To: ");
                text1 = Console.ReadLine();
                if (text1 == "uah")
                {
                    Console.WriteLine("You can not convert to this currency");
                }
                if(text1 == "usd")
                {
                    Amount(convert);
                    convert.ConvertToUsd();
                    GetInfo(convert);
                }
                if (text1 == "eur")
                {
                    Amount(convert);
                    convert.ConvertToEur();
                    GetInfo(convert);
                }
                if (text1 == "rub")
                {
                    Amount(convert);
                    convert.ConvertToRub();
                    GetInfo(convert);
                }

            }
            if (text == "usd")
            {
                Console.WriteLine("You can convert only to UAH: ");
                Amount(convert);
                convert.ConvertToUah(26.39);
                GetInfo(convert);
            }
            if (text == "eur")
            {
                Console.WriteLine("You can convert only to UAH: ");
                Amount(convert);
                convert.ConvertToUah(30.63);
                GetInfo(convert);
            }
            if (text == "rub")
            {
                Console.WriteLine("You can convert only to UAH: ");
                Amount(convert);
                convert.ConvertToUah(0.37);
                GetInfo(convert);
            }
        }
        static void Amount(Converter convert) //метод позволяет ввести необходимую для конвертации сумму
        {
            Console.Write("Enter amount: ");
            string text2 = Console.ReadLine();
            convert.Amount = double.Parse(text2);
        }
        static void GetInfo(Converter convert) // метод выводит на экран результат конвертации
        {
            Console.WriteLine($"Result: {convert.Result}");
        }
        static void Main(string[] args)
        {
            Converter convert = new Converter(26.39, 30.63, 0.37);
            ConvertCurrency(convert);
            Console.ReadLine();
        }
    }
}
