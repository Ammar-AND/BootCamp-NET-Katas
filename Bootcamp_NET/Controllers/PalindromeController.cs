using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_NET.Controllers
{
    public class PalindromeController : Controller
    {
        public IActionResult Index()
        {
            return View("Palindrome");
        }
    }
}