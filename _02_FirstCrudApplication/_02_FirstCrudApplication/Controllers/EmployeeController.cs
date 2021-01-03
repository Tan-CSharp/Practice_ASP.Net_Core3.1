using _02_FirstCrudApplication.Models;
using _02_FirstCrudApplication.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _02_FirstCrudApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(EmployeeRepository.AllEmployees);
        }

        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeRepository.Create(employee);
                return View("Thanks", employee);
            } else
            {
                return View();
            }
            
        }
        public IActionResult Update(string empName)
        {
            Employee emp = EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp, string empName)
        {
            if (ModelState.IsValid)
            {
                EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault().Age = emp.Age;
                EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault().Department = emp.Department;
                EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault().Salary = emp.Salary;
                EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault().Sex = emp.Sex;
                EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault().Name = emp.Name;
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(string empName)
        {
            Employee emp = EmployeeRepository.AllEmployees.Where(x => x.Name.Equals(empName)).FirstOrDefault();
            EmployeeRepository.Delete(emp);
            return RedirectToAction("Index");
        }
    }
}
