using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PracticeModel
    {
        public string Subject { get; set; }
        public int QID { get; set; }
        public string Question { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string SelectedAns { get; set; }
        public string RightAns { get; set; }
    }
}