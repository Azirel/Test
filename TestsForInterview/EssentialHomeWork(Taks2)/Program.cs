using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialHomeWork_Taks2_
{
    class Program
    {
        public delegate int ArithmeticAction(int a, int z);
        static void Main(string[] args)
        {
            ArithmeticAction Add = delegate(int a, int b) { return a + b; };
            ArithmeticAction Sub= delegate(int a, int b) { return a - b; };
            ArithmeticAction Mul= delegate(int a, int b) { return a * b; };
            ArithmeticAction Div= delegate(int a, int b) { return a / b; };
            int x;
            int y;
            do
            {
                try
                {
                    Console.Write("a=");
                    x = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);

            do
            {
                try
                {
                    Console.Write("b=");
                    y = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);


            try
            {
                do
                {
                    switch (Console.ReadLine())
                    {
                        case "Add": Console.WriteLine(Add(x, y)); break;
                        case "Sub": Console.WriteLine(Sub(x, y)); break;
                        case "Mul": Console.WriteLine(Mul(x, y)); break;
                        case "Div": Console.WriteLine(Div(x, y)); break;
                        default: Console.WriteLine("Мимо"); break;
                    } 
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }

            //delay
            Console.ReadKey();
        }
    }
}
