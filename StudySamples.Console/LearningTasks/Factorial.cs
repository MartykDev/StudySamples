
namespace StudySamples.ConsoleUi.LearningTasks
{
    public static class Factorial
    {
        public static ulong GetByLoop(ulong n)
        {
            ulong fact = 1;
            for (ulong i = 2; i < n + 1; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public static ulong GetByRecursion(ulong n)
        {
            if(n == 0)
                return 1;

            return n * GetByRecursion(n - 1);
        }
    }
}