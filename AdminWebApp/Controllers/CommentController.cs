using AdminWebApp.Models.Comment;
using AdminWebApp.Models.PostCategory;
using AutoMapper;
using Bogus;
using Business.Abstract;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdminWebApp.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Generate()
        {
            var faker = new Faker<Comment>()
            .RuleFor(p => p.Text, f => f.Lorem.Paragraph(1))
            .RuleFor(p => p.PostId, _ => 13);

            var comments = faker.Generate(10);

            foreach (var comment in comments)
            {
                _commentService.Add(comment);
            }

            return RedirectToAction("Index", new
            {
                actionMessage = "Comment added successfully",
                isActionHasOccured = true
            });
        }

        public IActionResult Index()
        {
            var model = new CommentListViewModel();

            var commentList = _commentService.GetAll();

            model.CommentList = _mapper.Map<List<CommentDto>>(commentList);

            return View(model);
        }
    }
}
