using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Application.Infrastructure.Extensions;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize(Roles = "Administratorius,Registruotas naudotojas")]
    public class ArticleController : BasePostController
    {
        private readonly IGenericRepository<Tag> _tagRepository;
        private readonly static int postTypeId = (int)PostTypes.Article;
        private readonly static int itemsPerPage = 10;

        public ArticleController(IPostService postService, IGenericRepository<Tag> tagRepository,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(postService, postTypeId, signInManager, userManager)
        {
            _tagRepository = tagRepository;
        }

        [HttpGet("straipsniai/puslapis/{pageNumber}")]
        public async Task<IActionResult> PagedIndexAsync([FromRoute]int pageNumber, [FromQuery(Name = "paieska")]string searchFor,
            [FromQuery(Name = "tag")] string searchTag)
        {
            var articles = await _postService.GetAllByTypeAsync(postTypeId);

            if (!String.IsNullOrEmpty(searchFor))
            {
                articles = articles.Filter(searchFor);
            }

            if (!String.IsNullOrEmpty(searchTag))
            {
                articles  = await FilterByTag(articles, searchTag);
            }

            var pageArticles = articles.OrderByDescending(x => x.CreatedOn)
            .Skip((pageNumber - 1) * itemsPerPage)
            .Take(itemsPerPage).ToList();

            if ((pageArticles.Count == 0 || pageNumber < 1) && pageNumber != 1)
                return NotFound();

            var tags = await _tagRepository.GetAllAsync();
            var viewmodel = new ArticlePagedIndexViewModel()
            {
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling((double)articles.Count / itemsPerPage),
                Tags = tags.ToList(),
                Articles = pageArticles
            };

            return View(viewmodel);
        }

        private async Task<IList<Post>> FilterByTag(ICollection<Post> articles, string searchTag)
        {
            var tagsCollection = await _tagRepository.GetAllAsync();
            var tag = tagsCollection.FirstOrDefault(t => t.TagValue == searchTag);
            if (tag != null)
            {
                return articles.Where(a => a.PostTags.FirstOrDefault(pt => pt.TagId == tag.Id) != null).ToList();
            }

            return articles.ToList();
        }

        [HttpGet]
        [Authorize(Roles = "Administratorius")]
        public override ActionResult Create()
        {
            var tags = _tagRepository.GetAllAsync().Result;
            return View(new PostViewModel
            {
                Post = new Post() { PostTypeId = (int)PostTypes.Article },
                Tags = tags.ConvertToSelectListItems()
            });
        }

        [HttpGet]
        [Authorize(Roles = "Administratorius")]
        public override async Task<IActionResult> Edit(int id)
        {
            var tags = await _tagRepository.GetAllAsync();
            return View(nameof(Create), new PostViewModel()
            {
                Post = await _postService.GetByIdAsync(id),
                Tags = tags.ConvertToSelectListItems()
            });
        }
    }
}