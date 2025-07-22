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
        public List<StreamReader> books;

        public void AddBook(Book book)
        {
            
        }

        public Book FindBook(string isbn)
        {
            throw new NotImplementedException();
        }

        public void LendBook(string isbn, string readerId)
        {
            throw new NotImplementedException();
        }

        public List<Book> ListBooks()
        {
            throw new NotImplementedException();
        }

        public void RemoveBook(string isbn)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(string isbn)
        {
            throw new NotImplementedException();
        }

        public void StreamReader(string path)
        {
            books = new List<StreamReader>();
        }
    }
}
