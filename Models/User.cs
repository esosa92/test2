using System.Runtime.CompilerServices;
using Test2.Controllers;

namespace Test2.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string LastName { get; set; } = "";
    public string FullName => $"{Name.ToUpper()} {LastName.ToUpper()}";
    public string Password { get; set; } = "";

    public string Email { get; set; } = "";
    
    //Recordatorio Genero para enums
    public Genero Genero { get; set; }
}

public enum Genero
{
    Masculino,
    Femenino
}