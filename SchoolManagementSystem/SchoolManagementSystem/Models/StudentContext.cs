using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SchoolManagementSystem.Models
{
    public class StudentContext: DbContext
    { 

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard>Standards {get; set;}
       

        public System.Data.Entity.DbSet<SchoolManagementSystem.Models.StudentStandard> StudentStandards { get; set; }

        public System.Data.Entity.DbSet<SchoolManagementSystem.Models.StudentFee> StudentFees { get; set; }
    }
}