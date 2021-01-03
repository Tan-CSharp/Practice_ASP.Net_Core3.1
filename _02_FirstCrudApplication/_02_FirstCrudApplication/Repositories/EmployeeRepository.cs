using _02_FirstCrudApplication.Models;
using System.Collections.Generic;

namespace _02_FirstCrudApplication.Repositories
{
    public static class EmployeeRepository
    {
        private static List<Employee> listEmployees = new List<Employee>();

        public static IEnumerable<Employee> AllEmployees
        {
            get { return listEmployees; } 
        }

        public static void Create(Employee e)
        {
            listEmployees.Add(e);
        }

        public static void Delete(Employee employee)
        {
            listEmployees.Remove(employee);
        }
    }
}