﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using PhysicalTherapyProject.Application.Infrastructure.ValidationAttributes;

namespace PhysicalTherapyProject.Application.Models.DTO
{
    public class RegistrationDto
    {
        [Required(ErrorMessage = "Neįvestas Vardas")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Neįvesta Pavardė")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Neįvestas El. Paštas")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Neįvestas Slaptažodis")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Slaptažodis turi būti mažiausiai 6 simbolių")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Neįvestas Slaptažodis")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Slaptažodžiai Nesutampa")]
        public string ConfirmPassword { get; set; }
        [NotEqual("Pasirinkti", ErrorMessage = "Nepasirinkta Okupacija")]
        public string OccupationId { get; set; }
        [EnforceTrue(ErrorMessage = "Nesutikote Su Taisyklėmis")]
        public bool AgreedToRules { get; set; }
    }
}
