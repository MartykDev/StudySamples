
namespace StudySamples.ConsoleUi.Helpers
{
    public static class NumberHelper
    {
        public static void SwapNumbersWithSecondVar(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        public static void SwapNumbersMath(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
    }
}