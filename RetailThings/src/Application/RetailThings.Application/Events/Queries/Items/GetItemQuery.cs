using MediatR;
using RetailThings.Application.Models.Item;

namespace RetailThings.Application.Events.Queries.Items;

public class GetItemQuery : IRequest<GetItemModel?>
{
    public required int ItemId { get; set; }
}
