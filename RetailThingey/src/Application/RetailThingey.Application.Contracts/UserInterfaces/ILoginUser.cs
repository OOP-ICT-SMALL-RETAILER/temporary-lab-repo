using RetailThingey.Application.Models;

namespace RetailThingey.Application.Contracts.User;

public interface ILoginUser
{
    ILoginUser SetEmail(string email);
    ILoginUser SetPassword(string password);
    LoginUser Build();
}