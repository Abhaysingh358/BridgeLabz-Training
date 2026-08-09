using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreetingApp.Models;

namespace GreetingApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("GreetingMessage");
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


    // This will dispaly the page with Button
    public IActionResult GreetingMessage()
    {
        return View();
    }

    //when somebody click the button the new greeting page opens
    [HttpPost]
    public IActionResult Showgreeting()
    {
        var greeting = new Greeting
        {
            Message = "Hello!\nRemeber whether we win or we learn "
        };

        return View(greeting);
    }
}
