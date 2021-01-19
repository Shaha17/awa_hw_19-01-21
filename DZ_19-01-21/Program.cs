using System;

namespace DZ_19_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double
                a,
                b,
                c;

            Console.WriteLine("Задание №1");

            // 1. Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то
            // есть квадратный корень из их произведения: √a·b.
            // a = 16.80
            // b = 12.40
            // результат = 14.43
            a = 16.8;
            b = 12.4;
            Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(a * b));
            Console.WriteLine();

            Console.WriteLine("Задание №2");

            // 2. Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их
            // сумму.
            // A = 1.40
            // B = -5.50
            // C = 0.60
            // AC = 0.80
            // BC = 6.10
            // AC+BC = 6.90
            a = 1.40;
            b = -5.50;
            c = 0.60;
            Console.WriteLine("AB = " + Math.Abs(a - c));
            Console.WriteLine("BC = " + Math.Abs(b - c));
            Console
                .WriteLine("AB + BC = " + (Math.Abs(a - c) + Math.Abs(b - c)));
            Console.WriteLine();

            Console.WriteLine("Задание №3");

            // 3. Найти расстояние между двумя точками с заданными координатами (x1,y1) и
            // (x2,y2) на плоскости. Расстояние вычисляется по формуле √((x2 — x1)^2 + (y2 — y1)^2)
            // x1, y1: -6.20 5.20
            // x2, y2: 2.10 9.80
            // результат = 9.49
            double
                x1,
                x2,
                y1,
                y2;
            x1 = -6.20;
            y1 = 5.20;
            x2 = 2.10;
            y2 = 9.80;
            Console
                .WriteLine("Расстояние = " +
                Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine();

            Console.WriteLine("Задание №4");

            // 4. Дано двузначное число. Вывести число, полученное при перестановке цифр
            // исходного числа.
            // Число: 41
            // Результат: 14
            int number;
            number = 14;
            Console.WriteLine("Число: " + number);
            Console
                .WriteLine("Число на оборот: " +
                number % 10 * 10 +
                number / 10);
            Console.WriteLine();

            Console.WriteLine("Задание №5");

            // 5. С начала суток прошло N секунд (N — целое). Найти количество полных минут,
            // прошедших с начала суток.
            // N = 10985
            // Результат: 183
            int n;
            n = 10985;
            Console.WriteLine("Количество полных минут: " + n / 60);
            Console.WriteLine();

            Console.WriteLine("Задание №6");

	        // 6. Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 —
            // понедельник, 2 — вторник, ..., 6 — суббота. Дано целое число K, лежащее в
            // диапазоне 1–365. Определить номер дня недели для K-го дня года, если
            // известно, что в этом году 1 января было понедельником.
            // K = 202
            // Номер дня недели: 6
            int k;
            k = 202;
            Console.WriteLine("Номер дня недели: " + k % 7);
            Console.WriteLine();
        }
    }
}
