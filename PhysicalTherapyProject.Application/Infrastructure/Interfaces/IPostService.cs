using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Application.Infrastructure.Interfaces
{
    public interface IPostService : IPostRepository
    {
        string ServiceMessage { get; }
        Task CreatePostAsync(PostViewModel viewmodel);
    }
}