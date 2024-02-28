using RetailThingey.Application.Models;

namespace RetailThingey.Application.Contracts.User;

public interface IRegisterUser
{
    IRegisterUser SetName(string name);
    IRegisterUser SetEmail(string email);
    IRegisterUser SetPassword(string password);
    RegisterUser Build();
}