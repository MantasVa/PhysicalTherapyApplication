using PhysicalTherapyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicalTherapyProject.Application.Infrastructure.Extensions
{
    public static class PostFilteringExtensions
    {
        private const StringComparison _stringComparisonType = StringComparison.OrdinalIgnoreCase;       
        public static ICollection<Post> Filter(this ICollection<Post> posts, string searchFor)
        {
            return posts.Where(post => post.Title.Contains(searchFor, _stringComparisonType)
                || post.Body.Contains(searchFor, _stringComparisonType)).ToList();
        }

    }
}
