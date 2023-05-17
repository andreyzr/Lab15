using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int step1 = 2;
            Console.WriteLine("Проверка арифметической прогрессии");
            ArithProgression arith=new ArithProgression();
            Console.WriteLine($"Начальное значение:{x1}");
            arith.setStart(10);
            Console.WriteLine($"Шаг:{step1}");
            arith.setStep(2);
            Console.Write("Первое значение:");
            Console.WriteLine(arith.getNext());
            Console.Write("Второе значение:");
            Console.WriteLine(arith.getNext());
            Console.Write("Третье значение:");
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Сброс прогрессии");
            arith.reset();
            Console.Write("Первое значение:");
            Console.WriteLine(arith.getNext());
            Console.Write("Второе значение:");
            Console.WriteLine(arith.getNext());
            Console.WriteLine();

            int x2 = 10;
            int step2 = 2;
            Console.WriteLine("Проверка геометрической прогрессии");
            GeomProgression geom = new GeomProgression();
            Console.WriteLine($"Начальное значение:{x2}");
            geom.setStart(10);
            Console.WriteLine($"Шаг:{step2}");
            geom.setStep(2);
            Console.Write("Первое значение:");
            Console.WriteLine(geom.getNext());
            Console.Write("Второе значение:");
            Console.WriteLine(geom.getNext());
            Console.Write("Третье значение:");
            Console.WriteLine(geom.getNext());
            Console.WriteLine("Сброс прогрессии");
            geom.reset();
            Console.Write("Первое значение:");
            Console.WriteLine(geom.getNext());
            Console.Write("Второе значение:");
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
