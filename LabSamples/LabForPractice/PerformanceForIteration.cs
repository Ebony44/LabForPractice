using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice
{
    class PerformanceForIteration
    {
        public static void TestCalculate()
        {
            for (int i = 0; i < 10; i++)
            {
                Calculate();
            }
        }

        private static void Calculate()
        {
            List<Double> numbers = new List<Double>();
            Double[] sums1 = new Double[1000];
            Double[] sums2 = new Double[1000];

            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(i * i);
            }

            Int64 startTime1 = Stopwatch.GetTimestamp();
            for (int i = 0; i < 1000; i++)
            {
                sums1[i] = withIEnumerable(numbers);
            }
            Int64 endTime1 = Stopwatch.GetTimestamp();

            Int64 startTime2 = Stopwatch.GetTimestamp();
            for (int i = 0; i < 1000; i++)
            {
                sums2[i] = withList(numbers);
            }
            Int64 endTime2 = Stopwatch.GetTimestamp();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("withIEnumerable.    Start = {0}, End = {1}: Diff = {2}", startTime1, endTime1, endTime1 - startTime1);
            // Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("withList. Start = {0}, End = {1}: Diff = {2}", startTime2, endTime2, endTime2 - startTime2);
            Console.WriteLine("-----------------------------------------------------");
        }

        private static double withIEnumerable(IEnumerable<double> numbers)
        {
            double sum = 0;
            foreach (Double number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        private static double withList(List<double> numbers)
        {
            double sum = 0;
            foreach (Double number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }

    static class LabIterationStaticClass
    {
        private static List<int> tempList;
        static LabIterationStaticClass()
        {
            tempList = new List<int>(capacity: 5);
            tempList.Add(4);
        }
        public static void TempShowListCount()
        {
            Console.WriteLine("list count " + tempList.Count);
        }
    }

}
