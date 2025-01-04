using DI_Exemple.Models;

namespace DI_Exemple.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        void AddAuthor(Author author);

    }

}
