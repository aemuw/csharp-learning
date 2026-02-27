namespace lesson30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //поки тут null
            int[,] array;

            //тепер цей ярлик вказує на місце в оперативній пам'яті з 3 рядками і 5 стовпцями
            //всі значення - 0, дефолтне значення при ініціалізації типу int - 0
            array = new int[3, 5];

            //або int[,] array = new int[3, 5]; 

            array[0, 2] = 5;
            //array[10, 15] = 4;
            Console.WriteLine(array[0, 2]);

            int[,] arrayNew = new int[3, 5]
            {
                { 5, 1, 5, 8, 0 },
                { -2, 5, 9, -1, 4 },
                { 3, 12, 4, -2, -34 }
            };

            int[,] arrayNew2 = new int[,]
            {
                { 5, 1, 5, 8, 0 },
                { -2, 5, 9, -1, 4 },
                { 3, 12, 4, -2, -34 }
            };

            int[,] arrayNew3 =
            {
                { 5, 1, 5, 8, 0 },
                { -2, 5, 9, -1, 4 },
                { 3, 12, 4, -2, -34 }
            };
        }
    }
}
