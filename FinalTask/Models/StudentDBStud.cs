using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalTask.Models
{
    public class StudentDBStud: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}