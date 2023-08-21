using AutoMapper;
using BookstoreApp.API.Data;
using BookstoreApp.API.Models.Author;
using BookstoreApp.API.Models.Book;

namespace BookstoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<BookReadOnlyDto, Book>().ReverseMap();
        }
    }
}
