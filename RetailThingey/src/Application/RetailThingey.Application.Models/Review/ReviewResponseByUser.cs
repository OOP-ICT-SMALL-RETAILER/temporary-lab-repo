using System.Collections.ObjectModel;

namespace RetailThingey.Application.Models.Review;

public class ReviewResponseByUser(Collection<ReviewModels> reviews)
{
    public Collection<ReviewModels> Reviews { get; } = reviews;
}