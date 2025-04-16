using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Course
{
    public static class Deadlock
    {
        private readonly static object lock1 = new object();
        private readonly static object lock2 = new object();
        public static void Main2()
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }


        public static void Method1()
        {
            lock (lock1)
            {
                Thread.Sleep(1000);
                lock (lock2)
                {
                    Console.WriteLine("Method1");
                }
            }
        }

        public static void Method2()
        {
            lock (lock2)
            {
                Thread.Sleep(1000);
                lock (lock1)
                {
                    Console.WriteLine("Method2");
                }
            }
        }
    }
}
