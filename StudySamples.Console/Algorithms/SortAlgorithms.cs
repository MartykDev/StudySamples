using StudySamples.ConsoleUi.Helpers;
using System;
using System.Diagnostics;

namespace StudySamples.ConsoleUi.Algorithms
{
    public static class SortAlgorithms
    {
        public static TimeSpan BubbleSort(ref int[] array)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        NumberHelper.SwapNumbersWithSecondVar(ref array[i], ref array[j]);
                    }
                }
            }

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        public static TimeSpan BubbleSortS(ref int[] array)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        NumberHelper.SwapNumbersWithSecondVar(ref array[j - 1], ref array[j]);
                    }
                }
            }

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }
    }
}