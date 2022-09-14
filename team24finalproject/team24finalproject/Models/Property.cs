using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Team24_Final_Project.Models
{
    public enum PropertyStatusEnum { Active, Inactive, Pending }
    //public enum StateEnum { AL, AK, AZ, AR, CA, CO, CT, DE, DC, FL, GA, HI, ID, IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ, NM, NY, NC, ND, OH, OK, OR, PA, RI, SC, SD, TN, TX, UT, VT, VA, WA, WV, WI, WY }

    public enum AdminApprovalEnum { Pending, Approved, NotApproved}

    public class Property
    {
        public Int32 PropertyID { get; set; }

        [Display(Name = "Property Number:")]
        public Int32 PropertyNumber { get; set; }

        [Display(Name = "Limit by Start Date:")]
        [DataType(DataType.Date)]
        public DateTime CheckInDay { get; set; }

        [Display(Name = "Limit by End Date:")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDay { get; set; }


        [Required(ErrorMessage = "Zip code is required!")]
        [Display(Name = "Zip Code:")]           //always stored as string 
        public String Zip { get; set; }

        [Required(ErrorMessage = "City is required!")]
        [Display(Name = "City:")]
        public String City { get; set; }

        [Required(ErrorMessage = "State is required as two letters, e.g. TX!")]
        [RegularExpression(@"^((A[ELKSZR])|(C[AOT])|(D[EC])|(F[ML])|(G[AU])|(HI)|(I[DLNA])|(K[SY])|(LA)|(M[EHDAINSOT])|(N[EVHJMYCD])|(MP)|(O[HKR])|(P[WAR])|(RI)|(S[CD])|(T[NX])|(UT)|(V[TIA])|(W[AVIY]))$", ErrorMessage = "Invalid State, must be two capital letters, e.g. TX")]
        [Display(Name = "State:")]
        public String State { get; set; } 

        [Required(ErrorMessage = "Address is required!")]
        [Display(Name = "Address:")]
        public String PropertyAddress { get; set; }

        //[Display(Name = "Apartment Number:")]
        //public String ApartmentNumber { get; set; } 

        [Required(ErrorMessage = "Week day is required!")] //Sunday-Thursday
        [Display(Name = "Week day price:")]
        [Range(0, 10000000, ErrorMessage = "Cannot have negative weekday price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekdayPrice { get; set; }


        [Required(ErrorMessage = "A weekend price is required!")] //Friday and Saturday
        [Display(Name = "Weekend price:")]
        [Range(0, 10000000, ErrorMessage = "Cannot have negative weekend price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal WeekendPrice { get; set; }

        [Required(ErrorMessage = "A discount rate is required!")] 
        [Display(Name = "Discount rate:")]
        [Range(0, 100, ErrorMessage = "Cannot have negative discount rate")]
        public Decimal DiscountRate { get; set; }
        
        [Display(Name = "Days until discount is applied:")]
        [Range(0, 10000000, ErrorMessage = "Cannot have negative days until discount price")]
        public Int32 DaysToDiscount { get; set; }

        //[Display(Name = "Host email:")]
        //public String HostEmail { get; set; }

        [Required(ErrorMessage = "A cleaning fee is required!")]
        [Display(Name = "Cleaning fee:")]
        [Range(0, 10000000, ErrorMessage = "Cannot have negative cleaning fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee { get; set; }

        [Required(ErrorMessage = "Number of bedrooms is required!")]
        [Display(Name = "Number of bedrooms:")]
        [Range(0, 10000, ErrorMessage = "Cannot have negative bedrooms")]
        public Int32 NumberOfBedrooms { get; set; }

        //[Required(ErrorMessage = "Number of bedrooms is required!")]
        //[Display(Name = "Min Number of bedrooms:")]
        //[Range(0, 10000, ErrorMessage = "Cannot have negative bedrooms")]
        //public Int32 MinNumberOfBedrooms { get; set; }

        //[Required(ErrorMessage = "Number of bedrooms is required!")]
        //[Display(Name = "Max Number of bedrooms:")]
        //[Range(0, 10000, ErrorMessage = "Cannot have negative bedrooms")]
        //public Int32 MaxNumberOfBedrooms { get; set; }


        [Required(ErrorMessage = "Number of bathrooms is required!")]
        [Display(Name = "Number of bathrooms:")]
        [Range(0, 10000, ErrorMessage = "Cannot have negative bathrooms")]
        public Int32 NumberOfBathrooms { get; set; }

        public void CalcAvgRating()
        {
            List<Review> AcceptedReviews = Reviews.Where(r => r.AcceptReject == false
               && (r.DisputeStatus == DisputeStatusEnum.Closed ||
               r.DisputeStatus == DisputeStatusEnum.Open)).ToList();

            if (AcceptedReviews == null)
            {
                GuestRating = 0m;

            }

            else if (AcceptedReviews.Count() == 0)
            {
                GuestRating = 0m;
            }
            else
            {
                GuestRating = Math.Round(Convert.ToDecimal(AcceptedReviews.Average(r => r.Rating)), 1);
                
            }
        }

        [Display(Name = "Average guest rating:")]
        public Decimal GuestRating
        {
            get; set;
        
        }

        [Required(ErrorMessage = "Please specify if pets are allowed")]
        [Display(Name = "Pets allowed:")]
        public Boolean PetsAllowed { get; set; }


        [Required(ErrorMessage = "Please specify if there is free parking")]
        [Display(Name = "Free Parking:")]
        public Boolean FreeParking { get; set; }


        [Required(ErrorMessage = "Please specify a guest limit")]
        [Display(Name = "Guest limit:")]
        [Range(0, 10000, ErrorMessage = "Cannot have negative guest amount")]
        public Int32 GuestLimit { get; set; }

        [Display(Name = "Property Status:")]
        public PropertyStatusEnum PropertyStatus { get; set; }

        [Display(Name = "Property Status:")]
        public AdminApprovalEnum AdminReview { get; set; }

        [Display(Name = "Number of Reservations:")]
        public Int32 NumberOfReservations
        {
            get { return Reservations.Count(); }
        }

        // calculated values for host reports -- trying something out lol
        [Display(Name = "Property Earned Stay Revenue:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal EarnedRevenue
        {
            get { return (Reservations.Sum(rd => rd.TotalStayPrice) * .9m); }
        }

        [Display(Name = "Total Property Cleaning Fees:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCleaningFees
        {
            get { return Reservations.Sum(rd => rd.CleaningFee); }
        }

        [Display(Name = "Total Property Revenue:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalPropertyRevenue
        {
            get { return EarnedRevenue + TotalCleaningFees; }
        }
        

        //NAV PROPS.
        public Category Category { get; set; }

        public AppUser User { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<Review> Reviews { get; set; }


        //Constructors to prevent null reference
        public Property()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }
        }

    }
}
