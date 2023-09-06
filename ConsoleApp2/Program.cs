using System;

namespace Delegates
{
    public delegate void Calculation(int a, int b);
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is: {0}", result);
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction result is: {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is: {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);
            obj.Invoke(10, 30);
            Calculation obj1 = new Calculation(Substraction);
            obj1(20, 10);


            //obj(20, 11);
            Calculation obj2 = new Calculation(Multiplication);
            obj2.Invoke(10, 3);
            //obj = Multiplication;
            //obj.Invoke(20, 30);

        }
    }
}

