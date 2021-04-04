using System.Collections.Generic;

namespace StudySamples.ConsoleUi.LearningTasks
{
    public static class FibonacciNumbers
    {
        public static IEnumerable<int> GetNumbersToN(int n)
        {

            int prevNum = 1, curNum = 1, nextNum = 0;
            while (n > nextNum)
            {
                nextNum = prevNum + curNum;
                prevNum = curNum;
                curNum = nextNum;
                yield return nextNum;
            }
        }
    }
}