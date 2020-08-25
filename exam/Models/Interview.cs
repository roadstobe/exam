using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exam.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Post { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
    }
}