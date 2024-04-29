using MediatR;
using RetailThings.Application.Models.Order;

namespace RetailThings.Application.Events.Commands.Order;

public class CreateOrderCommand : IRequest
{
    public required CreateOrderModel CreateOrderModel { get; set; }
}
