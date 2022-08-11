using System;

namespace Rep
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Выберите упражнение\n" +
                "1.Программа сранивает три введенных числа и выводит на консоль результат сравнения\n" +
                "2.Вводится число. Если число одновременно больше 5 и меньше 10, то программа выводит 'Число больше 5 и меньше 10'.\n" +
                "3.Вводится число. Если число либо равно 5, либо равно 10, то программа выводит 'Число либо равно 5, либо равно 10'.\n" +
                "4.Вводитса величина вклада в банк. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%.\n" +
                "5.Улучшенное 4 задание. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы.\n" +
                "6.Выведится название операции, что вы выбрали\n" +
                "7.Улучшенная 6 программа, только теперь также и выводится действие с 2 числами");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a) {
                case 1:
                    Console.WriteLine("Введите числа");
                    Upr1(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Введите число");
                    Upr2(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("Введите число");
                    Upr3(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("Введите вклад");
                    Upr4(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 5:
                    Console.WriteLine("Введите вклад");
                    Upr5(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 6:
                    Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
                    Upr6(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 7:
                    Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение, а также введите 2 числа для выражения");
                    Upr7(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Неправильное число");
                    break;
            }
            Console.ReadKey();
        }

        public static int Upr1(int firstValue, int secondValue, int thirdValue)
        {
            int max = 0;

            if (firstValue > secondValue)
            {
                if (firstValue > thirdValue)
                {
                    Console.WriteLine("Первое число больше всего");
                    max = firstValue;
                }
                else
                {
                    Console.WriteLine("Третье число больше всего");
                    max = thirdValue;
                }
            }
            else
            {
                if (secondValue > thirdValue)
                {
                    Console.WriteLine("Второе число больше всего");
                    max = secondValue;
                }
                else
                {
                    Console.WriteLine("Третье число больше всего");
                    max = thirdValue;
                }
            }

            return max;

        }

        public static int Upr2(int number)
        {
            if (number > 5 && number < 10)
                Console.WriteLine("Число больше 5 и меньше 10");
            else Console.WriteLine("Неизвестное число");
            return number;
        }

        public static int Upr3(int number)
        {
            if (number == 5 || number == 10)
                Console.WriteLine("Число либо равно 5, либо равно 10");
            else Console.WriteLine("Неизвестное число");
            return number;
        }

        public static double Upr4(double number)
        {          
            if (number < 100)
                number += number * 0.05;
            else if (number > 100 && number < 200)
                number += number * 0.07;
            else number += number * 0.1;
            Console.WriteLine($"Вклад равняетя {number}");
            return number;
        }

        public static double Upr5(double number)
        {
           
            if (number < 100)
                number += number * 0.05;
            else if (number > 100 && number < 200)
                number += number * 0.07;
            else number += number * 0.1;
            number += number + 15;
            Console.WriteLine($"Вклад равняетя {number}");
            return number;
        }

        public static int Upr6(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            return number;
        }
        public static int Upr7(int number, int a, int b)
        {
            int sum = 0;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    sum = a + b;
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    sum = a - b;
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    sum = a * b;
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            return sum;
        }

    }
}
