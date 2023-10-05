using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a:");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            double a = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

            Console.WriteLine("Введите значение b:");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            double b = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

            try
            {
                Trapezoid trapezoid = new Trapezoid(a, b);

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("1. Вычислить длину трапеции");
                    Console.WriteLine("2. Вычислить площадь трапеции");
                    Console.WriteLine("3. Вычислить периметр трапеции");
                    Console.WriteLine("4. Проверить, находится ли точка внутри трапеции");
                    Console.WriteLine("5. Проверить, находится ли точка на границе трапеции");
                    Console.WriteLine("6. Выйти");
                    Console.Write("Введите номер операции: ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    string input = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.

                    switch (input)
                    {
                        case "1":
                            double leftSide = trapezoid.LeftSide();
                            double rightSide = trapezoid.RightSide();
                            double upperSide = trapezoid.UpperSide();
                            double bottomSide = trapezoid.BottomSide();

                            Console.WriteLine("Левая сторона: " + leftSide);
                            Console.WriteLine("Правая сторона: " + rightSide);
                            Console.WriteLine("Верхняя сторона: " + upperSide);
                            Console.WriteLine("Нижняя сторона: " + bottomSide);
                            break;
                        case "2":
                            double area = trapezoid.Area();
                            Console.WriteLine("Площадь трапеции: " + area);
                            break;
                        case "3":
                            double perimeter = trapezoid.Perimeter();
                            Console.WriteLine("Периметр трапеции: " + perimeter);
                            break;
                        case "4":
                            Console.Write("Введите координату x точки: ");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            double x = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            Console.Write("Введите координату y точки: ");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            double y = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            Point point = new Point(x, y);
                            bool isInside = trapezoid.IsInside(point);
                            Console.WriteLine("Точка " + (isInside ? "внутри" : "вне") + " трапеции");
                            break;
                        case "5":
                            Console.Write("Введите координату x точки: ");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            double xBorder = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            Console.Write("Введите координату y точки: ");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            double yBorder = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                            Point borderPoint = new Point(xBorder, yBorder);
                            bool isOnBorder = trapezoid.IsOnBorder(borderPoint);
                            Console.WriteLine("Точка " + (isOnBorder ? "на границе" : "не на границе") + " трапеции");
                            break;
                        case "6":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Неверная операция. Попробуйте еще раз.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка. Левая граница больше или равна правой: " + ex.Message);
            }
        }
    }
}