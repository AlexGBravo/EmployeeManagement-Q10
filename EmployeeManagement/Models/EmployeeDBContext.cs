using System.Data.Entity;

namespace EmployeeManagement.Models
{
    public class EmployeeDBContext : DbContext
    {

        /// <summary>
        /// Employees table.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext() : base("EmployeeDBContext")
        {
        }

    }
}