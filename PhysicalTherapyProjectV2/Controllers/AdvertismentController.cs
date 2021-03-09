using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Domain.Models;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class AdvertismentController : BasePostController
    {
        public AdvertismentController(IPostService postService,
             SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(postService, (int)PostTypes.Advertisment, signInManager, userManager) { }


    }
}