using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7.view
{
    public class View
    {
        public String getValue(String title) {

            Console.WriteLine(String.Format("{0}", title));
            return Console.ReadLine()!;
        }

        public static void greeting() {
            Console.WriteLine("Запущен калькулятор.\n");
            Console.WriteLine("Введите номер команды для выполнения.");
            Console.WriteLine("1) Вычисление комплексных чисел.");
            Console.WriteLine("2) Вычисление рациональных чисел.");
            Console.WriteLine("3) Вычисление натуральных дробей.");
            Console.WriteLine();
            Console.WriteLine("Введите 0 для закрытия программы.");
        }

        public static void operation() {
            Console.WriteLine("Введите номер операции для выполнения");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
        }
    }
}