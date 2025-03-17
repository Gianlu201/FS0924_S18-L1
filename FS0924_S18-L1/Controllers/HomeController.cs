using System.Diagnostics;
using FS0924_S18_L1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FS0924_S18_L1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
