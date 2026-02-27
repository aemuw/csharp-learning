namespace lesson27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 111, 10, 4, 99, 49, 64, 77, 4, 111, 5 };
            //int result = array.Max();

            Console.WriteLine(array.Min());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Sum());

            //пошук суми парних та непарних чисел в масиві
            Console.WriteLine(array.Where(i => i % 2 == 0).Sum());
            Console.WriteLine(array.Where(i => i % 2 != 0).Min());

            //прибирає повторювані елементи, лишає унікальні, запис в новий масив
            int[] result = array.Distinct().ToArray();

            int[] sortedMinMaxArray = array.OrderBy(i => i).ToArray();
            int[] sortedMaxMinArray = array.OrderByDescending(i => i).ToArray();

            Array.Sort(array);

            //пошук до першого елемента, меншого за 70 (з початку)
            int findResult = Array.Find(array, i => i < 70);

            //пошук до першого елемента, меншого за 70 (з кінця)
            int findLastResult = Array.FindLast(array, i => i < 70);

            int[] findArrayResult = Array.FindAll(array, i => i < 70);

            int findIndex = Array.FindIndex(array, i => i == 77);
            int findLastIndex = Array.FindLastIndex(array, i => i == 111);

            //результат буде = -1, оскільки такого елементу немає
            int findNotExistsIndex = Array.FindIndex(array, i => i == 2277);

            //елементи масиву після цього будуть в протилежному порядку
            Array.Reverse(array);

            //масив з усіма числами, що менше 70
            int[] findNumbers = array.Where(i => i < 70).ToArray();

            //перший елемент, що менше 70
            int findNumber = array.Where(i => i < 70).First();

            //в колекції немає елементів, що < 0, вилетить Exception
            int findNumberException = array.Where(i => i < 0).First();

            //повертає дефолтне значення для типу змінної - для int це 0, для посилальних типів - null
            int findNumberOrDefault = array.Where(i => i < 0).FirstOrDefault();
        }
    }
}
