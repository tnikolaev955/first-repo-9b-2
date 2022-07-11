using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    public class Book
    {
        private string title;
        private string author;
        private double price;
        private string ISBN;
        private int quantity;
         
        public Book(string title, string author, double price, string ISBN, int quantity)
        {

            this.title = title;
            this.author = author;
            this.price = price;
            this.ISBN = ISBN;
            this.quantity = quantity;
             

        }

        public string getTitle()
        {
            return title;
        }
        public string getAuthor()
        {
            return author;
        }
        public double getPrice()
        {
            return price;
        }
        public string getISBN()
        {
            return ISBN;
        }
        public int getQuantity()
        {
            return quantity;

        }

    }
}
