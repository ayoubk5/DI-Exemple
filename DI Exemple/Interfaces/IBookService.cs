using DI_Exemple.Models;

namespace DI_Exemple.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void RemoveBook(int id);
    }


}
