namespace ClassLibrary1
{
    public class Point
    {
        /// <summary>
        /// Получает или задает координату X точки.
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Получает или задает координату Y точки.
        /// </summary>
        public double Y { get; set; }
        // <summary>
        /// Инициализирует новый экземпляр класса <see cref="Point"/> с заданными координатами X и Y.
        /// </summary>
        /// <param name="x">Координата X точки.</param>
        /// <param name="y">Координата Y точки.</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
