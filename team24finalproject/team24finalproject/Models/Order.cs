using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


//Lisa Desai, last edited 11/17/21
namespace Team24_Final_Project.Models
{
    public enum OrderStatus { Pending, Confirmed, Cancelled }

    public class Order
    {
        public Int32 OrderID { get; set; } //This is the confirmation number

        [Display(Name = "Order Number:")]
        public Int32 OrderNumber { get; set; }

        [Display(Name = "Order Status:")]
        public OrderStatus Status { get; set; }

        ////Calculated Properties -- should not be in database
        //[Display(Name = "Subtotal:")]               
        //[DisplayFormat(DataFormatString = "{0:C}")]
        //public Decimal Subtotal { get; set; }

        //[Display(Name = "Total:")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        //public Decimal Total { get; set; }

        //[Display(Name = "Discount Amount:")]
        //public Decimal DiscountAmount { get; set; }

        private const decimal TAX_RATE = .1m; //10% flat rate according to piazza!!


        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]


        public Decimal OrderSubtotal { get; set; }

        public void CalcSubtotal()
        {
            List<Reservation> PendingRes = Reservations
                .Where(r => r.Status == ReservationStatus.Pending || r.Status == ReservationStatus.Confirmed).ToList();

            OrderSubtotal = PendingRes.Sum(r => r.IndResTotal);
        }

        [Display(Name = "Sales Tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }



        //NAV PROPS.
        public List<Reservation> Reservations { get; set; }

        public AppUser User { get; set; }


        //Constructors to prevent null reference
        public Order()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
        }

    }
}
