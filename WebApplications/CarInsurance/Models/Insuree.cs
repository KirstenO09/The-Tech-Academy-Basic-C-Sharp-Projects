using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }
        
        [Display(Name = "First Name")]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public required string LastName { get; set; }

        [Display(Name = "Email Address")]
        public required string EmailAddress { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Car year")]
        public int CarYear { get; set; }
        
        [Display(Name = "Car Make")]
        public required string CarMake { get; set; }
        
        [Display(Name = "Car Model")]
        public required string CarModel { get; set; }
        
        public bool DUI { get; set; }
       
        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }
        
        [Display(Name = "Coverage Type")]  
        public required string CoverageType { get; set; }
        public decimal Quote { get; set; }
    }
}
