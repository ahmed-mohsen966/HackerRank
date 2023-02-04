using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;

namespace test
{
    
    internal partial class Program
    {
        public static void miniMaxSum(List<double> arr)
        {
            arr.Sort();
            double min = 0;
            double mx = 0;
            for (int i = 0; i < arr?.Count; i++)
            {
                if (i >= 0 && i < (arr.Count-1)) { min += arr[i]; }
            }
            for (int i = 0; i < arr?.Count; i++)
            {
                if (i > 0 && i <= arr.Count) { mx += arr[i]; }
            }
            Console.WriteLine($"{min} {mx}");
        }
        public static void plusMinus(List<int> arr)
        {
            float posNum = 0;
            float negNum = 0;
            float zeroNum = 0;
            for (int i = 0; i < arr?.Count; i++)
            {
                if (arr[i] > 0) { posNum++; }
                else if (arr[i] < 0) { negNum++; }
                else if (arr[i] == 0) { zeroNum++; }
            }
            double calcPos = posNum / (double)arr?.Count;
            double calcNeg = negNum / (double)arr?.Count;
            double calczero = zeroNum / (double)arr?.Count;

            Console.WriteLine(calcPos.ToString(),calcNeg.ToString(), calczero.ToString()) ;
            Console.WriteLine($"{calcPos.ToString()}\n{calcNeg.ToString()}\n{calczero.ToString()}");

        }
        public delegate void MyDelegate();
        static bool SalesGT1000(employee emp) => emp.TotalSales >= 10000;
        static bool SalesLT1000(employee emp) => emp.TotalSales < 10000;
        class Result
        {
            public static string timeConversion(string s)
            {
                // DateTime d = DateTime.Parse(s);
                // Console.WriteLine(d.ToString("HH:mm:ss"));
                DateTime d = DateTime.Parse(s);
                return d.ToString("HH:mm:ss");


            }

        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {

            List<int> result = new List<int>(); 
            int countA = 0;
            int countB = 0;
            int ind;
            for (ind = 0; ind < a?.Count; ind++)
            {
                if (a[ind] > b[ind]) { countA++; }
                else if (b[ind] > a[ind]) { countB++; }
            }
                result.Add(countA);
                result.Add(countB);
                return result;
        }

        static void Main(string[] args)
        {
            #region Dealing with delegates

            var emps = new employee[]
            {
               new employee {Id = 1 , Name = "ahmed" , TotalSales = 10000 , Gender="M"},
               new employee {Id = 2 ,Name = "mahmed",TotalSales = 15000 , Gender = "M"},
               new employee {Id = 3 , Name="sara" , TotalSales = 9000 , Gender = "F"},
               new employee {Id = 4 , Name = "aya" , TotalSales =12000, Gender="F" },
               new employee {Id = 5 , Name = "khaled" , TotalSales =13000, Gender="M" },
               new employee {Id = 6 , Name = "eman" , TotalSales =8000, Gender="F" },
               new employee {Id = 7 , Name = "omar" , TotalSales =16000, Gender="M" }
            };

            var report = new Report();
            //report.processEmployeeWith10000PlusSales(emps);
            //report.processEmployeeWithSalesbetween12000And15000(emps);

            //report.processEmployee(emps, "employees with sales more than $10000", SalesGT1000);
            //report.processEmployee(emps, "employees with sales Less than $10000", SalesLT1000);

            /* anonymous methods */

            //report.processEmployee(emps, "employees with sales more than $10000", delegate (employee emp) { return emp.TotalSales >= 10000 && emp.Gender == "F"; });
            //report.processEmployee(emps, "employees with sales Less than $10000", delegate(employee emp) { return emp.TotalSales < 10000; });

            /* lambda expression */

            //report.processEmployee(emps, "employees with sales more than $10000",(employee emp) => emp.TotalSales >= 10000 && emp.Gender == "F");
            //report.processEmployee(emps, "employees with sales Less than $10000", (employee emp) => emp.TotalSales < 10000);

            //report.processEmployee(emps, "employees with sales more than $10000", emp => emp.TotalSales >= 10000 && emp.Gender == "M");
            //report.processEmployee(emps, "employees with sales Less than $10000", emp => emp.TotalSales < 10000 && emp.Gender == "F");


            #endregion

            #region Dealing with Events

            //Exam Csharp = new Exam() { ExamName = "Csharp", Status = ExamStatus.pending };
            //Student stdOne = new Student() { Name = "ahmed" };
            //Student stdTwo= new Student() { Name = "mahmed" };
            //Student stdThree = new Student() { Name = "mahoud" };

            #endregion

            //List<double> arr = new List<double>() { 140537896, 243908675 ,670291834 ,923018467 ,520718469 };

            //miniMaxSum(arr);

            //string s = Console.ReadLine();
            //DateTime d = DateTime.Parse(s);
            //Console.WriteLine("24 Hour Format:");
            //Console.WriteLine(d.ToString("HH:mm:ss"));
            //Console.ReadLine();
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string s = Console.ReadLine();

            //string result = Result.timeConversion(s);
            //Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            //int n = 6;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        if (j <= n - i) { Console.Write(" "); }
            //        else { Console.Write("#"); }
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(new String(' ', n - i) + new String('#', i));
            //}

            //List<int> candles = new List<int>() { 3, 2, 1, 3 };
            //int count = 0;
            //int max = 0;
            //for (int i = 0; i < candles?.Count; i++)
            //{
            //    int num = candles[i];
            //    if (num > max) { max = num; count = 1; }
            //    else if (num == max) { count++; }
            //}
            //Console.WriteLine(count);


            //List<int> result = new List<int>();
            //for (int i = 0; i < orders?.Count; i++)
            //{
            //    int sum = 0;
            //    for (j = 0; j < orders[i]?.Count; j++)
            //    {
            //        sum += orders[i][j];
            //    }
            //    result.Add(sum)
            //    sum = 0;
            //}
            Dictionary<int, int> times = new Dictionary<int, int>();
            for (int i = 0; i < orders.Count; i++)
            {
                times[i + 1] = orders[i][0] + orders[i][1];
            }

            return times.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value).Keys.ToList();
            
        }
    }
    
}
