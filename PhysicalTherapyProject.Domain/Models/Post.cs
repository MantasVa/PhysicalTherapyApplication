using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhysicalTherapyProject.Domain.Models
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Images = new HashSet<Image>();
            PostTags = new HashSet<PostTag>();
        }
        [Required(ErrorMessage = "Neįvestas pavadinimas")]
        [MinLength(2, ErrorMessage = "Per trumpas pavadinimas")]
        [MaxLength(500, ErrorMessage = "Per ilgas pavadinimas")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Neįvestas aprašymas")]
        [MinLength(2 , ErrorMessage = "Per trumpas aprašymas")]
        [MaxLength(50000, ErrorMessage = "Per ilgas aprašymas")]
        public string Body { get; set; }
        public bool isForAuthenticatedUser { get; set; }
        public ICollection<Image> Images { get; set; }
        public DateTime Date { get; set; }
        [Range(0,double.MaxValue, ErrorMessage = "Netinkama kaina")]
        public decimal EventPrice { get; set; }
        public ApplicationUser PostUser { get; set; }
        public int? PostTypeId { get; set; }
        public PostType PostType { get; set; }
        public bool? Status { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public override string ToString() => Title;
    }
}
