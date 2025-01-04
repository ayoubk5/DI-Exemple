using DI_Exemple.Models;

namespace DI_Exemple.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(int id);
        void CreateAuthor(Author author);

    }

}
