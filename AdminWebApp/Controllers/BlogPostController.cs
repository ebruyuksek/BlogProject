using AdminWebApp.Models.BlogPost;
using AutoMapper;
using Business.Abstract;
using Core.Entities;
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
            var model = new BlogPostListViewModel();

            var blogList = _postBusinessService.GetAll();

            model.BlogPosts = _mapper.Map<List<BlogPostDto>>(blogList);

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BlogPostCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var post = _mapper.Map<Post>(model);
            _postBusinessService.Add(post);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var post = _postBusinessService.GetById(id);
            var model = _mapper.Map<UpdatePostViewModel>(post);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UpdatePostViewModel updatePostViewModel)
        {
            var post = _mapper.Map<Post>(updatePostViewModel);
            _postBusinessService.Update(post);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _postBusinessService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
