using System.Threading.Tasks;

namespace PhysicalTherapyProject.Application.Infrastructure.Interfaces
{
    public interface IDataExportService
    {
        Task<byte[]> ExportExcelAsync(bool onlyConfirmedUsers);
    }
}
