using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EssentialHomeWork_Taks3_
{
    class Program
    {
        delegate int Rand();
        delegate double RandAvg(Rand[] mass);
        static public int RandMethod()
        {
            return new Random().Next(1, 101);
        }
        static void Main(string[] args)
        {
            Rand[] mass = new Rand[71];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new Rand(RandMethod);
            }
            RandAvg avg = delegate(Rand[] mas)
            {
                double sum = 0;
                foreach (var item in mas)
                {
                    sum += Convert.ToDouble(item.Invoke());
                    Thread.Sleep(10);
                }
                double result = sum / Convert.ToDouble(mas.Length);
                return result;
            };
            Console.WriteLine(avg(mass));
            //delay
            Console.ReadKey();
        }
    }
}
