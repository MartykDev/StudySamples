using System;

namespace StudySamples.ConsoleUi.Helpers
{
    public static class ArrayHelper
    {
        public static int[] GetRandomIntArray(int size = 100000)
        {
            var randm = new Random();
            int[] array = new int[size]; 

            for (int i = 0; i < size; i++)
                array[i] = randm.Next(0, 1000);

            return array;
        }

        public static void PrintIntArray(int[] array)
        {
            Console.WriteLine("Array: ");
            
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            
            Console.WriteLine(Environment.NewLine);
        }
    }
}