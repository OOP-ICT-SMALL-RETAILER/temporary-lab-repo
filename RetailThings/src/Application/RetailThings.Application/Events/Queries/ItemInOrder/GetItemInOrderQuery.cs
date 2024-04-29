using MediatR;
using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Events.Queries.ItemInOrder;

public class GetItemInOrderQuery : IRequest<GetItemInOrderModel?>
{
    public required int ItemInOrderId { get; set; }
}
