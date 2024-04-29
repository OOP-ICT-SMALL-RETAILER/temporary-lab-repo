using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable
public class User
{
    [Column("UserId")]
    public int UserId { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }
}
