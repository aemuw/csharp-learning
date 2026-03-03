namespace lesson37
{
    internal class Program
    {
        int c = 11;
        static int d = 2;
        //static int d = 3;

        static int b = 11;
        static void Foo()
        {
            int b = 9;

            //статичні методи не можуть працювати з нестатичними змінними
            //c--;

            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            int a = 2;

            for (int i = 0; i < 10; i++)
            {
                i++;
                a--;
                Program.d--;
                //int i = 1;
            }
            a++;
            //i++;
            //b++;

            //Program.Foo();
            Foo();
            Program program = new Program();
            program.c++;
            
        }
    }
}
