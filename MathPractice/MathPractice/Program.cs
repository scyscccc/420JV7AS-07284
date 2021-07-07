namespace MathPractice
{
    public static class Util
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsDivisibleBy(int a, int b)
        {
            return a % b == 0;
        }

        public static int Power(int a, int b)
        {
            return (int)System.Math.Pow(a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Run the tests!");
        }
    }
}
