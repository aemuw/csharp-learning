using System.Text;

namespace lesson42
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


            int[] array = GetArray();
            /*
            if (array == null)
                Console.WriteLine("сума елементів масиву: 0");
            else
                Console.WriteLine("сума елементів масиву: " + array.Sum());
            */

            Console.WriteLine("сума елементів масиву: " + (array?.Sum() ?? 0));


        }
    }
}
