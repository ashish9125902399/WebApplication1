using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class RegisterModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string Rpassword { get; set; }
        public bool Checkbx { get; set; }

    }
}