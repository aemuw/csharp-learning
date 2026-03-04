using System.Text;

namespace lesson41
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] arr = null;
            return arr;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string str = null;

            string result = str ??= "default string";
            //в str тепер "default string", і в result також "default string"
            //в такому разі краще писати так:
            //str ??= "default string";
            Console.WriteLine("кількість символів в рядку: " + str.Length);

            int[] array = GetArray();

            array ??= new int[0];

            Console.WriteLine("кількість елементів у масиві: " + array.Length);


        }
    }
}
