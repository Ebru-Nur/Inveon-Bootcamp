using AutoMapper;
using LibraryManagement.Dto;
using LibraryManagement.Entities;

namespace LibraryManagement.Utils
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookListDto>();
            CreateMap<Book, BookDetailsDto>();
        }
    }
}
