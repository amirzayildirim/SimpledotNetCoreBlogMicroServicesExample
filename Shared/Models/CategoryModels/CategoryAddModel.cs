using System.ComponentModel.DataAnnotations;

namespace Shared.Models.CategoryModels;

public class CategoryAddModel
{
    [Required]
    [StringLength(maximumLength: 100, MinimumLength = 3)]
    public string CategoryName { get; set; }
}
