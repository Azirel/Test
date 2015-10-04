using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneAndCopyTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = { 0, 1, 2, 3, };
            int[] massiveCopy = new int[4];
            int[] massiveClone = new int[4];
            massive.CopyTo(massiveCopy, 0);
            massiveCopy[0] = 1;
            massiveClone = (int[])massive.Clone();
            massiveClone[0] = 1;
            foreach (var item in massive)
            {
                Console.Write(item+", ");
            }
            //delay
            Console.ReadKey();
        }
    }
}
