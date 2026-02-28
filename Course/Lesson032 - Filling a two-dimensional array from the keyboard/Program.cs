namespace lesson32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* заповнення рандомними числами
            int[,] array = new int[10, 6];

            Random random = new Random();

            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //згенеруються будь-які рандомні числа
                    //array[i, j] = random.Next();

                    //згенеруютьс рандомні числа від 0 до 100
                    array[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */

            /* заповнення з клавіатури
            int[,] array = new int[2, 3];

            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine("рядок: " + i + " стовпець: " + j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */

            string[,] array = new string[2, 3];

            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine("рядок: " + i + " стовпець: " + j);
                    array[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
