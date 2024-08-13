using System;
using System.ComponentModel.DataAnnotations;

namespace Team24_Final_Project.Models.ViewModels
{
    public enum SearchType { GreaterThan, LessThan }

    public class PropertySearchViewModel
    {
        //no required annotations because search must be as flexible as possible

        [Display(Name = "Check-in Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCheckInDate { get; set; } 

        [Display(Name = "Check-out Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCheckOutDate { get; set; }

        [Display(Name = "Selected Category:")]
        public Int32 SelectedCategory { get; set; }

        [Display(Name = "City:")]
        public String SelectedCity { get; set; }


        [Display(Name = "Address:")]
        public String SelectedAddress { get; set; }

        [Display(Name = "State:")]
        public String SelectedState { get; set; }

        [Display(Name = "Average guest rating:")]
        public Decimal SelectedGuestRating { get; set; }

        [Display(Name = "Week day price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SelectedWeekdayPrice { get; set; }

        [Display(Name = "Weekend price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SelectedWeekendPrice { get; set; }

        //
        [Display(Name = "Number of bedrooms:")]
        public Int32 SelectedBedrooms { get; set; }

        //[Display(Name = "Number of bedrooms:")]
        //public Int32 MinSelectedBedrooms { get; set; }

        //[Display(Name = "Number of bedrooms:")]
        //public Int32 MaxSelectedBedrooms { get; set; }

        [Display(Name = "Number of bathrooms:")]
        public Int32 SelectedBathrooms { get; set; }

        [Display(Name = "Number of guests:")]
        public Int32 SelectedGuests { get; set; }

        //
        [Display(Name = "Type of Search: ")]
        public SearchType? WeekdaySelectedType { get; set; }

        [Display(Name = "Type of Search: ")]
        public SearchType? WeekendSelectedType { get; set; }


        //
        [Display(Name = "Type of Search: ")]
        public SearchType? GuestRatingSelectedType { get; set; }

        [Display(Name = "Type of Search: ")]
        public SearchType? BedroomsSelectedType { get; set; }


        //[Display(Name = "Type of Search: ")]
        //public SearchType? BedroomsMinSelectedType { get; set; }

        //[Display(Name = "Type of Search: ")]
        //public SearchType? BedroomsMaxSelectedType { get; set; }

        [Display(Name = "Type of Search: ")]
        public SearchType? BathroomsSelectedType { get; set; }

        [Display(Name = "Type of Search: ")]
        public SearchType? GuestsNumberSelectedType { get; set; }



        [Display(Name = "Pets allowed:")] 
        public Boolean SelectedPetsAllowed { get; set; }

        [Display(Name = "Free Parking")]   
        public Boolean SelectedFreeParking { get; set; }

        
    }
}
