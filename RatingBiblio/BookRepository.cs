using System;
using System.Collections.Generic;
using System.Linq;
using RatingBiblio.Models;

namespace RatingBiblio
{
    public class BookRepository
    {
        private readonly List<Book> _books = new List<Book>();

        /*private readonly List<Book> _books = new List<Book>()
        {
            new Book(0, "Кристина", "Стивен Эдвин Кинг", new DateTime(2024, 04, 09), "Ярлынский Олег Васильевич", true),
            new Book(1, "Голова профессора Доуэля", "Артур Конан Дойль", new DateTime(2023, 08, 04), "Гиоев Арсен Аланович", false),
            new Book(2, "Шерлок Холмс", "Артур Конан Дойль", new DateTime(2004, 04, 08), "Гуссаов Георгий Асламбекович", false),
            new Book(3, "Преступление и наказание", "Федор Михайлович Достоевский", new DateTime(2008, 10, 04), "Санакоев Артур Вячеславочич", false)

        };*/

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void UpdateBook(Book updatedBook)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (existingBook != null)
            {
                existingBook.Title = updatedBook.Title;
                existingBook.Author = updatedBook.Author;
                existingBook.LastIssueDate = updatedBook.LastIssueDate;
                existingBook.IssuedTo = updatedBook.IssuedTo;
                existingBook.IsInLibrary = updatedBook.IsInLibrary;
            }
        }
    }
}
