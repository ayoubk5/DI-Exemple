using DI_Exemple.Interfaces;
using DI_Exemple.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI_Exemple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBooks() => Ok(_bookService.GetBooks());

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookService.CreateBook(book);
            return Ok();
        }
    }

}
