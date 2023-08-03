using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    /// <summary>
    /// Карта с набром объектов под нее
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    internal class MapWithSetLocomotivesGeneric<T, U>
        where T : class, IDrawningObject, IEquatable<T>
        where U : AbstractMap
    {
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер занимаемого объектом места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 183;
        /// <summary>
        /// Размер занимаемого объектом места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 39;
        /// <summary>
        /// Набор объектов
        /// </summary>
        private readonly SetLocomotivesGeneric<T> _setLocomotives;
        /// <summary>
        /// Карта
        /// </summary>
        private readonly U _map;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth"></param>
        /// <param name="picHeight"></param>
        /// <param name="map"></param>
        public MapWithSetLocomotivesGeneric(int picWidth, int picHeight, U map)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _setLocomotives = new SetLocomotivesGeneric<T>(width * height);
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _map = map;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <param name="map"></param>
        /// <param name="locomotive"></param>
        /// <returns></returns>
        public static int operator +(MapWithSetLocomotivesGeneric<T, U> map, T locomotive)
        {
            return map._setLocomotives.Insert(locomotive);
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// </summary>
        /// <param name="map"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T operator -(MapWithSetLocomotivesGeneric<T, U> map, int position)
        {
            return map._setLocomotives.Remove(position);
        }
        /// <summary>
        /// Вывод всего набора объектов
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowSet()
        {
            Bitmap bmp = new(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp); 
            DrawBackground(gr);
            DrawLocomotives(gr);
            return bmp;
        }
        /// <summary>
        /// Просмотр объекта на карте
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowOnMap()
        {
            Shaking();
            foreach (var locomotive in _setLocomotives.GetLocomotives())
            {
                return _map.CreateMap(_pictureWidth, _pictureHeight, locomotive);
            }
            return new(_pictureWidth, _pictureHeight);
        }
        /// <summary>
        /// Перемещение объекта по крате
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public Bitmap MoveObject(Direction direction)
        {
            if (_map != null)
            {
                return _map.MoveObject(direction);
            }
            return new(_pictureWidth, _pictureHeight);
        }
        /// <summary>
        /// Получение данных в виде строки
        /// </summary>
        /// <param name="sep"></param>
        /// <returns></returns>
        public string GetData(char separatorType, char separatorData)
        {
            string data = $"{_map.GetType().Name}{separatorType}";
            foreach (var locomotive in _setLocomotives.GetLocomotives())
            {
                data += $"{locomotive.GetInfo()}{separatorData}";
            }
            return data;
        }
        /// <summary>
        /// Загрузка списка из массива строк
        /// </summary>
        /// <param name="records"></param>
        public void LoadData(string[] records)
        {
            foreach (var rec in records)
            {
                _setLocomotives.Insert(DrawningObjectLocomotive.Create(rec) as T);
            }
        }
        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="comparer"></param>
        public void Sort(IComparer<T> comparer)
        {
            _setLocomotives.SortSet(comparer);
        }

        /// <summary>
        /// "Взбалтываем" набор, чтобы все элементы оказались в начале
        /// </summary>
        private void Shaking()
        {
            int j = _setLocomotives.Count - 1;
            for (int i = 0; i < _setLocomotives.Count; i++)
            {
                if (_setLocomotives[i] == null)
                {
                    for (; j > i; j--)
                    {
                        var locomotive = _setLocomotives[j];
                        if (locomotive != null)
                        {
                            _setLocomotives.Insert(locomotive, i);
                            _setLocomotives.Remove(j);
                            break;
                        }
                    }
                    if (j <= i)
                    {
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Метод отрисовки фона
        /// </summary>
        /// <param name="g"></param>
        private void DrawBackground(Graphics g)
        {
            Pen pen = new(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight - 4, i * _placeSizeWidth + _placeSizeWidth, j * _placeSizeHeight - 4);
                    g.DrawLine(pen, i * _placeSizeWidth + _placeSizeWidth, j * _placeSizeHeight - 9, i * _placeSizeWidth + _placeSizeWidth, j * _placeSizeHeight - 4);
                }
            }
        }
        /// <summary>
        /// Метод прорисовки объектов
        /// </summary>
        /// <param name="g"></param>
        private void DrawLocomotives(Graphics g)
        {
            int currentWidth = 0;
            int currentHeight = _pictureHeight / _placeSizeHeight;
            int index = 0;
            foreach(var locomotive in _setLocomotives.GetLocomotives())
            {
                _setLocomotives[index]?.SetObject(currentWidth * _placeSizeWidth, (currentHeight - 1) * _placeSizeHeight, _pictureWidth, _pictureHeight);
                _setLocomotives[index]?.DrawningObject(g);
                if (_setLocomotives[index] != null)
                {
                    currentWidth++;
                    if (currentWidth > _pictureWidth / _placeSizeWidth - 1)
                    {
                        currentWidth %= (_pictureWidth / _pictureWidth);
                        currentHeight--;
                    }
                }
                index++;
            }
        }
    }
}
