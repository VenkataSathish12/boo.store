using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Bookstore.Models;
using WebApp.Bookstore.Repository;

namespace WebApp.Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();

            return View();
        }
        public BookModel GetBook(int id) 
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string BookName, string AuthorName)
        {
            return _bookRepository.SearchBook(BookName, AuthorName);
        }
    }
}
