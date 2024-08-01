using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() : base("EmployeeDBContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}