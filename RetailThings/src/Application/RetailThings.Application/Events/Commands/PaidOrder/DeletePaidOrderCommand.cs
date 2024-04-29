using MediatR;

namespace RetailThings.Application.Events.Commands.PaidOrder;

public class DeletePaidOrderCommand : IRequest
{
    public required int PaidOrderId { get; set; }
}
