using System.Collections.ObjectModel;

namespace RetailThingey.Application.Models.Review;

public class ReviewResponseByUser(Collection<Review> reviews)
{
    public Collection<Review> Reviews { get; } = reviews;
}