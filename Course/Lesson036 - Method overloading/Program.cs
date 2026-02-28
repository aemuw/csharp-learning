namespace lesson36
{
    internal class Program
    {
        /// <summary>
        /// Повертає суму двох цілих чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Повертає суму трьох цілих чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Повертає суму двох чисел з плаваючою точкою 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int result = Sum(2, 4, 4);
            Console.WriteLine(result);

            double res = Sum(2.1, 5.4);
            Console.WriteLine(res);
        }
    }
}
