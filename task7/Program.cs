using System;

namespace task7
{
    class Program
    {
        static void GetPosition(Employee employeeOne)
        {
            Console.Write("Write your position (Write 'low', 'medium' or 'high') ");
            employeeOne.Position = Console.ReadLine();
        }
        static void GetExperience(Employee employeeOne)
        {
            string text;
            Console.Write("Enter your work experience: ");
            text = Console.ReadLine();
            employeeOne.Experience = int.Parse(text);

        }
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee("Bob", "Peters"); //Передаём в конструктор имя и фамилию
            GetPosition(employeeOne); //Получаем должность
            GetExperience(employeeOne); //Получаем стаж
            employeeOne.SalaryAndTaxCalculation(); //Рассчёт оклада и налога в зависимости от должности и стажа
            employeeOne.GetInfo(); //Выводим результат на экран, если введены неверные даные должности и стажа - выводится ошибка 
            Console.ReadLine();
        }
    }
}
