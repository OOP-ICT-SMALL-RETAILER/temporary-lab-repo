using RetailThingey.Application.Models;

namespace RetailThingey.Application.Contracts.User;

public interface IAddress
{
    IAddress SetID(String ID);
    Address Build();
}