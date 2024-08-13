using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team24_Final_Project.Models
{
    public class HostSearchViewModel
    {
        [Display(Name = "Search by property:")]
        public int[] SearchPropertyID { get; set; }

        [Display(Name = "Search by category:")]
        public int[] SearchCategoryID { get; set; }

        [Display(Name = "Limit by Start Date:")]
        [DataType(DataType.Date)]
        public DateTime SearchCheckInDay { get; set; }

        [Display(Name = "Limit by End Date:")]
        [DataType(DataType.Date)]
        public DateTime SearchCheckOutDay { get; set; }

        [Display(Name = "Total Property Revenue:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal PropertyTotalRev { get; set; }

        [Display(Name = "Total Cleaning Fees:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCleaningFees { get; set; }

        [Display(Name = "Total Completed Reservations:")]
        public Int32 TotalReservations { get; set; }
    }
}
