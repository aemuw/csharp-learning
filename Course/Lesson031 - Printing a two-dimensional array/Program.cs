namespace lesson31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 5, 1, 5, 8, 0 },
                { -2, 5, 9, -1, 4 },
                { 3, 12, 4, -2, -34 }
            };

            /*
            //пробігається по кожному елементу array та передає значення в item
            foreach (var item in array)
                Console.Write(item + " ");
            */

            //кількість вимірів
            Console.WriteLine(array.Rank);

            //кількість всіх елементів масиву
            Console.WriteLine(array.Length);

            //кількість елементів у вимірах масиву

            //кількість рядків
            Console.WriteLine(array.GetLength(0));

            //кількість елементів в стопці
            Console.WriteLine(array.GetLength(1));

            //масив не трьовимірний, виникне помилка
            //Console.WriteLine(array.GetLength(2));

            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }

        }
    }
}
