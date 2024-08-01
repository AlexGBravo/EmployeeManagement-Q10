using EmployeeManagement.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        /// <summary>
        /// Employee DB context.
        /// </summary>
        private readonly EmployeeDBContext db = new EmployeeDBContext();


        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Get the employee list.
        /// </summary>
        public JsonResult GetEmployees()
        {

            // Get all from DB.
            var employees = db.Employees.ToList();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }



        /// <summary>
        /// Get one employee.
        /// </summary>
        /// <param name="id">Id from employee.</param>
        public JsonResult GetEmployeeById(int id)
        {
            // Find the employee by id.
            var employee = db.Employees.Find(id);
            return Json(employee, JsonRequestBehavior.AllowGet);
        }



        /// <summary>
        /// Create a new employee.
        /// </summary>
        /// <param name="employee">Employee model.</param>
        [HttpPost]
        public JsonResult AddEmployee(Employee employee)
        {
            // Sets default.
            employee.Id = 0;

            // Save information.
            db.Employees.Add(employee);
            db.SaveChanges();
            return Json(employee);
        }



        /// <summary>
        /// Update employee.
        /// </summary>
        /// <param name="employee">New employee model.</param>
        [HttpPost]
        public JsonResult UpdateEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return Json(employee);
        }



        /// <summary>
        /// Delete employee.
        /// </summary>
        /// <param name="id">Id from employee.</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteEmployee(int id)
        {
            var employee = db.Employees.Find(id);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
            return Json(employee);
        }


    }
}