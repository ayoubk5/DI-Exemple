using DI_Exemple.Interfaces;
using DI_Exemple.Models;

namespace DI_Exemple.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly List<Author> _authors = new();

        public IEnumerable<Author> GetAllAuthors() => _authors;

        public Author GetAuthorById(int id) => _authors.FirstOrDefault(a => a.Id == id);
        public void AddAuthor(Author author)
        {
            author.Id = _authors.Count + 1;
            _authors.Add(author);
        }

    }

}
