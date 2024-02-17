using System.Collections.Generic;
using System.Linq;
using WebApp.Bookstore.Models;

namespace WebApp.Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorname)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Mohan" },
                new BookModel() { Id = 2, Title = "Java", Author = "Mahesh" },
                new BookModel() { Id = 3, Title = "Dot Net Core", Author = "Mohan" },
                new BookModel() { Id = 4, Title = "Python", Author = "Pradeep" },
                new BookModel() { Id = 5, Title = "Azure", Author = "Raju" },
            };
        }
    }
}
