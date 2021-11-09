using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    class Invoice
    {
        private int _account = 25486312; //Счёт
        private string _customer = "Mega Sport"; //Потребитель
        private string _provider = "Some_provider"; //Поставщик

        private string[] _article = new string[5] { "Puma", "Adidas", "Nike", "Champion", "New balance" }; //Массив товаров
        private int[] _cost = new int[5] { 170, 200, 150, 130, 90 }; //Массив цен на товары
        private int _quantity; //кол-во
        private int _number; //Переменная используется для выбора товара

        private double  _totalcost, _NDS, _withNDS;
        public int Number //Переменная используется для выбора товара
        {
            set
            {
                _number = value;
            }
        }
        public string[] Article //Массив, содержащий название товаров
        {
        get
            {
                return _article;
            }
        }
        public int[] Cost //Массив, содержащий цены на товары
        {
            get
            {
                return _cost;
            }
        }
        public int Quantity
        {
            set
            {
                _quantity = value;
            }
        }

        //Рассчёт стоимости товара 
        public void CalculateTotalCost()
        {
            _totalcost = _quantity * _cost[_number-1];
        }
        //Рассчёт стоимость товара с учётом НДС
        public void CalculateWithNds() //NDS = 20% на товары; на сельскохоз. продукцию (пшеницу) = 14% (2021 год)
        {
            _NDS = _totalcost * 0.2;
            _withNDS = _NDS + _totalcost;
        }
        //Вывод на экран 
        public void GetInfo()
        {
            Console.WriteLine("\n----------Your order:---------- ");
            Console.WriteLine($"\nArticle: {_article[_number-1]} sneakers\n" +
                $"Quantity: {_quantity}");
            Console.WriteLine($"Sum of your order with NDS: {_withNDS}$\n" +
                $"Sum of your order without NDS: {_totalcost}$");
        }
    }
}
