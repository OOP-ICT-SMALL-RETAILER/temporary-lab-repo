using MediatR;
using RetailThings.Application.Models.PaidOrder;

namespace RetailThings.Application.Events.Commands.PaidOrder;

public class CreatePaidOrderCommand : IRequest
{
    public required CreatePaidOrderModel CreatePaidOrderModel { get; set; }
}
