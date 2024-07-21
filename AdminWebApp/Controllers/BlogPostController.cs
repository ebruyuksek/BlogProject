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
            
            //return View(model);
        }

        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(BlogPostCreateViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var post = _mapper.Map<Post>(model);
            _postBusinessService.Add(post);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(UpdatePostViewModel updatePostViewModel)
        {
            var post = _mapper.Map<Post>(updatePostViewModel);
            _postBusinessService.Update(post);

            return View();
        }
    }
}
