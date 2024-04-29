using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable

public class PickUpPoint
{
    [Column("PickUpPointId")]
    public int PickUpPointId { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
}
