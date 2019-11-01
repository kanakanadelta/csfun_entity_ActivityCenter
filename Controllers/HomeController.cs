using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        // // // // // // // // //
        // DEPENDENCY INJECTION //
        public ACContext dbContext;

        public HomeController(ACContext context)
        {
            dbContext = context;
        }
        // Dependency Injection End //
        // // // // // // // // // //

        // ~~~~~~~~~~~~~~~~~ //
        // *** CONTROLS *** //
        // ~~~~~~~~~~~~~~~ //

        // // // // // // // // // //
        // Login and Reg Section //
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                // Invalid Email //
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {

                    ModelState.AddModelError("Email", "This Email is already in use!");
                    // return the view
                    return View("Index");
                }

                // invalid Password //
                if(user.Password != user.Confirm)
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Password", "Password confirmation was not the same password.");
                    // return the view
                    return View("Index");
                }

                // // // // // // // // // //
                // hash the given password:

                // Initialize the hasher object
                var hasher = new PasswordHasher<User>();

                user.Password = hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();

                HttpContext.Session.SetString("UserName", user.FirstName);
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return RedirectToAction("Home");
            }
            else
            return View("Index");
        }

        [HttpPost("loginconfirm")]
        public IActionResult LoginConfirm(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Login");
                }
                else
                {
                    HttpContext.Session.SetString("UserName", userInDb.FirstName);
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return RedirectToAction("Home");
                }
                
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // // // // // /
        // HOME PAGE //
        [HttpGet("Home")]
        public IActionResult Home()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        // // // // // // //
        // ERROR HANDLING //

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
