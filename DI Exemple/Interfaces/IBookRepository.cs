using DI_Exemple.Models;

namespace DI_Exemple.Interfaces
{
    public interface IBookRepository
    {
            IEnumerable<Book> GetAllBooks();
            Book GetBookById(int id);
            void AddBook(Book book);
            void UpdateBook(Book book);
            void DeleteBook(int id);
        

    }

}
