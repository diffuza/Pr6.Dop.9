using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            chet(16);
            provChet(8);
            nechet(16);

            Console.ReadLine();
        }

        // Метод, преобразующий все нечетные числа в четные
        // в диапазоне [0, x] c помощью 
        // поразрядного оператора &
        static void chet(int x)
        {
            int result; //присвоение локальной переменной "result" целого типа "int"
            Console.WriteLine("Преобразованный диапазон чисел от 0 до {0}:\n", x); //вывод строки "..." с исх. данными
            for (int i = 0; i <= x; i++) // применение цикла "for" и присваивание переменной i целого типа int
            {
                // Сбрасываем младший разряд числа, чтобы получить четное число.
                result = i & 0xFFFE;
                Console.Write("{0}\t", result); // вывод строки "..." на экран.
            }
        }

        // Метод проверки числа на четность.
        static void provChet(int x)
        {
            Console.WriteLine("\n\nПроверка четности чисел в диапазоне от 1 до {0}\n", x); // Вывод строки "..." на экран
            for (int i = 1; i <= x; i++) // применение цикла "for" и присваивание переменной i целого типа int
            {
                if ((i & 1) == 0) //конструкция if выполняет блок кода, если заданное условие — истинно, т. е. true.
                    Console.WriteLine("Число {0} - является четным", i); // вывод строки "..." на экран
                else
                    Console.WriteLine("Число {0} - является нечетным", i); // вывод строки "..." на экран
            }
        }

        // Метод, преобразующий четные числа в нечетные с помощью поразрядного оператора

        static void nechet(int x)
        {
            int result; // присвоение локальной переменной "result" целого типа "int"
            Console.WriteLine("\nПреобразованный диапазон чисел от 0 до {0}:\n", x); // Вывод строки "..." на экран. 
            for (int i = 0; i <= x; i++) // применение цикла "for" и присваивание переменной i целого типа int
            {
                result = i | 1; // итоговое значение данного объекта
                Console.Write("{0}\t", result); //вывод строки "..." на экран
            }
        }

    }
}
