using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp17;

namespace Книга
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> BookList = new List<Book>();  
            Console.WriteLine("Enter ISBN:");  
            String input = Console.ReadLine(); 
            BookList.Add(new Book("Под Игото", "Иван Вазов", 15, "9786197314069", 10));
            BookList.Add(new Book("Бай Ганьо", "Алеко Константинов", 20, "9780299236946", 5));
            BookList.Add(new Book("Да се завърнеш в бащината къща", "Димчо Дебелянов", 12, "9789547760424", 0));
            BookList.Add(new Book("Арменци", "Пейо Яворов", 16, "9789544112783", 3));
            BookList.Add(new Book("Гераците", "Елин Пелин", 10, "9788726329513", 12));
            BookList.Add(new Book("Септември", "Гео Милев", 14, "9789543982776", 6));
            BookList.Add(new Book("Зимни вечери", "Христо Смирненски", 13, "9544263179", 7));
            BookList.Add(new Book("Повест", "Атанас Далчев", 11, "9789549252699", 0));
            BookList.Add(new Book("Албена", "Йордан Йовков", 8, "9789540903705", 1));
            BookList.Add(new Book("Тютюн", "Димитър Димов", 18, "9789542804239", 4));  
            bool isContained = false;  
            foreach (var book in BookList)  
            {
                if (input == book.getISBN())   
                {
                    isContained = true;   
                    if (book.getQuantity() > 0)  
                    {
                        Console.WriteLine("Книгата " + book.getTitle() + " е налична");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Книгата " + book.getTitle() + " не е налична");  
                        break;
                    }
                }

            }

            if (!isContained)  
            {
                Console.WriteLine("Няма такъв ISBN");
            }

        }
    }
}
