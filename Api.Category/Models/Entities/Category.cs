using Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace Api.Category.Models;

public class Category : BaseEntities
{
    [Required]
    [StringLength(maximumLength:100,MinimumLength =3)]
    public string CategoryName { get; set; }
}
