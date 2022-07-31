using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRAFTY1.Models
{
    public class UserLogin
    {
        [DisplayName("User Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Give your Email Address")]
        public string mail { get; set; }
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Give your Password")]
        public string password { get; set; }
    }
}