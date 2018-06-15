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
            [Display(Name = "Self-Identify")]
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
        [Display(Name = "Height")]
        public string Height { get; set; }
        [Required]
        [Display(Name = "Weight (in lbs.)")]
        public string Weight { get; set; }

        [Display(Name = "Chest")]
        public int Chest { get; set; }
        [Display(Name = "Waist")]
        public int Waist { get; set; }
        [Display(Name = "Hip")]
        public int Hip { get; set; }
        [Display(Name = "Neck")]
        public int Neck { get; set; }
        [Display(Name = "Forearm")]
        public int Forearm { get; set; }
        [Display(Name = "Tricep")]
        public int Tricep { get; set; }
        [Display(Name = "Bicep")]
        public int Bicep { get; set; }
        [Display(Name = "Thigh")]
        public int Thigh { get; set; }
        [Display(Name = "Calf")]
        public int Calf { get; set; }
    }
}
