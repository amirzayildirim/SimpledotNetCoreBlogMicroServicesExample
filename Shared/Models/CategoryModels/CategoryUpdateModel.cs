using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models.CategoryModels;

public class CategoryUpdateModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(maximumLength: 100, MinimumLength = 3)]
    public string CategoryName { get; set; }
}
