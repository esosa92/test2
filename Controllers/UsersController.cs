using Microsoft.AspNetCore.Mvc;
using Test2.Models;

namespace Test2.Controllers;

//son 3 controlers
//3 modelos -> 2 o 3 propiedades 
//3 vistas
// en cada vista devolves 1(osea no colection) modelo y mostramos los datos.

public class UsersController : Controller
{
    private static List<User> _userCollection = new List<User>();
    //public static List<User> Users => _userCollection;// get {return _userCollection}
    public static List<User> Users
    {
        get { return _userCollection; }
    }

    public IActionResult Login()
    {
        //var uc = new UsersController();
        //uc.Cantidad = 5;
        //Console.WriteLine(uc.Cantidad);
        //UsersController.Users.Add(new User(){});
        return View();
    }

    // /users/index || /users/
    public IActionResult Index() // <- este metodo se esta de alguna forma llamando
    {
        var vb = new UserViewBag
        {
            UserCollection = _userCollection
        };
        
        Console.WriteLine(_userCollection.Count);

        return View(vb);
    }

    //Get
    // /users/add 
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    //Procesar 
    [HttpPost]
    public IActionResult AddProcess(User user)
    {
        _userCollection.Add(user);
        return RedirectToAction("Index");
    }

    public IActionResult Delete()
    {
        return View();
    }
}