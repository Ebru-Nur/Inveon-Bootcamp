using LibraryManagement.Dto;
using LibraryManagement.Entities;

namespace LibraryManagement.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
    }
}
