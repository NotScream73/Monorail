using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    /// <summary>
    /// Класс-сущность "Монорельс"
    /// </summary>
    internal class EntityMonorail: EntityLocomotive
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { get; private set; }
        /// <summary>
        /// Признак наличия магнитной рельсы
        /// </summary>
        public bool MagneticRail { get; private set; }
        /// <summary>
        /// Признак наличия второй кабины
        /// </summary>
        public bool SecondCabin { get; private set; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес локомотива</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="magneticRail">Признак наличия магнитной рельсы</param>
        /// <param name="secondCabin">Признак наличия второй кабины</param>
        public EntityMonorail(int speed, float weight, Color bodyColor, Color dopColor, bool magneticRail, bool secondCabin) :
            base(speed, weight, bodyColor)
        {
            DopColor = dopColor;
            MagneticRail = magneticRail;
            SecondCabin = secondCabin;
        }
        public void ChangeDopColor(Color dopColor)
        {
            DopColor = dopColor;
        }
    }
}
