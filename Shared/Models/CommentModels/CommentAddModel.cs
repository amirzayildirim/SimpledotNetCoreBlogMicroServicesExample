using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models.CommentModels;

public class CommentAddModel
{
    [Required]
    public int CommentId { get; set; }
    [Required]
    public string Comment { get; set; }
}
