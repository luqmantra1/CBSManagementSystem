using Microsoft.EntityFrameworkCore;
using CBSManagementSystem.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CBSManagementSystem.Data
{
    public class CBSManagementContext : DbContext
    {
        public CBSManagementContext(DbContextOptions<CBSManagementContext> options)
            : base(options)
        {
        }

        // DbSet for Employees table
        public DbSet<Employee> Employees { get; set; }

        // DbSet for Donations table
        public DbSet<Donation> Donations { get; set; }

    }
}
