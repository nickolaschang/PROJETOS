using System;
using System.Collections.Generic;
using NewProject2.Entities;
namespace NewProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced? (y/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours worked: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(name, hours, ValuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, ValuePerHour));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"Employee name: {emp.Name}, Hours worked: {emp.Hours:F2}, Value per Hour: ${emp.ValuePerHour:F2}, Total Payment: ${emp.Payment():F2}");
            }
        }
    }
}
