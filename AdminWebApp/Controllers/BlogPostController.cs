using AdminWebApp.Models.BlogPost;
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

        public BlogPostController(IPostService postBusinessService)
        {
            _postBusinessService = postBusinessService;
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
    }
}
