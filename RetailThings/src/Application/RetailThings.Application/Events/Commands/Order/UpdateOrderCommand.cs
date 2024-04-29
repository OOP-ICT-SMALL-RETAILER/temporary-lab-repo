using MediatR;
using RetailThings.Application.Models.Order;

namespace RetailThings.Application.Events.Commands.Order;

public class UpdateOrderCommand : IRequest
{
    public required CreateOrderModel CreateOrderModel { get; set; }
}
