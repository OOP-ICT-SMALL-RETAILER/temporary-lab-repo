using RetailThingey.Application.Models;

namespace RetailThingey.Application.Contracts.User;

public interface IUser
{
    IUser SetID(int id);
    IUser SetHashPassword(string hashPassword);
    IUser SetName(string name);
    IUser SetEmail(string email);
    IUser SetDeliveryAddress(Address address);
    Models.User Build();
}