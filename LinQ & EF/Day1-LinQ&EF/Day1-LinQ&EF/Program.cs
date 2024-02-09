using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_LinQ_EF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var books = SampleData.Books;

            #region Display book title and its ISBN

            //books
            //    .Select(b => new { b.Title, b.Isbn })
            //    .ToList();

            //foreach (var book in books)
            //{
            //    Console.WriteLine($"Title: {book.Title}, ISBN: {book.Isbn}");
            //}

            #endregion Display book title and its ISBN

            #region Display the first 3 books with price more than 25

            //books
            //    .Where(b => b.Price > 25)
            //    .Take(3)
            //    .ToList();
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            //}

            #endregion Display the first 3 books with price more than 25

            #region Display Book title along with its publisher name

            //books
            //    .Select(b => new { b.Title, b.Publisher.Name })
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            #endregion Display Book title along with its publisher name

            #region Find the number of books which cost more than 20

            //////
            //var bookList = books.Count(b => b.Price > 20);

            //Console.WriteLine($"Number of books that cost more than 20: {bookList}");

            /////

            //IEnumerable<Book> bookList = books.Where(b => b.Price > 20);

            //int countOfExpensiveBooks = bookList.Count();

            //Console.WriteLine($"Number of books that cost more than 20: {countOfExpensiveBooks}");

            #endregion Find the number of books which cost more than 20

            #region Display book title, price and subject name sorted by its subject name ascending and by its price descending

            //if (books != null)
            //{
            //    var bookList = books
            //        .OrderBy(b => b.Subject.Name)
            //        .ThenByDescending(b => b.Price)
            //        .Select(b => new { b.Title, b.Price, b.Subject.Name });

            //    foreach (var book in bookList)
            //    {
            //        Console.WriteLine($"Title: {book.Title}, Price: {book.Price}, Subject: {book.Name}");
            //    }
            //}

            #endregion Display book title, price and subject name sorted by its subject name ascending and by its price descending

            #region Display All subjects with books related to this subject.

            //books
            //    .GroupBy(b => b.Subject.Name)
            //    .ToList()
            //    .ForEach(g =>
            //    {
            //        Console.WriteLine(g.Key);
            //        g.ToList().ForEach(b => Console.WriteLine($"\t{b.Title}"));
            //    });

            #endregion Display All subjects with books related to this subject.

            #region Try to display book title & price (from book objects) returned from GetBooks Function.

            //var booksList = SampleData.GetBooks().OfType<Book>();

            //var bookList = books
            //    .Cast<Book>()
            //    .Select(b => new { b.Title, b.Price });

            //foreach (Book book in books)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            //}

            #endregion Try to display book title & price (from book objects) returned from GetBooks Function.

            #region Display books grouped by publisher & Subject

            //books
            //    .GroupBy(b => (b.Publisher.Name, b.Subject.Name))
            //    .ToList()
            //    .ForEach(g =>
            //    {
            //        Console.WriteLine($"Publisher: {g.Key.Item1}, Subject: {g.Key.Item2}");
            //        g.ToList().ForEach(b => Console.WriteLine($"\t{b.Title}"));
            //    });

            #endregion Display books grouped by publisher & Subject

            Console.ReadLine();
        }
    }
}