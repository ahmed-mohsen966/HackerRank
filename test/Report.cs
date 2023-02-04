using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Report
    {
        public delegate bool eligibleEmployee(employee emp);
        public void processEmployee(employee[] employees , string title , eligibleEmployee IsEligible)
        {
            Console.WriteLine(title);
            Console.WriteLine("**************************************");

            foreach (var emp in employees)
            {
                if (IsEligible(emp))
                {
                    Console.WriteLine($"emp Id : {emp.Id} , Emp Name : {emp.Name} "  + "," +
                        $"Emp Total Sales : {emp.TotalSales} , Emp Gender : {emp.Gender}");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void processEmployeeWith10000PlusSales(employee[] employees)
        {
            Console.WriteLine("employees with sales more than $10000");
            Console.WriteLine("**************************************");

            foreach (var emp in employees)
            {
                if (emp.TotalSales >= 10000)
                {
                    Console.WriteLine($"emp Id : {emp.Id} , Emp Name : {emp.Name} " +
                        $"Emp Total Sales : {emp.TotalSales} , Emp Gender : {emp.Gender}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public void processEmployeeWithSalesbetween12000And15000(employee[] employees)
        {
            Console.WriteLine("employees with sales between $12000 and $15000");
            Console.WriteLine("**************************************");

            foreach (var emp in employees)
            {
                if (emp.TotalSales >= 12000 && emp.TotalSales <15000)
                {
                    Console.WriteLine($"emp Id : {emp.Id} , Emp Name : {emp.Name} " +
                        $"Emp Total Sales : {emp.TotalSales} , Emp Gender : {emp.Gender}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
