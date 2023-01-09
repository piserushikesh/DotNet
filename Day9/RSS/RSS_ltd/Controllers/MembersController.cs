using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RSS_ltd.Models;

namespace RSS_ltd.Controllers;

public class MembersController : Controller
{
    private readonly ILogger<MembersController> _logger;

    public MembersController(ILogger<MembersController> logger)
    {
        _logger = logger;
    }

     public IActionResult AboutUs()
    {
        return View();
    }

      public IActionResult Members()
    {
        List<RSS_members>  allMembers=MemberManager.GetAllMembers();
        ViewData["member"]=allMembers;
        return View();
    }

}