using LibraryApp.Entities;
using LibraryApp.Enums;
using LibraryApp.Exceptions;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class BookService
    {
        private readonly BookRepository bookRepo;

        public BookService(BookRepository repository)
        {
            bookRepo = repository;
        }

        public IEnumerable<Book> GetBooks(int pageNumber, int pageSize) => bookRepo.GetAll(pageNumber, pageSize);

        public Book GetBookById(int id) => bookRepo.GetById(id) ?? throw new ApiException("Kitap Bulunamadı", ErrorCodes.NotFound);

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ApiException("Kitap bilgisi gelmedi", ErrorCodes.BadRequest);
            }
            bookRepo.Add(book);
        }

        public void UpdateBook(Book book) => bookRepo.Update(book);

        public void DeleteBook(int id) => bookRepo.Delete(id);
    }

}
