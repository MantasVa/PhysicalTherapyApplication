using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRoleRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task UpdateRole(string userId, string roleId)
        {
            var userRole = await _applicationDbContext.UserRoles.Where(x => x.UserId == Int32.Parse(userId)).FirstOrDefaultAsync();

            if (userRole != null)
            {
                _applicationDbContext.UserRoles.Remove(userRole);
                await _applicationDbContext.SaveChangesAsync();

                userRole.RoleId = Int32.Parse(roleId);
                _applicationDbContext.UserRoles.Add(userRole);
                await _applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
