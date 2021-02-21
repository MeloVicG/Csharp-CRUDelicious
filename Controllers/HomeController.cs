using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    //------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {

            ViewBag.Dishes = _context.Dishes;
            // .ToList();

            
            return View();
        }
    //------------------------------------------------------------
        [HttpGet("news")]
        public IActionResult News()
        {
            return View();
        }
        //method to show form
    //------------------------------------------------------------
        //another method to process form
        [HttpPost("create")]
        public IActionResult News(Dish dishToCook) //string ChefName, string DishName == only need to take in Dish
        {
            //add to DB
            if(ModelState.IsValid)
            {
                _context.Add(dishToCook);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
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

            DishToUpdate.ChefName = updateDish.ChefName;
            DishToUpdate.DishName = updateDish.DishName;
            DishToUpdate.Calories = updateDish.Calories;
            DishToUpdate.Tasty = updateDish.Tasty;
            DishToUpdate.Description = updateDish.Description;

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



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
