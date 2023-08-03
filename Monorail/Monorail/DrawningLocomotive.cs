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
    public class DrawningLocomotive
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntityLocomotive Locomotive { get; protected set; }
        /// <summary>
        /// Левая координата отрисовки локомотива
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Верхняя кооридната отрисовки локомотива
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки локомотива
        /// </summary>
        private readonly int _locomotiveWidth = 90;
        /// <summary>
        /// Высота отрисовки локомотива
        /// </summary>
        private readonly int _locomotiveHeight = 35;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес локомотива</param>
        /// <param name="bodyColor">Цвет корпуса</param>
        public DrawningLocomotive(int speed, float weight, Color bodyColor)
        {
            Locomotive = new EntityLocomotive(speed, weight, bodyColor);
        }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес локомотива</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="locomotiveWidth">Ширина отрисовки локомотива</param>
        /// <param name="locomotiveHeight">Высота отрисовки локомотива</param>
        protected DrawningLocomotive(int speed, float weight, Color bodyColor, int locomotiveWidth, int locomotiveHeight) :
            this(speed, weight, bodyColor)
        {
            _locomotiveWidth = locomotiveWidth;
            _locomotiveHeight = locomotiveHeight;
        }
        /// <summary>
        /// Установка позиции локомотива
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || width < x + _locomotiveWidth || height < y + _locomotiveHeight)
            {
                _pictureHeight = null;
                _pictureWidth = null;
                return;
            }
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _locomotiveWidth + Locomotive.Step < _pictureWidth)
                    {
                        _startPosX += Locomotive.Step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - Locomotive.Step > 0)
                    {
                        _startPosX -= Locomotive.Step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - Locomotive.Step > 0)
                    {
                        _startPosY -= Locomotive.Step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _locomotiveHeight + Locomotive.Step < _pictureHeight)
                    {
                        _startPosY += Locomotive.Step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка локомотива
        /// </summary>
        /// <param name="g"></param>
        public virtual void DrawTransport(Graphics g)
        {
            if (_startPosX < 0 || _startPosY < 0
                || !_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }
            // границы
            Pen pen = new(Color.Black);
            Brush br = new SolidBrush(Locomotive?.BodyColor ?? Color.Black);
            Point[] points = {
                new Point((int)_startPosX + 4, (int)_startPosY + 12),
                new Point((int)_startPosX + 9, (int)_startPosY + 1),
                new Point((int)_startPosX + 90, (int)_startPosY + 1),
                new Point((int)_startPosX + 90, (int)_startPosY + 25),
                new Point((int)_startPosX + 4, (int)_startPosY + 25)
            };
            g.FillPolygon(br, points);
            // Окна
            Pen penBlue = new(Color.Blue);
            Brush brWhite = new SolidBrush(Color.White);
            g.FillRectangle(brWhite, _startPosX + 11, _startPosY + 3, 7, 8);
            g.FillRectangle(brWhite, _startPosX + 22, _startPosY + 3, 7, 8);
            g.FillRectangle(brWhite, _startPosX + 80, _startPosY + 3, 7, 8);
            g.DrawRectangle(penBlue, _startPosX + 11, _startPosY + 3, 7, 8);
            g.DrawRectangle(penBlue, _startPosX + 22, _startPosY + 3, 7, 8);
            g.DrawRectangle(penBlue, _startPosX + 80, _startPosY + 3, 7, 8);
            // Полоса и дверь
            g.DrawLine(pen, _startPosX + 4, _startPosY + 13, _startPosX + 32, _startPosY + 13);
            g.DrawLine(pen, _startPosX + 42, _startPosY + 13, _startPosX + 90, _startPosY + 13);
            g.DrawRectangle(pen, _startPosX + 32, _startPosY + 5, 10, 17);
            // Крепление к вагону
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillRectangle(brBlack, _startPosX + 90, _startPosY + 3, 3, 20);
            // Нижняя часть
            Point[] pointsdown = {
                new Point((int)_startPosX + 1, (int)_startPosY + 31),
                new Point((int)_startPosX + 5, (int)_startPosY + 26),
                new Point((int)_startPosX + 37, (int)_startPosY + 26),
                new Point((int)_startPosX + 34, (int)_startPosY + 31)
            };
            g.FillPolygon(brBlack, pointsdown);
            Point[] pointsdown2 = {
                new Point((int)_startPosX + 54, (int)_startPosY + 26),
                new Point((int)_startPosX + 58, (int)_startPosY + 31),
                new Point((int)_startPosX + 94, (int)_startPosY + 31),
                new Point((int)_startPosX + 90, (int)_startPosY + 26)
            };
            g.FillPolygon(brBlack, pointsdown2);
            // Колёса
            g.FillEllipse(brWhite, _startPosX + 11, _startPosY + 27, 11, 8);
            g.DrawEllipse(pen, _startPosX + 11, _startPosY + 27, 11, 8);
            g.FillEllipse(brWhite, _startPosX + 29, _startPosY + 27, 11, 8);
            g.DrawEllipse(pen, _startPosX + 29, _startPosY + 27, 11, 8);
            g.FillEllipse(brWhite, _startPosX + 51, _startPosY + 27, 11, 8);
            g.DrawEllipse(pen, _startPosX + 51, _startPosY + 27, 11, 8);
            g.FillEllipse(brWhite, _startPosX + 69, _startPosY + 27, 11, 8);
            g.DrawEllipse(pen, _startPosX + 69, _startPosY + 27, 11, 8);
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _locomotiveWidth || _pictureHeight <= _locomotiveHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _locomotiveWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _locomotiveWidth;
            }
            if (_startPosY + _locomotiveHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _locomotiveHeight;
            }
        }
        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return (_startPosX, _startPosY, _startPosX + _locomotiveWidth, _startPosY + _locomotiveHeight);
        }
    }
}
