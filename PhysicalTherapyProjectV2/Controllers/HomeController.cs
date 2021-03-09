using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure.Enums;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository _postRepository;
        private int _articlesCountInHomepage = 10;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet("namai")]
        public async Task<IActionResult> Index()
        {
            var posts = await _postRepository.GetAllByTypeAsync((int)PostTypes.Article);

            return View(posts.Where(p => p.isForAuthenticatedUser == false).OrderByDescending(p => p.CreatedOn)
                .Take(_articlesCountInHomepage).ToList());
        }

        [HttpGet("privatumo-politika")]
        public IActionResult Privacy() => View();

        [HttpGet("apie-mus")]
        public async Task<IActionResult> AboutUs() => View(await _postRepository.GetAllByTypeAsync((int)PostTypes.TeamMember));

        [HttpGet("bendradarbiavimas")]
        public IActionResult Partnership() => View();

        [HttpGet("klaida")]
        public IActionResult Error() => View();
    }
}
