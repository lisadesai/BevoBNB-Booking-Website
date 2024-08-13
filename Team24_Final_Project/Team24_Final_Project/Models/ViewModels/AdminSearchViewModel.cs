using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team24_Final_Project.Models
{
    public class AdminSearchViewModel
    {
        [Display(Name = "Search by property:")]
        public int[] SearchPropertyID {get; set;}

        [Display(Name = "Search by category:")]
        public int[] SearchCategoryID { get; set; }

        [Display(Name = "Limit by Start Date:")]
        [DataType(DataType.Date)]
        public DateTime SearchCheckInDay { get; set; }

        [Display(Name = "Limit by End Date:")]
        [DataType(DataType.Date)]
        public DateTime SearchCheckOutDay { get; set; }

        [Display(Name = "Number of Properties:")]
        public Int32 NumberOfProperties { get; set; }

        [Display(Name = "Number of Reservations")]
        public Int32 NumberOfReservations { get; set; }

        [Display(Name = "Total Commission:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCommissions { get; set; }

        [Display(Name = "Average Commission")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal AverageCommission { get; set; }
    }
}
