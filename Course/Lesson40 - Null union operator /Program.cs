using System.Text;

namespace lesson40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string str = "test";
            string strn = null;
             
            Console.WriteLine(strn ?? "немає даних");

            string result = str ?? string.Empty;

            Console.WriteLine("кількість символів у рядку: " + result.Length);
        }
    }
}
