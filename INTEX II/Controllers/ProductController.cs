using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using INTEX_II.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace INTEX_II.Controllers;

public class ProductController : Controller
{
    
    public ProductController()
    {
    }

    public IActionResult Products()
    {
        return View();
    }

    public IActionResult ProductDetail()
    {
        return View();
    }
    
}