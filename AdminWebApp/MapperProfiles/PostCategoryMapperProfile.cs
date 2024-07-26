using AdminWebApp.Models.PostCategory;
using AutoMapper;
using Core.Entities;

namespace AdminWebApp.MapperProfiles
{
    public class PostCategoryMapperProfile : Profile
    {
        public PostCategoryMapperProfile()
        {
            CreateMap<PostCategoryUpdateModel, PostCategory>().ReverseMap();
            CreateMap<PostCategoryCreateViewModel, PostCategory>();
            CreateMap<PostCategoryDto, PostCategory>().ReverseMap();
        }
    }
}
