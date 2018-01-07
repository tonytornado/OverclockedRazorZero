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
        public DateTime DOB { get; set; }
        [Required]
        [Display(Name = "Biological Sex")]
        public Sex BSex { get; set; }
        [Required]
        [Display(Name = "Height")]
        public string Height { get; set; }
        [Required]
        [Display(Name = "Weight (in lbs.)")]
        public string Weight { get; set; }

        public int Chest { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }
        public int Neck { get; set; }
        public int Forearm { get; set; }
        public int Tricep { get; set; }
        public int Bicep { get; set; }
        public int Thigh { get; set; }
        public int Calf { get; set; }
    }
}
