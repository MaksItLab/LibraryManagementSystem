using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {           
            LibraryService libraryService = new LibraryService();
            Book book = new Book("book1", "автор1", "78698", 1976);            
            Book book1 = new Book("book2", "автор2", "75234", 1924);           
            libraryService.AddBook(book);          
            libraryService.books.Add(book);           
        }       
    }
}
