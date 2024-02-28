using RetailThingey.Application.Models;

namespace RetailThingey.Application.Contracts.User;

public interface IPreferredAddress
{
    IPreferredAddress SetUserCookie(string userCookie);
    IPreferredAddress SetChosenPickUpPointID(string chosenPickUpPointID);
    PreferredAddress Build();
}