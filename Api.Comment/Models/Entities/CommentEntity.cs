using Shared.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Comment.Models.Entities;

[Table("Comment")]
public class CommentEntity : BaseEntities
{
    [Required]
    public int ContentId { get; set; }
    [Required]
    public string Comment { get; set; }
}