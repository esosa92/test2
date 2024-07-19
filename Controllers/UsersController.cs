using Microsoft.AspNetCore.Mvc;
using Test2.Models;

namespace Test2.Controllers;

public class UsersController : Controller
{
    private static List<User> _userCollection = new List<User>();
    private static int _autoincrement = 0;

    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Index() // <- este metodo se esta de alguna forma llamando
    {
        return View(_userCollection);
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
    public IActionResult Add(User user)
    {
        user.Id = _autoincrement + 1;//Generalo como quieras, pero esto es bastante valido
        _userCollection.Add(user); //<-Me tiene que agregar un indice

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        User? user = null;
        //Busco el usuario
        foreach (var u in _userCollection)
        {
            if (u.Id == id)
            {
                user = u;
            }
        }

        if (user == null)
        {
           //
        }
        
        //Y lo mando para el form
        return View(user);
    }

    [HttpPost]
    public IActionResult Edit(User user)
    {
        //Recibo usuario del form
        //Lo busco en la colecction
        //Y lo edito en la coleccion con esos datos que me viene
        return RedirectToAction("Index");
    }

    //Recibir por parametro id
    public IActionResult Delete()
    {
        //Buscar con ese id y remover
        //Donde este ese id ese indice lo remuevo 
        _userCollection.RemoveAt(1);
        //Fijate si te sale el delete antes que el edit
        return View();
    }
}