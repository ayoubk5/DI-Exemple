using DI_Exemple.Interfaces;
using DI_Exemple.Models;

namespace DI_Exemple.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks() => _bookRepository.GetAllBooks();

        public Book GetBook(int id) => _bookRepository.GetBookById(id);

        public void CreateBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
            {
                throw new ArgumentException("Book title cannot be empty.");
            }

            _bookRepository.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            if (book == null || string.IsNullOrWhiteSpace(book.Title))
            {
                throw new ArgumentException("Invalid book data.");
            }

            _bookRepository.UpdateBook(book);
        }

        public void RemoveBook(int id) => _bookRepository.DeleteBook(id);
    }


}
