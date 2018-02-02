using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OverclockedRazor.Data
{
    public class Client
    {
        public enum Sex
        {
            [Display(Name = "Male")]
            Male,
            [Display(Name = "Female")]
            Female,
            [Display(Name = "Other")]
            Other
        }

        public int ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        [Display(Name = "Biological Sex Assignment")]
        public Sex BSex { get; set; }
        [Required]
        [Display(Name = "Height (in in.)")]
        public string Height { get; set; }
        [Required]
        [Display(Name = "Weight (in lbs.)")]
        public string Weight { get; set; }

        [Display(Name = "Chest (in in.)")]
        public int Chest { get; set; }
        [Display(Name = "Waist (in in.)")]
        public int Waist { get; set; }
        [Display(Name = "Hip (in in.)")]
        public int Hip { get; set; }
        [Display(Name = "Neck (in in.)")]
        public int Neck { get; set; }
        [Display(Name = "Forearm (in in.)")]
        public int Forearm { get; set; }
        [Display(Name = "Tricep (in in.)")]
        public int Tricep { get; set; }
        [Display(Name = "Bicep (in in.)")]
        public int Bicep { get; set; }
        [Display(Name = "Thigh (in in.)")]
        public int Thigh { get; set; }
        [Display(Name = "Calf (in in.)")]
        public int Calf { get; set; }
    }
}
