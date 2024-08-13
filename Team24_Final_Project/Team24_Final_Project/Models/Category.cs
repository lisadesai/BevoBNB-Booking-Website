using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team24_Final_Project.Models
{
    public class Category
    {
        public Int32 CategoryID { get; set; }   //this will be drop down list bc it's dtna


        [Required(ErrorMessage = "Category name is required!")]
        [Display(Name = "Category Name:")]
        public String CategoryName { get; set; }

        //NAV PROPS.
        public List<Property> Properties { get; set; }


        //Constructor to prevent null reference
        public Category()
        {
            if (Properties == null)
            {
                Properties = new List<Property>();
            }
        }
    }
}
