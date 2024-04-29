using MediatR;
using RetailThings.Application.Models.PaidOrder;

namespace RetailThings.Application.Events.Commands.PaidOrder;

public class UpdatePaidOrderCommand : IRequest
{
    public required CreatePaidOrderModel CreatePaidOrderModel { get; set; }
}
