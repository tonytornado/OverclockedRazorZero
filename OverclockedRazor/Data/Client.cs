using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OverclockedRazor.Data
{
    public class Client
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string BSex { get; set; }
        [Required]
        public string Height { get; set; }
        [Required]
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
