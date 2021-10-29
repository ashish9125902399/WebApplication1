using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ChangePasswordModel
    {
        [DataType(DataType.Password)]
        [Display(Name ="Enter Old Password")]
        public string oldpass { get; set; }

        [Display(Name = "Enter Old Password")]
        [DataType(DataType.Password)]
        public string newpass { get; set; }
        public string id { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Enter Old Password")]
        public string repass { get; set; }
    }
}