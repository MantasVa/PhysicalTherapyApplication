using Microsoft.AspNetCore.Mvc.Rendering;
using PhysicalTherapyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PhysicalTherapyProject.Application.Infrastructure.ValidationAttributes;

namespace PhysicalTherapyProject.Application.Models.ViewModels
{
    public class ChangeUserRolesViewModel
    {
        public ChangeUserRolesViewModel()
        {
            Users = new List<SelectListItem>();
            Roles = new List<SelectListItem>();
        }
        public List<SelectListItem> Users { get; set; }
        public List<SelectListItem> Roles { get; set; }

        [NotEqual("Pasirinkti", ErrorMessage = "Nepasirinktas vartotojas")]
        public string SelectedUserId { get; set; }
        [NotEqual("Pasirinkti", ErrorMessage = "Nepasirinkta rolė")]
        public string SelectedRoleId { get; set; }

        public void ConvertToSelectList(List<ApplicationUser> applicationUsers)
        {
            foreach(var user in applicationUsers)
            {
                Users.Add(new SelectListItem { Text = user.Email, Value = user.Id.ToString() });
            }
        }

        public void ConvertToSelectList(List<ApplicationRole> applicationRoles)
        {
            foreach (var role in applicationRoles)
            {
                Roles.Add(new SelectListItem { Text = role.Name, Value = role.Id.ToString() });
            }
        }
    }
}
