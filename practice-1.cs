using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Пашньова Анастасiя");
        Console.WriteLine("ПЗПI-21-2");

        string[] input;
        Console.WriteLine("\nВведiть три числа (довжина сторони, перший прилеглий кут, другий прилеглий кут):");
        string userInput = Console.ReadLine();
        input = userInput.Split(',');

        if (input.Length != 3)
        {
            Console.WriteLine("Неправильний формат введених даних. Використовуйте формат: довжина, кут1, кут2");
            return;
        }

        double a, angleB, angleC;
        if (!double.TryParse(input[0], out a) || !double.TryParse(input[1], out angleB) || !double.TryParse(input[2], out angleC))
        {
            Console.WriteLine("Помилка введення чисел.");
            return;
        }


        if (a > 0 && angleB > 0 && angleC > 0 && angleB + angleC < 180)
        {
            double angleA = 180 - angleB - angleC;
            double b = a * Math.Sin(angleB) / Math.Sin(angleA);
            double c = a * Math.Sin(angleC) / Math.Sin(angleA);

            if (angleA == 60 && angleB == 60 && angleC == 60)
            {
                Console.WriteLine("Це рiвностороннiй трикутник.");
            }
            else if (angleA == 90 || angleB == 90 || angleC == 90 || a*a + b*b == c*c || a * a + c * c == b * b || c * c + b * b == a*a)
            {
                Console.WriteLine("Це прямокутний трикутник.");
            }
            else if (angleA == angleB || angleB == angleC || angleC == angleA || a == b || b == c || a == c)
            {
                Console.WriteLine("Це рiвнобедрений трикутник.");
            }
            else
            {
                Console.WriteLine("Це рiзностороннiй трикутник.");
            }
        }
        else
        {
            Console.WriteLine("Ця фiгура не є трикутником.");
        }
    }
}
