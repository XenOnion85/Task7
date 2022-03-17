using System;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression ar1 = new ArithmeticProgression(1.1, 1.3, 5);
            Console.WriteLine("Введите 5-й элемент арифметической прогрессии, если первый элемент равен 1.1 и разность равна 1.3 :");
            double el = double.Parse(Console.ReadLine());
            ar1.GetElement(el);
            ar1.Res();

            GeometricProgression ge1 = new GeometricProgression(1.5, 1.1, 3);
            Console.WriteLine("\nВведите 3-й элемент геометрической прогрессии, если первый элемент равен 1.5 и разность равна 1.1 :");
            double ele = double.Parse(Console.ReadLine());
            ge1.GetElement(ele);
            ge1.Res();
        }
    }
}
