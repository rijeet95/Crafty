using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRAFTY1.Models
{
    public class UserRegistration
    {
        public int C_ID { get; set; }
        [DisplayName("Customer Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Give your Name")]
        public string customer_name { get; set; }
        
        [DisplayName("Customer Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Give your Address")]
        public string customer_address { get; set; }
      
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Give your Password")]

        public string password { get; set; }
        [DisplayName("Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Give your Email")]
        public string customer_mail { get; set; }
    }
}