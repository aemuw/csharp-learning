namespace lesson33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            int[,] array2 = new int[3, 5];

            //1 вимір
            int arrayRank = array.Rank;

            //2 виміри
            int array2Rank = array2.Rank;

            //3 елементи
            int arrayLength = array.Length;

            //15 елементів
            int array2Length = array2.Length;

            //в елементі array з індексом 0 (підмасив) виділяємо місце під 5 елементів
            array[0] = new int[5];
            array[1] = new int[2];
            array[2] = new int[6];

            //в новий масив присвоїли значення елементу масиву під індексом 0 (масив з 5 елементами)
            int[] arr = array[0];

            Console.WriteLine(array[2][4]);

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                //array[i].Length - отримуємо кількість елементів у кожному підмасиву
                for (int j = 0; j < array[i].Length; j++) 
                {
                    array[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t"); 
                }
                Console.WriteLine();
            }
        }
    }
}
