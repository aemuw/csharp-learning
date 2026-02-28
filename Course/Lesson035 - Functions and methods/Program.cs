namespace lesson35
{
    internal class Program
    {
        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат додавання: " + result);
        }

        static void Main(string[] args)
        {

            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            Console.WriteLine(c);
            PrintResult(c);

            PrintLine();
        }
        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine був визваний!");
        }

    }
}
