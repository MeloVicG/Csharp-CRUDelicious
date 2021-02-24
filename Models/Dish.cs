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
        //----------------------------
        [Required(ErrorMessage="Please Provide DishName")]
        // [Display(Name = "Your Username:")] 
        public string DishName {get;set;}
        //------------------------------------------
        [Required(ErrorMessage="Please Provide Calories")]
        [Range(1,5000,ErrorMessage="Calories must be more than ZERO")]
        public int Calories {get;set;}
        //--------------------------------------------
        [Required(ErrorMessage="Please Provide Tasty")]
        public int Tasty {get;set;}
        //---------------------------------------------
        [Required(ErrorMessage="Please Provide Description")]
        public string Description {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public int ChefId {get;set;}
        public Chef DishChef {get;set;}
    }
}