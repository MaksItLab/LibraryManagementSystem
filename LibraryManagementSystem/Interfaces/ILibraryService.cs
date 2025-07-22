using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces
{
    public interface ILibraryService
    {
        void AddBook(Book book);
        void RemoveBook(string isbn);
        void LendBook(string isbn, string readerId);
        void ReturnBook(string isbn);
        List<Book> ListBooks();
        Book FindBook(string isbn);

    }
}
