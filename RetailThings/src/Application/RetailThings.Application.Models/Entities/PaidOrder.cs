using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable

public class PaidOrder
{
    [Column("PaidOrderId")]
    public int PaidOrderId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public DateTimeOffset DatePaid { get; set; }
}
