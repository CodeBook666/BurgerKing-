using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Class3
    {

        [Required]

        

        public string TeleNo { get; set; }
        [Required, RegularExpression(@"^.*", ErrorMessage = "Please enter a valid data to the field!")]

        public string customerName { get; set; }
        [Required, EmailAddress, RegularExpression(@"^*[a-zA-Z]", ErrorMessage = "Please enter a valid data to the field!")]

        public string Email { get; set; }


        public string Address { get; set; }
    }
}
                                                                                                                                                                                                                          