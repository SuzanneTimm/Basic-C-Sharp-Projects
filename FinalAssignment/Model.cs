using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Text;

namespace FinalAssignment
{
   public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }

    public class StudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

    }



}
