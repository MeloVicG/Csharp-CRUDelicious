using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using Crudelicious.Models;

namespace Crudelicious.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly MyContext _context;

        public HomeController(MyContext context)
        // public HomeController(ILogger<HomeController> logger)
        {
            // _logger = logger;
            _context = context;
        }

        //cannot get Age to show on Index Page
        //cannot get Dish validations to work
    //------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {

            ViewBag.Chefs = _context.Chefs
            .Include(d => d.Dishes);
            // .ToList();

            
            return View();
        }
    //------------------------------------------------------------
    //new chef page
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.Dishes = _context.Dishes
            .Include(d => d.DishChef);
            return View();
        }
    //------------------------------------------------------------
        [HttpGet("new-dish")]
        public IActionResult NewDish()
        {
            ViewBag.Chefs = _context.Chefs;

        //no use for this in create
            // ViewBag.Dishes = _context.Dishes
            // .Include(d => d.DishChef);
            return View();
        }
    //------------------------------------------------------------
    //add a Chef page
        [HttpGet("new-chef")]
        public IActionResult NewChef()
        {
            ViewBag.Dishes = _context.Dishes;
            return View();
        }
    //---------------------------------------------------------
        [HttpPost("new-chef-process")]
        public IActionResult NewChefProcess(Chef NewChef)
        {


            int age = DateTime.Now.Year - NewChef.DateOfBirth.Year;

            if(NewChef.DateOfBirth > DateTime.Today)
            {
                ModelState.AddModelError("DateOfBirth", "Not a future Date");
                return View("NewChef");
            }
            if(age < 18)
            {
                ModelState.AddModelError("DateOfBirth", "Junior Chef are not allowed");
                return View("NewChef");
            }

            if(ModelState.IsValid)
            {
                _context.Add(NewChef);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    //------------------------------------------------------------
        //Create Dish Process
        [HttpPost("new-dish-process")]
        public IActionResult News(Dish dishToCook) //string ChefName, string DishName == only need to take in Dish
        {
                // ViewBag.Dishes = _context.Dishes
                // .Include(d => d.DishChef);

            //add to DB
            if(ModelState.IsValid)
            {
                _context.Add(dishToCook);
                _context.SaveChanges();
            return RedirectToAction("Dishes");
            }
            else
            {
                return View("NewDish");
            }
            
            
            
        }
    //------------------------------------------------------------
    //------------------------------------------------------------
        [HttpGet("detail/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.Details = _context.Dishes
            .FirstOrDefault(deesh => deesh.DishId==id);
            //need  to retrieve specific id

            return View();
        }
    //------------------------------------------------------------
        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish dishToEdit = _context.Dishes
            .FirstOrDefault(deesh => deesh.DishId == id);
            
            return View(dishToEdit);
        }
    //------------------------------------------------------------
        [HttpPost("update")]
        public IActionResult Update(Dish updateDish) //coming from form
        {
            Console.WriteLine("this is id ===========>", updateDish.DishId);
            var DishToUpdate = _context
                .Dishes
                .FirstOrDefault(deesh => deesh.DishId == updateDish.DishId);

            // DishToUpdate.ChefName = updateDish.ChefName;
            // DishToUpdate.DishName = updateDish.DishName;
            // DishToUpdate.Calories = updateDish.Calories;
            // DishToUpdate.Tasty = updateDish.Tasty;
            // DishToUpdate.Description = updateDish.Description;

            _context.SaveChanges();

            return RedirectToAction("Details", new { id = updateDish.DishId });
            // return Redirect ($"/Details/{updateDish.DishId}");
        }
    //------------------------------------------------------------
        [HttpGet("delete/{dishId}")]
        public IActionResult DeleteDish(int dishId)
        {

                var DishesToDelete = _context.Dishes.First(deesh => deesh.DishId == dishId);
                _context.Dishes.Remove(DishesToDelete);
                _context.SaveChanges();

            return RedirectToAction("Index");
        }
    //------------------------------------------------------------
    //------------------------------------------------------------



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
