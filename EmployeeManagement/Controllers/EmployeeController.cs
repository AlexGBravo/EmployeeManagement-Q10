using EmployeeManagement.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();


        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            var employees = db.Employees.ToList();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEmployeeById(int id)
        {
            var employee = db.Employees.Find(id);
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return Json(employee);
        }

        [HttpPost]
        public JsonResult UpdateEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return Json(employee);
        }

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