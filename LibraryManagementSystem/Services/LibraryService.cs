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
            Book book = books.Find(p => p.ISBN == isbn && p.IsAvailable == true);
            if (book == null)
            {
                throw new Exception("неудалось выполнить действие, проверьте состояние книги в списке!");
            }
            book.MarkAsLent();
            Console.WriteLine("вы взяли книгу: " + book.Title + "состояние: " + book.IsAvailable);           
        }

        public List<Book> ListBooks()
        {
            for (int i = 0; i < books.Count; i++) 
            {
                Console.WriteLine("книга номер " + i + ":  " + books[i].Title + ";  " +  books[i].Author + "ISBN: " + books[i].ISBN + ";  " + "год выпуска: " + books[i].Year + ": " + "состояние: " + books[i].IsAvailable);
            }
            return books;
        }

        public void RemoveBook(string isbn)
        {            
            Book book = books.Find(p => p.ISBN == isbn && p.IsAvailable == true);
            if (book == null)
            {
                throw new Exception("неудалось выполнить действие, проверьте состояние книги в списке!");
            }            
            books.Remove(book);
            Console.WriteLine("книга успешно удалена! ");

        }

        public void ReturnBook(string isbn)
        {
            Book book = books.Find(p => p.ISBN == isbn && p.IsAvailable == false);
            if (book == null)
            {
                throw new Exception("неудалось выполнить действие, проверьте состояние книги в списке!");
            }
            book.MarkAsReturned();
            Console.WriteLine("вы вернули книгу: " + book.Title + "состояние: " + book.IsAvailable);
        }

        
    }
}
