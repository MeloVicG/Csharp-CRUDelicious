using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crudelicious.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        public string ChefName {get;set;}

    //------------------------------
        [NotMapped]
        public int Age {get{
            return DateTime.Now.Year - DateOfBirth.Year;
        }} //no set because its not being takin from form
    //------------------------------------------
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name="DateOfBirth")]
        public DateTime DateOfBirth{get;set;}
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Dish> Dishes {get;set;}
    }
}