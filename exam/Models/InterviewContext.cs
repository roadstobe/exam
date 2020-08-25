using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exam.Models
{
    public class InterviewContext : DbContext
    {
        public DbSet<Interview> Interviews { get; set; }
    }
}