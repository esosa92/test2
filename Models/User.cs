using System.Runtime.CompilerServices;
using Test2.Controllers;

namespace Test2.Models;

public class User
{
    private static int _userCount = 0;
    public User()
    {
        _userCount++;
    }

    public static int CantidadUsuarios => _userCount;//{get;}

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string LastName { get; set; } = "";
    public string FullName => $"{this.Name.ToUpper()} {this.LastName.ToUpper()}";
    public string Password { get; set; } = "";

    public string Email { get; set; } = "";
    
    //Recordatorio Genero para enums
    public int genero { get; set; }
}