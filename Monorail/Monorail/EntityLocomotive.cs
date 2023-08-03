namespace Monorail
{
    /// <summary>
    /// Класс-сущность "Локомотив"
    /// </summary>
    public class EntityLocomotive
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public float Weight { get; private set; }
        /// <summary>
        /// Цвет корпуса
        /// </summary>
        public Color BodyColor { get; private set; }
        /// <summary>
        /// Шаг перемещения локомотива
        /// </summary>
        public float Step => Speed * 100 / Weight;
        /// <summary>
        /// Инициализация полей объекта-класса локомотива
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        public EntityLocomotive(int speed, float weight, Color bodyColor)
        {
            Random random = new Random();
            Speed = speed <= 0 ? random.Next(50, 150) : speed;
            Weight = weight <= 0 ? random.Next(40, 70) : weight;
            BodyColor = bodyColor;
        }
        public void ChangeColor(Color bodyColor)
        {
            BodyColor = bodyColor;
        }
    }
}