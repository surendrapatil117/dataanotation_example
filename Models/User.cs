using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DataAnotation.Models
{
    public class User
    {   //Anotation
        [DisplayName("User Name")]
        [Required(ErrorMessage ="Name should be filled")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email should be filled")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address should be filled")]
        public string Address { get; set; }
    
    }
}