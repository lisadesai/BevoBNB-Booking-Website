using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


//Lisa Desai, last edited 11/17/21
namespace Team24_Final_Project.Models
{
    public class AppUser : IdentityUser
    {
        //<-- use the built-in Identiy field for the unique identifier for the user

        [Required(ErrorMessage = "First name is required!")]
        [Display(Name = "First Name:")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [Display(Name = "Last Name:")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial:")]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        [Display(Name = "Address:")]
        public String Address { get; set; }

        //not storing CITY or STATE because seeding data doesn't have that


        [Required(ErrorMessage = "Zip code is required!")]
        [Display(Name = "Zip Code:")]           //always stored as string 
        public String Zip { get; set; }

        //not storing PHONE or EMAIL bc AppUser inherits this


        [Required(ErrorMessage = "Birthday is required!")]
        [Display(Name = "Birthday:")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


        [Required(ErrorMessage = "Adult is required!")]
        [Display(Name = "Adult:")]  
        public Boolean Adult 
        {
            get { return (DateTime.Today.AddYears(-18) >= Birthday); }
            set { }
        }

        [Required(ErrorMessage = "Status is required!")]
        [Display(Name = "Status:")]
        public Boolean IsActive { get; set; } //TODO: SET to TRUE


        //[Display(Name = "SSN:")] // delete  -- never store
        //public String SocialSecurity { get; set; }  //TODO: on View, it is REQUIRED for Admin and Host



        //NAV PROPS.
        public List<Order> Orders { get; set; }  

        public List<Property> Properties { get; set; }

        public List<Review> Reviews { get; set; }

        //Constructors to prevent null reference
        public AppUser()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }

            if (Properties == null)
            {
                Properties = new List<Property>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
        }


    }
}
