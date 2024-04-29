using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable

public class Review
{
    [Column("ReviewId")]
    public int ReviewId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public double Rating { get; set; }
    public string Description { get; set; }
}
