using System.Text;

namespace lesson34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //двовимірний прямокутний масив
            int[,,] array = new int[4, 3, 5];

            array[0, 2, 3] = 55;

            Console.WriteLine(array[0, 2, 3]);

            int[,,] array2 =
            {
                {
                    { 3, 2, 4 },
                    { 3, 4, 2 }
                },
                {
                    { 2, 4, 2 },
                    { 2, 0, -1 }
                },
                {
                    { 0, -13, 2 },
                    { 4, -9, 1 }
                }
            };

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(100);
                    }
                }
            }

            Console.WriteLine("Двовимірний прямокутний масив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Page №: " + (i + 1));
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            //зубчатий масив
            int[][][] arrayToothed = new int[random.Next(3, 6)][][];

            for (int i = 0; i < arrayToothed.Length; i++)
            {
                arrayToothed[i] = new int[random.Next(2, 6)][];

                for (int j = 0; j < arrayToothed[i].Length; j++)
                {
                    arrayToothed[i][j] = new int[random.Next(2, 6)];

                    for (int k = 0; k < arrayToothed[i][j].Length; k++)
                    {
                        arrayToothed[i][j][k] = random.Next(100);
                    }
                }
            }

            Console.WriteLine("Ступінчатий(зубчатий) масив:");
            for (int i = 0; i < arrayToothed.Length; i++)
            {
                Console.WriteLine("Page №: " + (i + 1));
                for (int j = 0; j < arrayToothed[i].Length; j++)
                {
                    for (int k = 0; k < arrayToothed[i][j].Length; k++)
                    {
                        Console.Write(arrayToothed[i][j][k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
