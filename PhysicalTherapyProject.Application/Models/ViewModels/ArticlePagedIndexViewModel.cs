using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProject.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace PhysicalTherapyProject.Application.Models.ViewModels
{
    public class ArticlePagedIndexViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public IList<Post> Articles { get; set; }
        public IList<Tag> Tags { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Paieska { get; set; }
    }
}
