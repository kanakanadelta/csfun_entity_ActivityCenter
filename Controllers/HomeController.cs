using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;

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

        // // // // // /
        // HOME PAGE //
        [HttpGet("Home")]
        public IActionResult Home()
        {
            // CHECK FOR SESSION //
            string name = HttpContext.Session.GetString("UserName");
            if(name == null)
            {
                return RedirectToAction("Index");
            }
            // VIEW SESSIONS //
            ViewBag.UserName = name;
            int? userId = HttpContext.Session.GetInt32("UserId");
            ViewBag.UserId = userId;
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            // QUERIES //

            List<Event> userEvents = dbContext
                .Associations
                .Where(ass => ass.UserId == userId)
                .Select(ass => ass.Event)
                .ToList();
            ViewBag.UserEvents = userEvents;

            List<Event> events = dbContext
                .Events
                .Where(e => e.EventDateTime > DateTime.Now)
                .OrderBy(e => e.EventDateTime)
                .Include(e => e.Associations)
                .Include(e => e.Planner)
                .ToList();
            ViewBag.Events = events;

            return View();
        }

        // // // // //
        // EVENTS // 

        [HttpGet("New")]
        public IActionResult NewEvent()
        {

            int? userId = HttpContext.Session.GetInt32("UserId");
            string userName = HttpContext.Session.GetString("UserName");
            ViewBag.UserId = userId;
            ViewBag.UserName = userName;
            
            if(userName == null)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost("CreateEvent")]
        public IActionResult CreateEvent(Event e, string durationType)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            User planner = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            e.Planner = planner;

            if(ModelState.IsValid)
            {
                e.EventDateTime = e.EventDate.Date.Add(e.EventTime.TimeOfDay);
                e.Duration = e.Duration + " " + durationType;
                dbContext.Add(e);
                dbContext.SaveChanges();
                return RedirectToAction("Home");
            }
            else
            {
                string userName = HttpContext.Session.GetString("UserName");
                ViewBag.UserId = userId;
                ViewBag.UserName = userName;
                System.Console.WriteLine("NOT VALID");
                return View("NewEvent");
            }
        }

        [HttpGet("events/{eventId}")]
        public IActionResult ShowEvent(int eventId)
        {

            // CHECK FOR SESSION //
            string name = HttpContext.Session.GetString("UserName");
            if(name == null)
            {
                return RedirectToAction("Index");
            }
            // VIEW SESSIONS //
            ViewBag.UserName = name;
            int? userId = HttpContext.Session.GetInt32("UserId");
            ViewBag.UserId = userId;
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            // QUERIES //
            List<Event> userEvents = dbContext
                .Associations
                .Where(ass => ass.UserId == userId)
                .Select(ass => ass.Event)
                .ToList();
            ViewBag.UserEvents = userEvents;

            // EVENT INFO
            Event viewEvent = dbContext
                .Events
                .Include(e => e.Planner)
                .FirstOrDefault(e => e.EventId == eventId);

            // LIST OF PARTICIPANTS
            List<User> participants = dbContext
                .Associations
                .Where(ass => ass.EventId == eventId)
                .Select(ass => ass.User)
                .ToList();
            ViewBag.Participants = participants;
            
            return View(viewEvent);
        }

        
        [HttpPost("events/{eventId}/join")]
        public IActionResult Join(int eventId)
        {
            
            int? userId = HttpContext.Session.GetInt32("UserId");

            if(userId == null)
            {
                return RedirectToAction("Index");
            }

            User user = dbContext
                .Users
                .FirstOrDefault(u => u.UserId == userId);

            Event selectedEvent = dbContext
                .Events
                .FirstOrDefault(e => e.EventId == eventId);
            
            Association rsvp = new Association(user.UserId, user, eventId, selectedEvent);
            dbContext.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("ShowEvent", new {eventId = eventId});
        }

        
        [HttpPost("events/{eventId}/drop")]
        public IActionResult Drop(int eventId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            User user = dbContext
                .Users
                .FirstOrDefault(u => u.UserId == userId);

            Association rsvp = dbContext
                .Associations
                .FirstOrDefault(ass => (ass.EventId == eventId && ass.UserId == user.UserId));

            dbContext.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("ShowEvent", new {eventId = eventId});
        }

        // // // // // // // //
        // EVENT MANAGEMENT //

        [HttpPost("events/{eventId}/rsvp")]
        public IActionResult RSVP(int eventId)
        {
            
            int? userId = HttpContext.Session.GetInt32("UserId");

            User user = dbContext
                .Users
                .FirstOrDefault(u => u.UserId == userId);

            Event selectedEvent = dbContext
                .Events
                .FirstOrDefault(e => e.EventId == eventId);
            
            Association rsvp = new Association(user.UserId, user, eventId, selectedEvent);
            dbContext.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        
        [HttpPost("events/{eventId}/unRsvp")]
        public IActionResult UnRSVP(int eventId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            User user = dbContext
                .Users
                .FirstOrDefault(u => u.UserId == userId);

            Association rsvp = dbContext
                .Associations
                .FirstOrDefault(ass => (ass.EventId == eventId && ass.UserId == user.UserId));

            dbContext.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpPost("events/{eventId}/delete")]
        public IActionResult DeleteEvent(int eventId)
        {
            Event selectedEvent = dbContext
                .Events
                .FirstOrDefault(e => e.EventId == eventId);

            dbContext.Remove(selectedEvent);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }

        // // // // // // // // // ///
        // // // // // // // // // //
        // Login and Reg Section //
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(ViewModel userSubmission)
        {
            if(ModelState.IsValid)
            {
                // Invalid Email //
                if(dbContext.Users.Any(u => u.Email == userSubmission.User.Email))
                {

                    ModelState.AddModelError("Email", "This Email is already in use!");
                    // return the view
                    return View("Index");
                }

                // invalid Password //
                if(userSubmission.User.Password != userSubmission.User.Confirm)
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

                userSubmission.User.Password = hasher.HashPassword(userSubmission.User, userSubmission.User.Password);
                dbContext.Add(userSubmission.User);
                dbContext.SaveChanges();

                HttpContext.Session.SetString("UserName", userSubmission.User.FirstName);
                HttpContext.Session.SetInt32("UserId", userSubmission.User.UserId);
                return RedirectToAction("Home");
            }
            else
            return View("Index");
        }

        [HttpPost("loginconfirm")]
        public IActionResult LoginConfirm(ViewModel userSubmission)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LoginUser.Email);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission.LoginUser, userInDb.Password, userSubmission.LoginUser.Password);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Index");
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

        // ~~~~~~~~~~~~~~~~ //

        // // // // // // //
        // ERROR HANDLING //

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
