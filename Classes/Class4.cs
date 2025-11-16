using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    public class Class4
    {
        [Required]

       
        public string TeleNo { get; set; }
        [Required, RegularExpression(@"^.*", ErrorMessage = "Please enter a valid data to the field!")]

        public string customerName { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid data to the field!")]

        public string Branch { get; set; }

    }
}
