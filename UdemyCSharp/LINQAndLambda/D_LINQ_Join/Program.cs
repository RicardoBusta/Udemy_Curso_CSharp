using System;
using System.Collections.Generic;
using System.Linq;

namespace D_LINQ_Join {
    internal static class Program {
        public static void Main(string[] args) {
            var authorsList = new List<Author> {
                new Author {Name = "Fulano", Id = 1},
                new Author {Name = "Sicrano", Id = 2},
                new Author {Name = "Beltrano", Id = 3}
            };

            var booksList = new List<Book> {
                new Book {Title = "Amor amado", Year = "1920", Id = 1, AuthorId = 1},
                new Book {Title = "Romance romantico", Year = "1925", Id = 2, AuthorId = 1},
                new Book {Title = "Um espião muito louco", Year = "1955", Id = 3, AuthorId = 2},
                new Book {Title = "Existe vida na terra?", Year = "1970", Id = 4, AuthorId = 3},
            };

            var selection = from book in booksList
                join author in authorsList on book.AuthorId equals author.Id
                select new {book, author};

            foreach (var obj in selection) {
                Console.WriteLine($"Book: {obj.book.Title}, Author: {obj.author.Name}");
            }
        }
    }
}