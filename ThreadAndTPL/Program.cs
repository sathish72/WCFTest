using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTPL
{
    class Program
    {
        static void Main(string[] args)
        {

            var thread1 = new Thread(() => PrintData1(10));
            thread1.Start();

            var thread2 = new Thread(() => PrintData2(20));
            thread2.Start();


            //Parallel.For(0, 10, x => PrintData1(10));


            //Parallel.For(0, 10, x => PrintData2(10));

            Thread.Sleep(-1);
            //Parallel.For(0, 1000000, x => PrintData());

        }

        private static void PrintData1(int intValue)
        {
            string x = "";

            for (int intI = 0; intI <= intValue; intI++)
            {
                Console.WriteLine("Print data 1 {0}", intI.ToString());
            }
        }

        private static void PrintData2(int intValue)
        {

            for (int intI = 0; intI <= intValue; intI++)
            {
                Console.WriteLine("Print data 2 {0}", intI.ToString());
            }
        }

    }
}
