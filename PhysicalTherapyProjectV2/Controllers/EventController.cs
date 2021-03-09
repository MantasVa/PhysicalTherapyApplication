using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Domain.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PhysicalTherapyProjectV2.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class EventController : BasePostController
    {
        public EventController(IPostService postService,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(postService, (int)PostTypes.Event, signInManager, userManager)
        { }

        [HttpPost]
        [Authorize(Roles = "Administratorius")]
        public async Task<IActionResult> ActivateEvent(int id)
        {
            var article = await _postService.GetByIdAsync(id);
            article.Status = true;
            await _postService.UpdateAsync(article);
            TempData["message"] = $"Renginys '{article.Title}' buvo aktyvuotas!";
            return RedirectToAction("AdminList", "Event");
        }
    }
}
