using AdminWebApp.Models.PostCategory;
using AutoMapper;
using Business.Abstract;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdminWebApp.Controllers
{
    public class PostCategoryController : Controller
    {
        private readonly IPostCategoryService _postCategoryBusinessService;
        private readonly IMapper _mapper;

        public PostCategoryController(IPostCategoryService postCategoryBusinessService, IMapper mapper)
        {
            _postCategoryBusinessService = postCategoryBusinessService;
            _mapper = mapper;
        }

        public IActionResult Index(bool? isActionHasOccured, string? actionMessage)
        {
            var model = new PostCategoryListViewModel();

            if (isActionHasOccured != null || actionMessage != null)
            {
                model.IsActionHasOccured = isActionHasOccured ?? false;
                model.ActionMessage = actionMessage;
            }

            var blogList = _postCategoryBusinessService.GetAll();

            model.PostCategories = _mapper.Map<List<PostCategoryDto>>(blogList);

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PostCategoryCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var postCategory = _mapper.Map<PostCategory>(model);
            _postCategoryBusinessService.Add(postCategory);

            return RedirectToAction("Index", new
            {
                actionMessage = "Post category added successfully",
                isActionHasOccured = true
            });
        }

        public IActionResult Edit(int id)
        {
            var post = _postCategoryBusinessService.GetById(id);
            var model = _mapper.Map<PostCategoryUpdateModel>(post);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(PostCategoryUpdateModel updatePostViewModel)
        {
            var postCategory = _mapper.Map<PostCategory>(updatePostViewModel);
            _postCategoryBusinessService.Update(postCategory);

            return RedirectToAction("Index", new
            {
                actionMessage = "Post category updated successfully",
                isActionHasOccured = true
            });
        }
    }
}
