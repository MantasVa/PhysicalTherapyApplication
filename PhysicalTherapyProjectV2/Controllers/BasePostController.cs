using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize(Roles = "Administratorius,Registruotas naudotojas")]
    [AutoValidateAntiforgeryToken]
    public abstract class BasePostController : Controller
    {
        protected IPostService _postService;
        private int _postType;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public BasePostController(IPostService postService, int postType,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _postService = postService;
            _postType = postType;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var posts = await _postService.GetAllByTypeAsync(_postType);
            posts = posts.OrderByDescending(x => x.CreatedOn).ToList();
            return View(posts);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get(int id)
        {
            Post post = await _postService.GetByIdAsync(id);

            bool x = HttpContext.User.Identity.IsAuthenticated;
            if (x || post.isForAuthenticatedUser == false)
            {
                return View(post);
            }
            return Unauthorized();
        }

        [HttpGet]
        [Authorize(Roles = "Administratorius")]
        public async Task<ActionResult> AdminList()
        {
            var posts = await _postService.GetAllByTypeAsync(_postType);
            posts = posts.OrderByDescending(x => x.CreatedOn).ToList();
            return View(posts);
        }


        [HttpGet]
        [Authorize(Roles = "Administratorius")]
        public virtual ActionResult Create() => View(new PostViewModel
        {
            Post = new Post() { PostTypeId = _postType }
        });

        [HttpPost]
        [Authorize(Roles = "Administratorius")]
        public async Task<ActionResult> Create(PostViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel.CurrentView, viewModel);
            }

            try
            {
                await _postService.CreatePostAsync(viewModel);
                TempData["message"] = _postService.ServiceMessage;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("File Error", ex.Message);
                return View(viewModel.CurrentView, viewModel);
            }

            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        [Authorize(Roles = "Administratorius")]
        public virtual async Task<IActionResult> Edit(int id) =>
          View(nameof(Create), new PostViewModel()
          {
            Post = await _postService.GetByIdAsync(id)
          });

        [HttpPost]
        [Authorize(Roles = "Administratorius")]
        public async Task<IActionResult> Delete(int id)
        {
            var post = await _postService.GetByIdAsync(id);
            await _postService.DeleteAsync(id);
            TempData["message"] = $"Įrašas '{post.Title}' buvo ištrintas!";
            return RedirectToAction("Index", "Admin");
        }
    }
}
