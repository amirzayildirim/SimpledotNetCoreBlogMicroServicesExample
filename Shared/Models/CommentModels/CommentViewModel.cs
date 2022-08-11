using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models.CommentModels;

public class CommentViewModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int ContentId { get; set; }
    [Required]
    public string Comment { get; set; }
}