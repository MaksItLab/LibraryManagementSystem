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
            books.Add(book);
            Console.WriteLine("книга успешно добавлена!");            
        }

        public Book FindBook(string isbn)
        {
            
            switch (isbn)
            {
                case "23834":
                    Console.WriteLine("вы выбрали книгу: \nbooknumber1; autor1. ");                    
                    break;
                case "86746":
                    Console.WriteLine("вы выбрали книгу: \nbooknumber2; autor2. ");                  
                    break;
                case "03482":
                    Console.WriteLine("вы выбрали книгу: \nbooknumber3; autor3. ?");                  
                    break;
                case "45876":
                    Console.WriteLine("вы вывыбрали книгу: \nbooknumber4; autor4. ");                   
                    break;
                default:
                    Console.WriteLine("введен некорректный номер isbn, повторите попытку!");
                    break;
                    
            }
            return books[0];
        }

        public void LendBook(string isbn, string readerId)
        {
            switch (isbn)
            {
                case "23834":

                    Console.WriteLine("вы хотите одолжилть книгу: \nbooknumber1; autor1. ?");
                    string deistvie = Console.ReadLine();
                    if (deistvie == "yes")
                    {
                        Console.WriteLine("книга успешно взята");
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная коммада!");
                    }
                    break;
                case "86746":
                    Console.WriteLine("вы хотите одолжилть книгу: \nbooknumber2; autor2. ?");
                    string deistvie1 = Console.ReadLine();
                    if (deistvie1 == "yes")
                    {
                        Console.WriteLine("книга успешно взята");
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная коммада!");
                    }
                    break;
                case "03482":
                    Console.WriteLine("вы хотите одолжилть книгу: \nbooknumber3; autor3. ?");
                    string deistvie2 = Console.ReadLine();
                    if (deistvie2 == "yes")
                    {
                        Console.WriteLine("книга успешно взята");
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная коммада!");
                    }
                    break;
                case "45876":
                    Console.WriteLine("вы хотите одолжилть книгу: \nbooknumber4; autor4. ?");
                    string deistvie3 = Console.ReadLine();
                    if (deistvie3 == "yes")
                    {
                        Console.WriteLine("книга успешно взята");
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная коммада!");
                    }
                    break;
                default:
                    Console.WriteLine("введен некорректный номер isbn, повторите попытку!");
                    break;

            }
        }

        public List<Book> ListBooks()
        {
            for (int i = 0; i < books.Count; i++) 
            {
                Console.WriteLine("книга номер " + i + ":  " + books[i].Title + ";  " +  books[i].Author + "ISBN: " + books[i].ISBN + ";  " + "год выпуска: " + books[i].Year);
            }
            return new List<Book>();
        }

        public void RemoveBook(string isbn)
        {
            switch (isbn)
            {
                case "23834":
                    Console.WriteLine("вы хотите удалить книгу: \nbooknumber1; autor1. ?");
                    string deistvie = Console.ReadLine();
                    if (deistvie == "yes")
                    {
                        books.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная комманда!");
                    }
                    break;
                case "86746":
                    Console.WriteLine("вы хотите удалить книгу: \nbooknumber2; autor2. ?");
                    string deistvie1 = Console.ReadLine();
                    if (deistvie1 == "yes")
                    {
                        books.RemoveAt(1);
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная комманда!");
                    }
                    break;
                case "03482":
                    Console.WriteLine("вы хотите удалить книгу: \nbooknumber3; autor3. ?");
                    string deistvie2 = Console.ReadLine();
                    if (deistvie2 == "yes")
                    {
                        books.RemoveAt(2);
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная комманда!");
                    }
                    break;
                case "45876":
                    Console.WriteLine("вы хотите удалить книгу: \nbooknumber4; autor4. ?");
                    string deistvie3 = Console.ReadLine();
                    if (deistvie3 == "yes")
                    {
                        books.RemoveAt(3);
                    }
                    else
                    {
                        Console.WriteLine("действие отменено, некорректная комманда!");
                    }
                    break;
                default:
                    Console.WriteLine("введен некорректный номер isbn, повторите попытку!");
                    break;

            }
        }

        public void ReturnBook(string isbn)
        {
            switch (isbn)
            {
                case "23834":

                    Console.WriteLine("вы одолжили книгу: \nbooknumber1; autor1. ");
                    break;
                case "86746":
                    Console.WriteLine("вы одолжили книгу: \nbooknumber2; autor2. ");
                    break;
                case "03482":
                    Console.WriteLine("вы одолжили книгу: \nbooknumber3; autor3. ");
                    break;
                case "45876":
                    Console.WriteLine("вы одолжили книгу: \nbooknumber4; autor4. ");
                    break;
                default:
                    Console.WriteLine("введен некорректный номер isbn, повторите попытку!");
                    break;

            }
        }

        
    }
}
