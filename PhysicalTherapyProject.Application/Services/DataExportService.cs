using ClosedXML.Excel;
using Microsoft.Extensions.Configuration;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProject.Application.Services
{
    public class DataExportService : IDataExportService
    {
        private readonly IUserRepository _userRepository;
        private readonly IGenericRepository<Occupation> _occupationRepository;
        private readonly IConfiguration _config;

        private int _createdOnColumnWidth;
        private int _emailColumnWidth;
        private int _nameColumnWidth;
        private int _surnameColumnWidth;
        private int _occupationColumnWidth;

        public DataExportService(
            IUserRepository userRepository,
            IGenericRepository<Occupation> occupationRepository,
            IConfiguration config)
        {
            _userRepository = userRepository;
            _occupationRepository = occupationRepository;
            _config = config;

            GetColumnWidths(config);
        }

        private void GetColumnWidths(IConfiguration config)
        {
            _createdOnColumnWidth = config.GetValue<int>("DataExportSetting:ColumnWidths:CreatedOn");
            _emailColumnWidth = config.GetValue<int>("DataExportSetting:ColumnWidths:Email");
            _nameColumnWidth = config.GetValue<int>("DataExportSetting:ColumnWidths:Name");
            _surnameColumnWidth = config.GetValue<int>("DataExportSetting:ColumnWidths:Surname");
            _occupationColumnWidth = config.GetValue<int>("DataExportSetting:ColumnWidths:Occupation");
        }

        public async Task<byte[]> ExportExcelAsync(bool onlyConfirmedUsers)
        {
            var exportUsers = await _userRepository.GetAllAsync();
            var occupations = await _occupationRepository.GetAllAsync();

            if (onlyConfirmedUsers)
               exportUsers = exportUsers.Where(x => x.IsConfirmed).ToList();

            
            using (var workbook = new XLWorkbook())
            {
               
                int currentRow = 1;
                IXLWorksheet worksheet = GetConfiguredWorksheet(workbook, currentRow, onlyConfirmedUsers);

                foreach (var user in exportUsers)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = user.CreatedOn.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 2).Value = user.Name;
                    worksheet.Cell(currentRow, 3).Value = user.Surname;
                    worksheet.Cell(currentRow, 4).Value = user.Email;
                    worksheet.Cell(currentRow, 5).Value = occupations.First(x => x.Id == user.OccupationId).Name;

                    if(onlyConfirmedUsers == false)
                        worksheet.Cell(currentRow, 6).Value = user.IsConfirmed ? "Taip" : "Ne";
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }

        private IXLWorksheet GetConfiguredWorksheet(XLWorkbook workbook,int currentRow,bool onlyConfirmedUsers)
        {
            IXLWorksheet worksheet;
            worksheet = workbook.Worksheets.Add(sheetName: onlyConfirmedUsers ? 
                _config.GetValue<string>("DataExportSetting:WorksheetName:ConfirmedUsers") : 
                _config.GetValue<string>("DataExportSetting:WorksheetName:AllUsers"));
            worksheet.Column(1).Width = _createdOnColumnWidth;
            worksheet.Column(2).Width = _nameColumnWidth;
            worksheet.Column(3).Width = _surnameColumnWidth;
            worksheet.Column(4).Width = _emailColumnWidth;
            worksheet.Column(5).Width = _occupationColumnWidth;
            worksheet.Cell(currentRow, 1).Value = "Sukūrimo Data";
            worksheet.Cell(currentRow, 2).Value = "Vardas";
            worksheet.Cell(currentRow, 3).Value = "Pavardė";
            worksheet.Cell(currentRow, 4).Value = "El.Paštas";
            worksheet.Cell(currentRow, 5).Value = "Tipas";

            if(onlyConfirmedUsers == false)
                worksheet.Cell(currentRow, 6).Value = "Patvirtintas?";
            return worksheet;
        }
    }
}
