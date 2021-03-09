
using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Domain.Infrastructure.Interfaces;
using System;

namespace PhysicalTherapyProject.Domain.Models
{
    public class ApplicationRole : IdentityRole<int>, IEntity
    {
        public ApplicationRole()
        {
            this.CreatedOn = DateTime.Now;
            this.UpdatedOn = DateTime.Now;
        }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
