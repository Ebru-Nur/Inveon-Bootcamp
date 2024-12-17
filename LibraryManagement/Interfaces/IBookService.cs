using LibraryManagement.Dto;
using LibraryManagement.Entities;

namespace LibraryManagement.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookListDto>> GetAllBooksAsync();
        Task<BookDetailsDto> GetBookByIdAsync(int id);
    }
}
