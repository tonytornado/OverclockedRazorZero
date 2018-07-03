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
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
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
        [StringLength(3)]
        [Display(Name = "Height")]
        public string Height { get; set; }
        [Required]
        [StringLength(3)]
        [Display(Name = "Weight")]
        public string Weight { get; set; }

        [StringLength(2)]
        [Display(Name = "Chest")]
        public int Chest { get; set; }
        [StringLength(2)]
        [Display(Name = "Waist")]
        public int Waist { get; set; }
        [StringLength(2)]
        [Display(Name = "Hip")]
        public int Hip { get; set; }
        [StringLength(2)]
        [Display(Name = "Neck")]
        public int Neck { get; set; }
        [StringLength(2)]
        [Display(Name = "Forearm")]
        public int Forearm { get; set; }
        [StringLength(2)]
        [Display(Name = "Tricep")]
        public int Tricep { get; set; }
        [StringLength(2)]
        [Display(Name = "Bicep")]
        public int Bicep { get; set; }
        [StringLength(2)]
        [Display(Name = "Thigh")]
        public int Thigh { get; set; }
        [StringLength(2)]
        [Display(Name = "Calf")]
        public int Calf { get; set; }
    }
}
