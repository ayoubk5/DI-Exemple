using DI_Exemple.Interfaces;
using DI_Exemple.Models;
using DI_Exemple.Repositories;

namespace DI_Exemple.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAuthors() => _authorRepository.GetAllAuthors();

        public Author GetAuthor(int id) => _authorRepository.GetAuthorById(id);

        public void CreateAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author), "Author cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(author.Name))
            {
                throw new ArgumentException("Author name cannot be empty.", nameof(author));
            }

            _authorRepository.AddAuthor(author);
        }
    }

}
