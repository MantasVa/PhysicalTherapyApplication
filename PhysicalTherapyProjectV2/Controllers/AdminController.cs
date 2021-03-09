using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Application.Infrastructure.Interfaces;
using PhysicalTherapyProject.Application.Models.ViewModels;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Infrastructure.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using PhysicalTherapyProject.Application.Infrastructure.Enums;

namespace PhysicalTherapyProjectV2.Controllers
{
    [Authorize(Roles = "Administratorius")]
    [AutoValidateAntiforgeryToken]
    public class AdminController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IGenericRepository<ApplicationRole> _applicationRole;
        private readonly IDataExportService _dataExportService;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IPostService _postService;

        public AdminController(
            IUserRepository userRepository,
            IGenericRepository<ApplicationRole> applicationRole,
            IDataExportService dataExportService,
            IUserRoleRepository userRoleRepository,
            RoleManager<ApplicationRole> roleManager,
            IPostService postService)
        {
            _userRepository = userRepository;
            _applicationRole = applicationRole;
            _dataExportService = dataExportService;
            _userRoleRepository = userRoleRepository;
            _roleManager = roleManager;
            _postService = postService;
        }

        [HttpGet("administratoriaus-panelė")]
        public async Task<IActionResult> Index()
        {
            var posts = await _postService.GetAllAsync();
            return View( new AdminIndexViewModel
            {
                Users = await _userRepository.GetAllAsync(),
                PostsCount = posts.Count(p => p.PostTypeId == (int)PostTypes.Article),
                EventsCount = posts.Count(p => p.PostTypeId == (int)PostTypes.Event),
                TeamMembersCount = posts.Count(p => p.PostTypeId == (int)PostTypes.TeamMember)
            });
        }

        #region USER
        [HttpPost]
        public async Task<IActionResult> ConfirmUser(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            user.IsConfirmed = true;
            await _userRepository.UpdateAsync(user);

            var role = await _roleManager.FindByNameAsync("Registruotas naudotojas");
            await _userRoleRepository.UpdateRole(userId.ToString(), role.Id.ToString());

            TempData["message"] = $"{user.Name} {user.Surname} buvo patvirtintas!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            await _userRepository.DeleteAsync(userId);
            TempData["message"] = $"{user.Name} {user.Surname} buvo ištrintas!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
         
        #region Change User Roles

        [HttpGet("keisti-roles")]
        public async Task<IActionResult> ChangeUserRoles()
        {
            var changeUserRoleViewModel = new ChangeUserRolesViewModel();
            changeUserRoleViewModel.ConvertToSelectList((await _userRepository.GetAllAsync()).ToList());
            changeUserRoleViewModel.ConvertToSelectList((await _applicationRole.GetAllAsync()).ToList());
            return View(changeUserRoleViewModel);
        }

        [HttpPost("keisti-roles")]
        public async Task<IActionResult> ChangeUserRoles(ChangeUserRolesViewModel changeUserRolesViewModel)
        {
            if (!ModelState.IsValid)
            {
                changeUserRolesViewModel.ConvertToSelectList((await _userRepository.GetAllAsync()).ToList());
                changeUserRolesViewModel.ConvertToSelectList((await _applicationRole.GetAllAsync()).ToList());
                return View(changeUserRolesViewModel);
            }

            await _userRoleRepository.UpdateRole(changeUserRolesViewModel.SelectedUserId, changeUserRolesViewModel.SelectedRoleId);
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Users Export
        [HttpGet("naudotoju-eksportas")]
        public async Task<IActionResult> ExportUsersViaExcelAsync(bool onlyConfirmedUsers = true)
        {
            try
            {
                var contentBytes = await _dataExportService.ExportExcelAsync(onlyConfirmedUsers);

                return File(
                       contentBytes,
                       "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                       "naudotojai.xlsx");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }            
        }

        #endregion

    }
}
