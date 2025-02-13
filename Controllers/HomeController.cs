using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Views.Home;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult GetToKnow()
    {
        return View();
    }

    [HttpGet]
    public IActionResult EnterMovies()
    {
        return View();
    }
    [HttpPost]
    public IActionResult EnterMovies(Application response)
    {
        return View("Confirmation");
    }
}