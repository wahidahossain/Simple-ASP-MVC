using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace COMP229_NewStudent.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter E-mail")]
       // [RegularExpression(".+\\@.+\\..+"),
        //    ErrorMessage = "Enter valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Specify whether you attending")]
        public bool? WillAttend { get; set; }

    }
}
