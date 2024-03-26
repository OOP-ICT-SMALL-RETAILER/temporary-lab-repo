namespace RetailThingey.Application.Models.Review;

public class ReviewResponse(string message)
{
    public string Message { get; set; } = message;
}