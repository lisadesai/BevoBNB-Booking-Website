using System;
using System.ComponentModel.DataAnnotations;

//Lisa Desai, last edited 11/17/21
namespace Team24_Final_Project.Models
{
    public enum ReservationStatus { Pending, Confirmed, Cancelled }

    public class Reservation
    {
        public Int32 ReservationID { get; set; }

        [Required(ErrorMessage = "A check-in date is required!")]
        [Display(Name = "Check-in date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "A check-out date is required!")]
        [Display(Name = "Check-out date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CheckOutDate { get; set; }

        [Required(ErrorMessage = "A cancel by date is required!")]
        [Display(Name = "Cancel by:")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime CancelByDate
        {
            get { return CheckInDate.AddDays(-1); }
        }

        [Range(1, 100, ErrorMessage = "Value for {0} must be at least {1}")]
        [Required(ErrorMessage = "Number of guests is required!")]
        [Display(Name = "Number of guests:")]
        public Int32 NumberOfGuests { get; set; }

        [Display(Name = "Weekday Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekdayPrice { get; set; }

        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekendPrice { get; set; }

        [Display(Name = "Cleaning Fee:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "DiscountRate:")]
        public Decimal DiscountRate { get; set; }

        [Display(Name = "Total Stay Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalStayPrice { get; set; }

        [Display(Name = "Reservation Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ResSubtotal
        {
            get { return TotalStayPrice + CleaningFee; }
        }

        [Display(Name = "Discount Amount:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal DiscountAmt
        {
            get { return TotalStayPrice * (DiscountRate/100); }
        }

        [Display(Name = "Individual Reservation Total:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal IndResTotal
        {
            get { return ResSubtotal - DiscountAmt; }
        }

        [Display(Name = "Status:")]
        public ReservationStatus Status { get; set; }

        public Property Property { get; set; }

        public Order Order { get; set; }
        public int PropertyID { get; internal set; }
    }
}
