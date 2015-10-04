using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_test
{
    class Program
    {
        static public void Method1(int a)
        {
            Console.WriteLine("Method1");
        }
        static public void Method2()
        {
            Console.WriteLine("Method2");
        }
        static public void Method3()
        {
            Console.WriteLine("Method3");
        }
        delegate void list();
        delegate void elem();
        static void Main(string[] args)
        {
            elem newList = null;
            elem[] elems = new elem[10];
            int a=12;
            //elems[0] = new elem( Method1(int a));
            elems[1] = new elem(Method2);
            elems[2] = new elem(Method3);
            newList += elems[0];
            newList += elems[1];
            newList += elems[2];
            newList();
            elems[0] = Method2;
            elems[0]();
            newList += () => { Console.WriteLine("Hello anonymous."); };
            newList();
            //delay
            Console.ReadKey();
        }
    }
}
