using System;
using HomeworkPractice.Models;
using HomeworkPractice.Services;

namespace HomeworkPractice.Controllers
{
	internal class EmployeeController
	{
        private EmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}
		public void GetFilteredEmployee()
		{
			decimal start = 1000;
			decimal end = 2000;

			foreach(Employee employee in _employeeService.FilterEmployeeBySalary(start, end))
			{
				string result = $"{employee.Name} - {employee.Surname} - {employee.Salary} - {employee.Age}";
				Console.WriteLine(result);
			}
		}

		public void SortEmployees()
		{
			Console.WriteLine("Choose one optionn for sorting: ");

			string sortText = Console.ReadLine();

            foreach (Employee employee in _employeeService.SortEmployee(sortText))
            {
                string result = $"{employee.Name} - {employee.Surname} - {employee.Salary} - {employee.Age}";
                Console.WriteLine(result);
            }
        }
	}
}

