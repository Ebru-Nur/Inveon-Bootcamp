using AutoMapper;
using LibraryManagement.Dto;
using LibraryManagement.Entities;
using LibraryManagement.Interfaces;
using LibraryManagement.Repository;

namespace LibraryManagement.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BookListDto>> GetAllBooksAsync()
        {
            var books = await unitOfWork.Books.GetAllBooksAsync();
            return mapper.Map<IEnumerable<BookListDto>>(books);
        }

        public async Task<BookDetailsDto> GetBookByIdAsync(int id)
        {
            var book = await unitOfWork.Books.GetBookByIdAsync(id);
            return mapper.Map<BookDetailsDto>(book);
        }


    }
}
