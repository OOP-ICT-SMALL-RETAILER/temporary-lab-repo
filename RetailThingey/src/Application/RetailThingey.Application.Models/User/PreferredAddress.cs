namespace RetailThingey.Application.Models;

public class PreferredAddress(string userCookie, string chosenPickUpPointId)
{
    public string UserCookie { get; set; } = userCookie;
    public string ChosenPickUpPointID { get; set; } = chosenPickUpPointId;
}