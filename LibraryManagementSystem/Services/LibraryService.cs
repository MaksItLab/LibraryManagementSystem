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
        private JsonStorage jsonStorage;
        public LibraryService()
        {
            jsonStorage = new JsonStorage();

            books = jsonStorage.Load("books.json");
        }

        public void AddBook(Book book)
        {
            if (!books.Exists(p => p.ISBN == book.ISBN))
            {
                books.Add(book);
                Console.WriteLine("книга успешно добавлена!");
            }
            else
            {
                Console.WriteLine("книга с таким номером уже существует! проверьте корректность введенных данных!");
            }       
        }

        public void SaveAllBoksInFile()
        {
            jsonStorage.Save(books, "books.json");
        }

        public Book FindBook(string isbn)
        {
            Book book = books.Find(p => p.ISBN == isbn);

            if (book == null)
            {
                throw new Exception("выбранная вами книга не найдена, проверьте корректность вашего ввода!");
            }

            book = books.Find(p => p.ISBN == isbn);
            Console.WriteLine("вы выбрали книгу: " + book.Title);

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
