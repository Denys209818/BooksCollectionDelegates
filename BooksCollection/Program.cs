using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksCollection
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Book> books = new List<Book>();
            books.Add(new Book("Кобзар", 1000, 100, true));
            books.Add(new Book("Кайдашева сім'я", 200, 50, false));
            books.Add(new Book("Гаррі Потер", 400, 500, false));
            books.Add(new Book("Голодні ігри", 450, 300, true));

            Console.WriteLine("1. Вибрати всі книжки вартість яких дорожче заданої");
            while(true) 
            {
               try
               {
                    Console.Write("Ведіть ціну - ");
                    int inPrice = int.Parse(Console.ReadLine());

                    List<Book> books2 = books.Where(delegate (Book book) { return book.price > inPrice; }).ToList();

                    books2.ForEach(book => { book.ShowBookInfo(); });
                    break;
               } 
               catch (Exception ex) 
               {
                   Console.WriteLine(ex.Message);
               }
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("2. Вибрати всі книжки які видавались за останній рік");
            List<Book> books3 = books.Where((Book b) => { return b.isGived; }).ToList();
            books3.ForEach(delegate (Book book) { book.ShowBookInfo(); });

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("3. На основі колекції книжок сформувати колекцію яка містить лише назви книжок");
            List<string> booksStrings = books.Select(delegate (Book book) { return new string(book.title); } ).ToList();
            Console.WriteLine("Назви книжок:");
            foreach (var item in booksStrings) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
