using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSytem.Models;

namespace SchoolManagementSytem.Data
{
    public class SchoolManagementSytemContext : DbContext
    {
        public SchoolManagementSytemContext (DbContextOptions<SchoolManagementSytemContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolManagementSytem.Models.Student> Student { get; set; } = default!;

        public DbSet<SchoolManagementSytem.Models.Lecturer> Lecturer { get; set; } = default!;

        public DbSet<SchoolManagementSytem.Models.Course> Course { get; set; } = default!;

        public DbSet<SchoolManagementSytem.Models.Department> Department { get; set; } = default!;
    }
}
