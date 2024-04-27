using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable

public class Order
{
    [Column("OrderId")]
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int PickUpPointId { get; set; }
    public PickUpPoint PickUpPoint { get; set; }
    public string Status { get; set; }
    public List<ItemInOrder> ItemInOrders { get; set; }
}
