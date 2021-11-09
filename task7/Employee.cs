using System;
using System.Collections.Generic;
using System.Text;

namespace task7
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _position;
        private int _experience;
        private int _salary;
        private double _tax;
        public string Position
        {
            set
            {
                _position = value;
            }
        }
        public int Experience
        {
            set
            {
                _experience = value;
            }
        }
        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void SalaryAndTaxCalculation()
        {
            if(_position == "low")
            {
                if(_experience < 3)
                {
                    _salary = 500;
                }
                if ((_experience >= 3) && (_experience < 10))
                {
                    _salary = 750;
                }
                if (_experience >= 10)
                {
                    _salary = 1000;
                }
            }
            if(_position == "medium")
            {
                if (_experience < 3)
                {
                    _salary = 1500;
                }
                if ((_experience >= 3) && (_experience < 10))
                {
                    _salary = 2000;
                }
                if (_experience >= 10)
                {
                    _salary = 3000;
                }
            }
            if(_position == "high")
            {
                if (_experience < 3)
                {
                    _salary = 3500;
                }
                if ((_experience >= 3) && (_experience < 10))
                {
                    _salary = 4000;
                }
                if (_experience >= 10)
                {
                    _salary = 5000;
                }
            }
            //tax = 20%
            _tax = 0.2 * _salary;
        }

        public void GetInfo() //проверка правильно ли введены должность и стаж, да - вывод на экран результата, нет - вывод ошибки
        {
            if((_position != "low") && (_position != "medium") && (_position != "high"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered wrong position");
            }
            else
            {
                if(_experience < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered wrong your work experience");
                }
                else
                {
                    Console.WriteLine($"First employee\n" +
                                      $"Name: {_firstName} {_lastName}\n" +
                                      $"Salary: {_salary}$; Tax (20%): {_tax}$");
                }
            }
        }
    }
}
