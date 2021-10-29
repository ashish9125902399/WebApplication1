using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class SubjectModel
    {
        [Required]
        public string SubjectCat { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}