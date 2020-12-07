using StudySamples.ConsoleUi.Helpers;
using System;

namespace StudySamples.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ArrayHelper.GetRandomIntArray();
            ArrayHelper.PrintIntArray(array);

            Console.ReadKey();
        }
    }
}