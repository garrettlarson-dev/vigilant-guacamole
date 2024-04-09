using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using INTEX_II.Models;
using Microsoft.AspNetCore.Authorization;

namespace INTEX_II.Controllers;

public class CustomerController : Controller
{
    // GET: Customer/Register
    // public IActionResult Register()
    // {
    //     return View();
    // }

    // POST: Customer/Register
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Register(Customer customer)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         // Add registration logic here
    //         // Save customer to database
    //
    //         return RedirectToAction(nameof(Login)); // Redirect to login page after registration
    //     }
    //     return View(customer);
    // }

    // GET: Customer/Login
    // public IActionResult Login()
    // {
    //     return View();
    // }

    // POST: Customer/Login
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Login(string email, string password)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         // Add login logic here
    //         // Check customer credentials
    //
    //         return RedirectToAction("Index", "Home"); // Redirect to home page after successful login
    //     }
    //     return View();
    // }

    // GET: Customer/Profile
    // public IActionResult Profile()
    // {
    //     // Retrieve customer profile data from database
    //
    //     return View(/* customer profile data */);
    // }

    // POST: Customer/Profile
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Profile(Customer customer)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         // Update customer profile logic here
    //
    //         return RedirectToAction(nameof(Profile)); // Redirect to profile page after updating
    //     }
    //     return View(customer);
    // }
    //
    // // GET: Customer/DeleteProfile
    // public IActionResult DeleteProfile()
    // {
    //     // Confirm delete action
    //     return View();
    // }
    //
    // // POST: Customer/DeleteProfile
    // [HttpPost, ActionName("DeleteProfile")]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> DeleteProfileConfirmed(int id)
    // {
    //     // Add delete logic here
    //     // Remove customer profile from database
    //
    //     return RedirectToAction("Index", "Home"); // Redirect to home page after deleting the profile
    // }
}