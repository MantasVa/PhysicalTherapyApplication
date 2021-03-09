using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Domain.Models;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class TeamMemberController : BasePostController
    {
        private readonly static int postTypeId = (int)PostTypes.TeamMember;

        public TeamMemberController(IPostService postService,
            SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            : base(postService,postTypeId,signInManager, userManager) { }
    
    }
}
