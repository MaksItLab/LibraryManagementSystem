using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class LibraryService : ILibraryService
    {
        public List<Book> books;
        public LibraryService()
        {
            books = new List<Book>()
            {
                new Book("booknumber1", "autor1", "23834", 1883),
                new Book("booknumber2", "autor2", "86746", 1931),
                new Book("booknumber3", "autor3", "03482", 1722),
                new Book("booknumber4", "autor4", "45876", 2001),
            };
        }

        public void AddBook(Book book)
        {
            if (books.Exists(p => p.ISBN != book.ISBN))
            {
                books.Add(book);
                Console.WriteLine("книга успешно добавлена!");
            }
            else
            {
                Console.WriteLine("книга с таким номером уже существует! проверьте корректность введенных данных!");
            }
                        
        }

        public Book FindBook(string isbn)
        {
            Book book = null;
            if (books.Exists(p => p.ISBN == isbn))
            {
                book = books.Find(p => p.ISBN == isbn);
                Console.WriteLine("вы выбрали книгу: " + book.Title);
            }
            else 
            {
                Console.WriteLine("выбранная вами книга не найдена, проверьте корректность вашего ввода!");
            }

            return book;
        }

        public void LendBook(string isbn, string readerId)
        {
            if (books.Exists(p => p.ISBN == isbn))
            {
                Console.WriteLine("вы выбрали книгу: " + books.Find(p => p.ISBN == isbn).Title + "хотите ее взять?");
                string variant = Console.ReadLine();
                if (variant == "yes")
                {
                   
                    Console.WriteLine("книга; " + books.Find(p => p.ISBN == isbn).Title + "успешно взята!");
                }
                else
                {
                    Console.WriteLine("неверная комманда! ошибка!");
                }
            }
            else
            {
                Console.WriteLine("выбранная вами книга не найдена, проверьте корректность вашего ввода!");
            }
        }

        public List<Book> ListBooks()
        {
            for (int i = 0; i < books.Count; i++) 
            {
                Console.WriteLine("книга номер " + i + ":  " + books[i].Title + ";  " +  books[i].Author + "ISBN: " + books[i].ISBN + ";  " + "год выпуска: " + books[i].Year);
            }
            return books;
        }

        public void RemoveBook(string isbn)
        {
            if (books.Exists(p => p.ISBN == isbn))
            {
                Console.WriteLine("вы выбрали книгу: " + books.Find(p => p.ISBN == isbn).Title + "\nвы действительно хотите ее удалить? \nyes/no");
                string variant = Console.ReadLine();
                if (variant == "yes")
                {
                    books.Remove(books.Find(p => p.ISBN == isbn));
                }
                else
                {
                    Console.WriteLine("удаление отменено!");
                }
            }
            else
            {
                Console.WriteLine("выбранная вами книга не найдена, проверьте корректность вашего ввода!");
            }

        }

        public void ReturnBook(string isbn)
        {
            if (books.Exists(p => p.ISBN == isbn))
            {
                Console.WriteLine("вы выбрали книгу: " + books.Find(p => p.ISBN == isbn).Title + "хотите ее вернуть?");
                string variant = Console.ReadLine();
                if (variant == "yes")
                {

                    Console.WriteLine("книга; " + books.Find(p => p.ISBN == isbn).Title + "успешно возвращена!");
                }
                else
                {
                    Console.WriteLine("неверная комманда! ошибка!");
                }
            }
            else
            {
                Console.WriteLine("выбранная вами книга не найдена, проверьте корректность вашего ввода!");
            }
        }

        
    }
}
