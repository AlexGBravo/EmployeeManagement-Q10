using System.Data.Entity;

namespace EmployeeManagement.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext() : base("EmployeeDBContext")
        {
        }

    }
}