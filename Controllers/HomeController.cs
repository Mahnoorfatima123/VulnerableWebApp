//🔴 Risk: No anti-forgery token protection against CSRF.
//✅ Fix: Use [ValidateAntiForgeryToken].

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VulnerableWebApp.Models;

namespace VulnerableWebApp.Controllers;

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

   [HttpPost]
        public IActionResult Submit(string data)
        {
            return Ok("Form submitted successfully!");
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
