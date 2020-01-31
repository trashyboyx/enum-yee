using enum_yee.Entities;
using enum_yee.Entities.Enums;
using System;
using System.Globalization;

namespace enum_yee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            var monthAndYear = Console.ReadLine().Split("/");
            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Incomefor : " + month + "/" + year + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
