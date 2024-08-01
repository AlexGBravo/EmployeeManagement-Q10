using System.Data.Entity;

namespace EmployeeManagement.Models
{
    public class EmployeeDBInitializer : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            base.Seed(context);
        }
    }
}