using System.Collections.Generic;
using PhysicalTherapyProject.Domain.Models;

namespace PhysicalTherapyProject.Application.Models.ViewModels
{
    public class AdminIndexViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }

        public int PostsCount { get; set; }
        public int EventsCount { get; set; }
        public int TeamMembersCount { get; set; }
    }
}
