using AdminWebApp.Models.Comment;
using AutoMapper;
using Core.Entities;

namespace AdminWebApp.MapperProfiles
{
    public class CommentMapperProfile : Profile
    {
        public CommentMapperProfile()
        {
            CreateMap<Comment,CommentDto>();
        }
    }
}
