using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Persistance.Infrastructure.Interfaces
{
    public interface IUserRoleRepository
    {
        Task UpdateRole(string userId, string roleId);
    }
}
