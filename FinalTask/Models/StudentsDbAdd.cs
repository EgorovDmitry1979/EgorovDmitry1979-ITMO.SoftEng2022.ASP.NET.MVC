using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class StudentsDbAdd: DropCreateDatabaseIfModelChanges<StudentDBStud>
    {
        protected override void Seed(StudentDBStud context)
        {
            context.Students.Add(new Student {LastName = "Смирнов", FirstName = "Максим", Surname = "Валентинович", MiddleBall = 75});
            base.Seed(context);
        }
    }
}