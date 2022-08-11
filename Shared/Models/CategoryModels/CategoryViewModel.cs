namespace Shared.Models.CategoryModels;

public class CategoryViewModel
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? UpdateOn { get; set; }
}
