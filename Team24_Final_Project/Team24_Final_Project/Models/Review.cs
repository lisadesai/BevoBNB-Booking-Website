using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

//Lisa Desai, last edited 11/17/21
namespace Team24_Final_Project.Models
{
    public enum DisputeStatusEnum { Open, Closed, Pending, Disputed }

    public class Review
    {
        public Int32 ReviewID { get; set; } 

        [Display(Name = "Customer comment:")]
        [RegularExpression("^.{0,280}$", ErrorMessage = "Customer comment must be no more than 280 characters")]
        public String CustomerComment { get; set; }

        [Display(Name = "Host response:")]
        public String HostResponse { get; set; }

        //public String UserEmail { get; set; }


        [Display(Name = "Dispute Status:")]
        public DisputeStatusEnum DisputeStatus { get; set; }

        [Display(Name = "Rating:")]
        [Required(ErrorMessage = "A rating from 1-5 is required!")]
        [Range(1, 5, ErrorMessage = "Rating must be an integer between 1 and 5")]
        public Int32 Rating { get; set; }


        //for admins to mark resolved or not
        [Display(Name = "Resolve dispute:")]
        public Boolean AcceptReject { get; set; }

        public Property Property { get; set; }

        public AppUser User { get; set; }


     


    }
}
