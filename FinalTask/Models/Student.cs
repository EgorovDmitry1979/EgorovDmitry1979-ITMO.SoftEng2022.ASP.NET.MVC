using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; } // ID студента
        public virtual string LastName { get; set; } // Имя
        public virtual string FirstName { get; set; } // Фамилия
        public virtual string Surname { get; set; } // Отчество
        public virtual double MiddleBall { get; set; } // Средний балл
    }
}