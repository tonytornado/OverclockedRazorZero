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
        public string height { get; set; }
        [Required]
        public string weight { get; set; }

        public int chest { get; set; }
        public int waist { get; set; }
        public int hip { get; set; }
        public int neck { get; set; }
        public int forearm { get; set; }
        public int tricep { get; set; }
        public int bicep { get; set; }
        public int thigh { get; set; }
        public int calf { get; set; }


    }
}
