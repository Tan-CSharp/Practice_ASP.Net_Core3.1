using System;
using System.ComponentModel.DataAnnotations;

namespace _02_FirstCrudApplication.Models
{
    public class Employee
    {
        /// <summary>
        /// Name: Contains employee name.
        /// </summary>
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        /// <summary>
        /// Age: Contains employee age.
        /// </summary>
        [Range(10, 60, ErrorMessage = "Ages 16-60 only")]
        public int Age { get; set; }

        /// <summary>
        /// Salary: Contains employee salary.
        /// </summary>
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid, enter like # or #.##")]
        public decimal Salary { get; set; }
        /// <summary>
        /// Department: For employee department
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Sex: For employee sex.
        /// </summary>
        [RegularExpression(@"^[MF]+$", ErrorMessage = "Select any one option")]
        public Char Sex { get; set; }
    }
}