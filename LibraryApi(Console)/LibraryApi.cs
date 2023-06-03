using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi_Console_
{
    public class LibraryApp
    {
        List<Book> books;
        List<string> authors;


        public LibraryApp()
        {
            books = new List<Book>();
            authors = new List<string>();
        }

        public void AddAuthor(string author)
        {
            authors.Add(author);
            Console.WriteLine("Muellif elave edildi:" + author);
        }

        public void AddBook(int authorId, int bookId, string bookName)
        {

            if (authorId < 0 || authorId >= authors.Count)
            {
                Console.WriteLine("Sehv ID");
                return;
            }

            var author = authors[authorId];
            var book = new Book { Id = bookId, BookName = bookName, Author = author };

            books.Add(book);
            Console.WriteLine("Kitab elave edildi:" + bookName);

        }
        public void DeleteBook(int bookId)
        {
            var book = books.Find(o => o.Id == bookId);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Kitab ugurla silindi:" + book.BookName);
            }
            else
            {
                Console.WriteLine("Bele bir kitab adi tapilmadi");
            }
        }

        public void GetBook(int bookId)
        {
            var book = books.Find(o => o.Id == bookId);
            if (book != null)
            {
                Console.WriteLine("Kitab melumatlari");
                Console.WriteLine("Id:" + book.Id);
                Console.WriteLine("Kitab Adi:" + book.BookName);
                Console.WriteLine("Kitab Muellifi:" + book.Author);
            }
            else
            {
                Console.WriteLine("Bele bir kitab tapilmadi");
            }
        }
        public void UpdateBook(int bookId, string newBookName)
        {
            var book = books.Find(o => o.Id == bookId);
            if (book != null)
            {
                book.BookName = newBookName;
                Console.WriteLine("Kitab adi deyisdirildi:" + newBookName);
            }
            else
            {
                Console.WriteLine("Kitab adi deyisdirilmedi");
            }
        }
        public void SourchByAuthor(string author)
        {
            var searchName = books.FindAll(o => o.Author.Equals(author, StringComparison.Ordinal));
            if (searchName.Count > 0)
            {
                foreach (var book in searchName)
                {
                    Console.WriteLine("Axtaris neticeleri");
                    Console.WriteLine("Id:" + book.Id);
                    Console.WriteLine("Kitab Adi:" + book.BookName);
                    Console.WriteLine("Kitab Muellifi:" + book.Author);
                }
            }
            else
            {
                Console.WriteLine("Muellife uygun kitab tapilmadi");
            }
        }

    }
}
