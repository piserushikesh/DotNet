﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;

namespace tflstore.Controllers;

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

    public IActionResult login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Validate(string email,string password)
    {
        if(email =="rpise4938@gmail.com" && password=="rushi")
        {
             Console.WriteLine("successfull validation of user..... ");
             Console.WriteLine("Redirecting to welcome..... ");   
            return Redirect("/home/Welcome");
        }
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
