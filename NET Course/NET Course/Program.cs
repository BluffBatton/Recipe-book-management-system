using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value types
            int x = 5, y = x;
            y = 10;
            Console.WriteLine("Значимые типы:");
            Console.WriteLine($"x: {x}, y: {y}");

            var teacher1 = new Teacher("Mykyta"); // Struct
            var teacher2 = teacher1;
            Console.WriteLine($@"Имя первого учителя: {teacher1.Name}, имя второго учителя: {teacher2.Name} (до изменений)");
            teacher2.Name = "Danylo";
            Console.WriteLine($@"Имя первого учителя: {teacher1.Name}, имя второго учителя: {teacher2.Name} (после изменений)");

            // Reference types
            string a = "Foo", b = a;
            b = "Boo"; // Создаётся новый объект в куче, а не "дополняется" существующий
            Console.WriteLine("\nСсылочные типы:");
            Console.WriteLine($"a: {a}, b: {b}");

            var student1 = new Student("Sanek");
            var student2 = student1;
            Console.WriteLine($"Имя первого студента: {student1.Name}, второго: {student2.Name} (до изменений)");
            student2.Name = "Igor";
            Console.WriteLine($"Имя первого студента: {student1.Name}, второго: {student2.Name} (после изменений)");
        }
    }

}
