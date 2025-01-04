using DI_Exemple.Interfaces;
using DI_Exemple.Models;
using DI_Exemple.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_Exemple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAuthors() => Ok(_authorService.GetAuthors());
        [HttpPost]

        public IActionResult AddAuthor(Author author)
        {
            _authorService.CreateAuthor(author);
            return Ok();
        }
    }

}
