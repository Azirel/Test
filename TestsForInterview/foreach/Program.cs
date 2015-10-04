using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class ForeachTest : IEnumerable
    {
        //public 
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        yield return i;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

    }
    class Program
    {
        public IEnumerator massive()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
        static void Main(string[] args)
        {

            foreach (var item in new ForeachTest())
            {
                Console.WriteLine(item);
            }
            //delay
            Console.ReadKey();
        }
    }
}
