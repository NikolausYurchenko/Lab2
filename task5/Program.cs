using System;

namespace task5
{
    class Program
    {
        //Метод вносит информацию в класс User
        static void SetForm(User userOne)
        {
            userOne.Login = "MyLogin";
            userOne.FirstName = "Bob";
            userOne.LastName = "Peters";
            userOne.Age = 25;
        }
        
        //метод выводит на экран информацию о пользователе
        static void GetInfo(User userOne)
        {
            if(userOne.Age != 0) 
            {
                Console.WriteLine("UserOne");
                Console.WriteLine($"Login: {userOne.Login}\n" +
                                  $"FirstName: {userOne.FirstName}\n" +
                                  $"Last Name: {userOne.LastName}\n" +
                                  $"Age: {userOne.Age}\n" +
                                  $"Date: {userOne.Date}");
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered wrong age");
            }
        }
        static void Main(string[] args)
        {
            User userOne = new User();
            SetForm(userOne);
            GetInfo(userOne);
            Console.ReadKey();
        }
    }
}
