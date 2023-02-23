using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Test
{
    static class Print
    {
        public static void printReport(List<Employee> employees)
        {
            printHeader();
            printContent1(employees);
            printContent2(employees);
            printFooter();

        }
        private static void printHeader()
        {
            Console.WriteLine("Employees Report");
        }
        private static void printContent1(List<Employee> employees)
        {

            employees.ForEach((employee) =>
            {
                Console.Write($"\n\nEmployee:\n Id = {employee.Id}  \tName = {employee.Name}  \tSalary = {employee.Salary}\nAdditionalDetails:\n");

                employee.AdditionalDetails.ToList().ForEach((additionalDetails) =>
                {
                    Console.Write("{0} = {1}  \t", additionalDetails.Key, additionalDetails.Value);

                });
            });

        }
        private static void printContent2(List<Employee> employees)
        {
            double averagesalary = employees.Average(employee => employee.Salary);
            Console.WriteLine("\n\n\nAverage Salary: {0:0.##}\n", averagesalary);
        }

        private static void printFooter()
        {
            Console.WriteLine("\n{0:dd/MM/yyyy HH:mm:ss}\n", DateTime.Now);
        }

    }
}

