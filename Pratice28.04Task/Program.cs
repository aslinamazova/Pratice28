namespace Pratice28._04Task
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //1
            static bool IsUpperCase(string str)
            {
                return str.Equals(str.ToUpper());
            }

            Predicate<string> isUpper = IsUpperCase;

            bool element = isUpper("HELLO WORLD");
            Console.WriteLine(element);

            //2
            //static int Multiplication(int x, int y)
            //{
            //    return x *y ;
            //}
            Func<int, int, int> multiplication = (x,y) => x*y;

            int result = multiplication(20, 40);

            Console.WriteLine(result);

            //3
            static void Sum (int x, int y,int z,int s)
            {
                Console.WriteLine(x + y + z + s);
            }
            Action<int, int, int,int> sum = Sum;
            Sum(10, 20, 202, 548);

            //4
            static bool Division(int a)
            {
                return a%3 == 0 && a%5 == 0;
            }

            Predicate<int> division = Division;

            bool numbers = division(15);
            Console.WriteLine(numbers);
        }
        
    }
}