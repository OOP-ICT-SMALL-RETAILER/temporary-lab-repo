namespace RetailThingey.Application.Models.Review;

public class ChangeReviewResponse(string message)
{
    public string Message { get; set; } = message;
}