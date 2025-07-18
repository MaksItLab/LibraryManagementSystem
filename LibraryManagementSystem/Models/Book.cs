using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Представляет книгу в библиотеке.
    /// Содержит информацию о названии, авторе, ISBN, годе издания и доступности.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Название книги.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// Уникальный идентификатор книги (например, ISBN).
        /// </summary>
        public string ISBN { get; private set; }

        /// <summary>
        /// Год издания книги.
        /// </summary>
        public int Year { get; private set; }

        /// <summary>
        /// Доступна ли книга для выдачи.
        /// </summary>
        public bool IsAvailable { get; private set; }

        /// <summary>
        /// Создаёт новую книгу и помечает её как доступную.
        /// </summary>
        public Book(string title, string author, string isbn, int year)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Year = year;
            IsAvailable = true;
        }

        /// <summary>
        /// Помечает книгу как выданную (становится недоступной).
        /// </summary>
        public void MarkAsLent()
        {
            IsAvailable = false;
        }

        /// <summary>
        /// Помечает книгу как возвращённую (становится доступной).
        /// </summary>
        public void MarkAsReturned()
        {
            IsAvailable = true;
        }
    }

}
