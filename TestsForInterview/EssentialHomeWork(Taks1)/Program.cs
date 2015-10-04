using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialHomeWork_Taks1_
{
    class Program
    {
        public delegate int Mydelegate(int a, int b, int c);
        static public int Del(int a, int b, int c)
        {
            Console.WriteLine("Запуск.");
            return a + b + c;
        }
        static void Main(string[] args)
        {

            Mydelegate del1 = delegate(int x, int y, int z) { return x * y * z; };
            Mydelegate del2 = Del;
            Mydelegate del3 = Del;
            Mydelegate list = null;
            list += del2;
            list += del3;
            list.Invoke(1, 2, 3);
            Console.WriteLine(list(3,4,5));
            //delay
            Console.ReadKey();
        }
    }
}
