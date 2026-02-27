namespace lesson28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 10, 5, 6, 77, 89 }; 

            Console.WriteLine(array1[0]); 
            Console.WriteLine(array1[5]); 

            Console.WriteLine(array1[array1.Length - 1]);  

            //те ж саме, що й Console.WriteLine(array[array.Length-1]); 
            Console.WriteLine(array1[^1]);  

            //новий масив з 1 по 4 елемент масиву array 
            int[] array2 = array1[1..4];  

            //з 3 елемента до останього 
            int[] array3 = array1[3..];

            //передостанній в масиві Console.WriteLine(array[index]);
            Index index1 = ^2;

            //елемент з індексом 2 (третій з початку)
            Index index2 = 2;

            Console.WriteLine($"value {index1.Value} isFromEnd {index1.IsFromEnd}");

            //третій з кінця
            Index newIndex1 = new Index(3, true);

            //третій з початку (індекс 2)
            Index newIndex2 = new Index(2, false);

            Range range = 1..4; 

            int[] array4 = array1[range];

            //1(індекс) - початок діапазону, 4(індекс) - кінець 
            Range newRange = new Range(1, 4);

            //від 1 елем. з кінця до 4 елем. з кінця
            Range rangeArray = ^4..^1;

            string str = "Hello World !!! =)";

            //отримаємо символ "H" 
            Console.WriteLine(str[0]);

            //отримаємо символ ")"
            Console.WriteLine(str[^1]);

            //отримаємо діапазон "=)"
            Console.WriteLine(str[^2..]);

            //отримаємо діапазон "Hello"
            Console.WriteLine(str[0..6]); 
        }
    }
}
