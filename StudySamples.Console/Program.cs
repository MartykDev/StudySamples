using StudySamples.ConsoleUi.Helpers;
using StudySamples.ConsoleUi.LearningTasks;
using System;

namespace StudySamples.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Factorial.GetByLoop(5);
            Console.WriteLine(result);

            var array = ArrayHelper.GetRandomIntArray(5000);

            ////ArrayHelper.PrintIntArray(array.ToArray());

            //var a = new List<int>(array).ToArray();
            //var fTime = SortAlgorithms.BubbleSort(ref a);

            ////ArrayHelper.PrintIntArray(a);
            //Console.WriteLine("MS : " + fTime.TotalMilliseconds);

            //Console.WriteLine("----------------------------------------------------------------------------" + Environment.NewLine);

            //var b = new List<int>(array).ToArray();
            //var sTime = SortAlgorithms.BubbleSortS(ref b);

            ////ArrayHelper.PrintIntArray(b);
            //Console.WriteLine("MS : " + sTime.TotalMilliseconds);


            //var array = FibonacciNumbers.GetNumbersToN(10);
            //ArrayHelper.PrintIntArray(array.ToArray());

            Console.ReadKey();
        }
    }
}