using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using INTEX_II.Models;
using Microsoft.AspNetCore.Authorization;

namespace INTEX_II.Controllers;

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    public IActionResult ReviewOrders()
    {
        return View();
    }
    
    public IActionResult ManageProducts()
    {
        return View();
    }
    
    public IActionResult ManageUsers()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}