using System;
using System.Collections.Generic;
using System.Text;

namespace BooksCollection
{
    class Book
    {
        public string title { get; set; }
        public int strSize { get; set; }

        public bool isGived { get; set; }
        public int price { get; set; }

        public Book(string title, int strSize, int price, bool isGived)
        {
            this.title = title;
            this.strSize = strSize;
            this.price = price;
            this.isGived = isGived;
        }

        public void ShowBookInfo() 
        {
            Console.WriteLine("\n***");
            Console.WriteLine("Назва: " + this.title);
            Console.WriteLine("Кількість сторінок: " + this.strSize);
            Console.WriteLine("Ціна: " + this.price);
            Console.WriteLine("Чи видавалась цьогоріч: " + this.isGived);
            Console.WriteLine("***\n");
        }

        

    }
}
