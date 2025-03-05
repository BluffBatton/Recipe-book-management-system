using System.Collections.Generic;

namespace NET_Course
{
    internal class Program
    {
        static void Main()
        {
            CustomList<int> customList = new CustomList<int>();
            var list = customList;
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            ListForEachTest(customList);

            list.Remove(30);
            Console.WriteLine("Removed number 30");
            ListForEachTest(customList);
            Console.WriteLine("Getting number by index 1: " + list[5]);
            Console.WriteLine("Попытка выхода за границы:");
            try
            {
                Console.WriteLine(list[10]); // Ожидаем исключение
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        internal static void ListForEachTest(CustomList<int> customList)
        {
            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
