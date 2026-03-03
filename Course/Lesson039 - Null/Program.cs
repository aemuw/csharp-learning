namespace lesson39
{
    class MyClass
    {

    }

    struct MyStruct
    {

    }

    internal class Program
    {
        static void Foo()
        {
            int[] a = new int[10];
            //після виклику в main посилання буде видалене
            //в керованій купі лишаться дані

            //в С# garbage collection очистить дані в купі
        }

        static void Main(string[] args)
        {
            bool b;
            //false

            int a;
            //0

            double d;
            //0

            Random random;
            //null

            int[] arr;
            //null

            MyClass myClass;
            //null
            
            MyStruct myStruct;
            //не null


            //дефолтні значення:
            //якщо відноситься до класу (ref) - null
            //якщо відноситься до структури (value) - залежить від типу (int, наприклад, 0)

            int[] arr1;
            //посилання є, даних немає
            //пусте посилання (відсутність зв'язку) - null
            //у value types (значущому типі) null зберігатись не може
            //в стеці arr1(ref)

            int[] arr2 = new int[10];
            //в стеці arr2(ref) посилається на arr2(DATA) в керованій купі


            int[] arr3 = new int[10];
            arr3 = null;
            //зв'язок між посиланням в стеці та даними в купі буде розірваний
            //лишиться окремо arr3(ref) в стеці та дані в купі, проте між ними не буде зв'язку

            //в C# таку пам'ять в керованій купі очистить garbage collection


            Foo();

            int[] arr4 = new int[10];
            arr4 = null;
            Console.WriteLine(arr4[0]);
            //нема посилання, виникне помилка
        }
    }
}
