using AdminWebApp.Models.BlogPost;
using AutoMapper;
using Bogus;
using Business.Abstract;
using Business.Concrete;
using Core.Entities;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdminWebApp.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IPostService _postBusinessService;
        private readonly IMapper _mapper;

        public BlogPostController(IPostService postBusinessService, IMapper mapper)
        {
            _postBusinessService = postBusinessService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var blogPostFaker = new Faker<BlogPostDto>()
           .RuleFor(o => o.Title, f => f.Lorem.Sentence())
           .RuleFor(o => o.CreatedDateTime, f => f.Date.Recent());

            var model = new BlogPostListViewModel
            {
                BlogPosts = blogPostFaker.Generate(10).ToList()
            };

            return View(model);
        }

        //public IActionResult Get(Guid postId)
        //{
        //    var result = _postDal.Get(x => x.Id == postId, null);
        //    return View();
        //}

        //public IActionResult Add(BlogPostAddDto model)
        //{
        //    return View();
        //}

        public IActionResult Add()
        {
            var post = new Faker<Post>()
                 .RuleFor(o => o.Title, f => f.Lorem.Sentence())
                 .RuleFor(o => o.Text, f => f.Lorem.Sentence());
                 
            _postBusinessService.Add(post);
            return View();
        }

        public IActionResult Edit(UpdatePostViewModel updatePostViewModel)
        {
            var post = _mapper.Map<Post>(updatePostViewModel);
            _postBusinessService.Update(post);

            return View();
        }
    }
}
