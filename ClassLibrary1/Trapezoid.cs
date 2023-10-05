namespace ClassLibrary1
{
    /// <summary>
    /// Содержит трапецию в множестве математических функций.
    /// </summary>
    public class Trapezoid
    {
        /// <summary>
        /// Получает первый параметр трапеции.
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Получает второй параметр трапеции.
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Trapezoid"/>.
        /// Выдает исключение, если параметры недействительны.
        /// </summary>
        /// <param name="a">Первый параметр трапеции.</param>
        /// <param name="b">Второй параметр трапеции.</param>
        public Trapezoid(double a, double b)
        {
            // Проверка на допустимость входных данных
            if (a >= b)
            {
                throw new ArgumentException("Недопустимые параметры трапеции");
            }

            A = a;
            B = b;
        }
        /// <summary>
        /// Вычисляет длину левой стороны трапеции с использованием функции тангенса.
        /// </summary>
        /// <returns>Длина трапеции.</returns>
        public double LeftSide()
        {
            return Math.Abs(Math.Tan(A));
        }

        /// <summary>
        /// Вычисляет длину правой стороны трапеции с использованием функции тангенса.
        /// </summary>
        /// <returns>Длина трапеции.</returns>
        public double RightSide()
        {
            return Math.Abs(Math.Tan(B));
        }

        /// <summary>
        /// Вычисляет расстояние между точками A и B в трапеции.
        /// </summary>
        /// <returns>Расстояние от точки A до точки B.</returns>
        public double BottomSide()
        {
            return Math.Abs(B - A);
        }

        /// <summary>
        /// Вычисляет верхнюю сторону криволинейной трапеции с использованием функции тангенса.
        /// </summary>
        /// <returns>Длина верхней стороны криволинейной трапеции.</returns>
        public double UpperSide()
        {
            return Math.Abs(Math.Tan(B) - Math.Tan(A));
        }

        /// <summary>
        /// Вычисляет площадь трапеции с использованием интеграла от функции тангенса.
        /// </summary>
        /// <returns>Площадь трапеции.</returns>
        public double Area()
        {
            // Интеграл от tan(x) от a до b
            return Math.Log(Math.Abs(Math.Cos(A))) - Math.Log(Math.Abs(Math.Cos(B)));
        }

        /// <summary>
        /// Вычисляет периметр криволинейной трапеции с использованием функции тангенса.
        /// </summary>
        /// <returns>Периметр криволинейной трапеции.</returns>
        public double Perimeter()
        {
            double leftSide = LeftSide();
            double rightSide = RightSide();
            double upperSide = UpperSide();
            double bottomSide = BottomSide();

            return leftSide + rightSide + upperSide + bottomSide;
        }

        /// <summary>
        /// Определяет, находится ли точка внутри трапеции.
        /// </summary>
        /// <param name="x">Координата x точки.</param>
        /// <param name="y">Координата y точки.</param>
        /// <returns>True, если точка находится внутри трапеции; в противном случае - false.</returns>
        public bool IsInside(Point point)
        {
            if (point.X < A || point.X > B)
                return false;

            double tanX = Math.Tan(point.X);
            return point.Y <= tanX;
        }

        /// <summary>
        /// Определяет, находится ли точка на границе трапеции (включая стороны BottomSide, LeftSide и RightSide).
        /// </summary>
        /// <param name="x">Координата x точки.</param>
        /// <param name="y">Координата y точки.</param>
        /// <returns>True, если точка находится на границе трапеции; в противном случае - false.</returns>
        public bool IsOnBorder(Point point)
        {
            return point.X <= B && point.X >= A && point.Y >= 0 && point.Y <= Math.Tan(point.X);
        }
    }
}
