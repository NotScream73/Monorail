using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    internal class DrawningMonorail : DrawningLocomotive
    {
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес локомотива</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="magneticRail">Признак наличия магнитной рельсы</param>
        /// <param name="secondCabin">Признак наличия второй кабины</param>
        public DrawningMonorail(int speed, float weight, Color bodyColor, Color dopColor, bool magneticRail, bool secondCabin) :
            base(speed, weight, bodyColor, 182, 38)
        {
            Locomotive = new EntityMonorail(speed, weight, bodyColor, dopColor, magneticRail, secondCabin);
        }
        public override void DrawTransport(Graphics g)
        {
            if (Locomotive is not EntityMonorail monorail)
            {
                return;
            }

            base.DrawTransport(g);

            Pen pen = new(Color.Black);
            Brush dopBrush = new SolidBrush(monorail.DopColor);
            Brush brBlack = new SolidBrush(Color.Black);

            if (monorail.MagneticRail)
            {
                Point[] pointsMagneticRail = {
                    new Point((int)_startPosX + 1, (int)_startPosY + 31),
                    new Point((int)_startPosX + 5, (int)_startPosY + 25),
                    new Point((int)_startPosX + 90, (int)_startPosY + 25),
                    new Point((int)_startPosX + 94, (int)_startPosY + 31),
                    new Point((int)_startPosX + 90, (int)_startPosY + 37),
                    new Point((int)_startPosX + 5, (int)_startPosY + 37),
                };
                g.FillPolygon(brBlack, pointsMagneticRail);
            }

            if (monorail.SecondCabin)
            {
                // границы
                Point[] points = {
                    new Point((int)_startPosX + 93, (int)_startPosY + 1),
                    new Point((int)_startPosX + 98, (int)_startPosY + 1),
                    new Point((int)_startPosX + 179, (int)_startPosY + 1),
                    new Point((int)_startPosX + 179, (int)_startPosY + 25),
                    new Point((int)_startPosX + 93, (int)_startPosY + 25)
                };
                g.FillPolygon(dopBrush, points);
                // Окна
                Pen penBlue = new(Color.Blue);
                Brush brWhite = new SolidBrush(Color.White);
                g.FillRectangle(brWhite, _startPosX + 11 + 89, _startPosY + 3, 7, 8);
                g.FillRectangle(brWhite, _startPosX + 22 + 89, _startPosY + 3, 7, 8);
                g.FillRectangle(brWhite, _startPosX + 80 + 89, _startPosY + 3, 7, 8);
                g.DrawRectangle(penBlue, _startPosX + 11 + 89, _startPosY + 3, 7, 8);
                g.DrawRectangle(penBlue, _startPosX + 22 + 89, _startPosY + 3, 7, 8);
                g.DrawRectangle(penBlue, _startPosX + 80 + 89, _startPosY + 3, 7, 8);
                // Полоса и дверь
                g.DrawLine(pen, _startPosX + 4 + 89, _startPosY + 13, _startPosX + 32 + 89, _startPosY + 13);
                g.DrawLine(pen, _startPosX + 42 + 89, _startPosY + 13, _startPosX + 90 + 89, _startPosY + 13);
                g.DrawRectangle(pen, _startPosX + 32 + 89, _startPosY + 5, 10, 17);
                // Крепление к вагону
                g.FillRectangle(brBlack, _startPosX + 90 + 89, _startPosY + 3, 3, 20);
                // Нижняя часть
                Point[] pointsMagneticRail = {
                    new Point((int)_startPosX + 1 + 89, (int)_startPosY + 31),
                    new Point((int)_startPosX + 5 + 89, (int)_startPosY + 25),
                    new Point((int)_startPosX + 90 + 89, (int)_startPosY + 25),
                    new Point((int)_startPosX + 94 + 89, (int)_startPosY + 31),
                    new Point((int)_startPosX + 90 + 89, (int)_startPosY + 37),
                    new Point((int)_startPosX + 5 + 89, (int)_startPosY + 37),
                };
                g.FillPolygon(brBlack, pointsMagneticRail);
            }
        }
    }
}
