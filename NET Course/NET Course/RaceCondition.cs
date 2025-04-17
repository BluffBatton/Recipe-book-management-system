using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Course
{
    public static class RaceCondition
    {
        static int sharedValue = 0;
        public static void Main1()
        {
            Thread thread1 = new Thread(IncrementSharedValue);
            Thread thread2 = new Thread(IncrementSharedValue);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Final sharedValue: " + sharedValue);
        }

        static void IncrementSharedValue()
        {
            Thread.Sleep(0);
            for (int i = 0; i < 100000; i++)
            {
                int currentValue = sharedValue;
                currentValue++;
                sharedValue = currentValue;
            }
        }
    }
}
