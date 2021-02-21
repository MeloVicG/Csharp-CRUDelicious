using System;
using System.ComponentModel.DataAnnotations; //allows us to use [Key]


//name of project
namespace Crudelicious.Models
{
    public class Dish
    {
        //unique identifier for the next particular object
        [Key]
        public int DishId {get;set;}
        public string ChefName {get;set;}
        public string DishName {get;set;}
        public int Calories {get;set;}
        public int Tasty {get;set;}
        public string Description {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}