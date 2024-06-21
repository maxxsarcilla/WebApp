using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonWebApp.Models;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        Person person = new Person 
        {
            FirstName = "Macky",
            MiddleName = "Candelaria",
            LastName = "Sarcilla",
            Age = 24
        };
        return View(person);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
