using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CompanyRoster
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string inputLine;
            
            List<Employee> myEmployees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine();
                Employee curEmployee = new Employee(inputLine);
                myEmployees.Add(curEmployee);
            }

            var result = myEmployees.GroupBy(e => e.Department)
                                    .Select(e => new
                                    {
                                        Department = e.Key,
                                        AverageSalary = e.Average(emp => emp.Salary),
                                        Employees = e.OrderByDescending(emp => emp.Salary),
                                    })
                                    .OrderByDescending(x => x.AverageSalary)
                                   .First();
            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
