using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using FixationExe_Employee.Entities;

namespace FixationExe_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> ListEmployees = new List<Employee>();

            using(StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] dices = sr.ReadLine().Split(',');
                    string name = dices[0];
                    string email = dices[1];
                    double salary = double.Parse(dices[2], CultureInfo.InvariantCulture);
                    ListEmployees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double ESalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var mailEmployees = ListEmployees.Where(e => e.Salary > ESalary).OrderBy(e => e.Email).Select(e => e.Email);
            Console.WriteLine($"\nEmail of people whose salary is more than {ESalary.ToString("F2", CultureInfo.InvariantCulture)}: ");

            foreach (string e in mailEmployees)
            {
                Console.WriteLine(e);
            }

            var sumSalary = ListEmployees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine($"\nSum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
