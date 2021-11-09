using System;

namespace task3
{
    class Program
    {
        //Метод позволяет ввести информацию о книге
        static void SetInformation(Book firstBook, Title titleOne, Author authorOne, Content contentOne)
        {
            Console.Write("Enter information about the title: ");
            titleOne.Info = Console.ReadLine();
            Console.Write("Enter information about the author: ");
            authorOne.Info = Console.ReadLine();
            Console.Write("Enter information about content: ");
            contentOne.Info = Console.ReadLine();
        }
        //Метод позволяет сохранить информацию (название, автора, содержание) в книгу (в класс Book)
        static void SaveInformation(Book firstBook, Title titleOne, Author authorOne, Content contentOne)
        {
            firstBook.Title = titleOne.Info;
            firstBook.Author = authorOne.Info;
            firstBook.Content = contentOne.Info;
        }
        static void Main(string[] args)
        {
            Book firstBook = new Book("First book");
            Title titleOne = new Title();
            Author authorOne = new Author();
            Content contentOne = new Content();
            SetInformation(firstBook, titleOne, authorOne, contentOne);
            SaveInformation(firstBook, titleOne, authorOne, contentOne);
            firstBook.Show();


 // каждый метод выводит информацию о своём классе, можно закомментировать метод firstBook.Show() и раскомментировать эти методы
         /*
            titleOne.Show();
            authorOne.Show();           
            contentOne.Show();
         */
            Console.ReadLine();
        }
    }
}
