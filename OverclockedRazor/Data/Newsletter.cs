using System.ComponentModel.DataAnnotations;

namespace OverclockedRazor.Data
{
    public class Newsletter
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail Address")]
        public string Email { get; set; }
    }
}
