using AdminWebApp.Models.BlogPost;
using AutoMapper;
using Core.Entities;

namespace AdminWebApp.MapperProfiles
{
    public class BlogPostMapperProfile : Profile
    {
        public BlogPostMapperProfile()
        {
            CreateMap<UpdatePostViewModel, Post>().ReverseMap();
            CreateMap<BlogPostCreateViewModel, Post>();
            CreateMap<BlogPostDto, Post>().ReverseMap();
        }
    }
}
