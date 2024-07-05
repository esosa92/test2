namespace Test2.Models;

public class UserViewBag
{
    public List<User> UserCollection { get; set; }
    public string Title => "Usuarios".ToUpper();
}