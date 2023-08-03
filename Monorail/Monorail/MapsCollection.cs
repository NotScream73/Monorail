using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    /// <summary>
    /// Класс для хранения коллекции карт
    /// </summary>
    internal class MapsCollection
    {
        /// <summary>
        /// Словарь (хранилище) с картами
        /// </summary>
        readonly Dictionary<string, MapWithSetLocomotivesGeneric<IDrawningObject, AbstractMap>> _mapStorages;
        /// <summary>
        /// Возвращение списка названий карт
        /// </summary>
        public List<string> Keys => _mapStorages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Разделитель для записи информации по элементу словаря в файл
        /// </summary>
        private readonly char separatorDict = '|';
        /// <summary>
        /// Разделитель для записей коллекции данных в файл
        /// </summary>
        private readonly char separatorData = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            _mapStorages = new Dictionary<string, MapWithSetLocomotivesGeneric<IDrawningObject, AbstractMap>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление карты
        /// </summary>
        /// <param name="name">Название карты</param>
        /// <param name="map">Карта</param>
        public void AddMap(string name, AbstractMap map)
        {
            if (Keys.Contains(name))
            {
                MessageBox.Show("Такая карта уже есть");
                return;
            }
            else
            {
                var NewElem = new MapWithSetLocomotivesGeneric<IDrawningObject, AbstractMap>(
                    _pictureWidth, _pictureHeight, map);
                _mapStorages.Add(name, NewElem);
            }
        }
        /// <summary>
        /// Удаление карты
        /// </summary>
        /// <param name="name">Название карты</param>
        public void DelMap(string name)
        {
            if (Keys.Contains(name))
            {
                _mapStorages.Remove(name);
            }
            else
            {
                MessageBox.Show("Такой карты нет");
                return;
            }
        }
        /// <summary>
        /// Доступ к депо
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public MapWithSetLocomotivesGeneric<IDrawningObject, AbstractMap> this[string ind]
        {
            get
            {
                if (Keys.Contains(ind))
                {
                    return _mapStorages[ind];
                }
                MessageBox.Show("Такой карты нет");
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по локомотивам в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new(filename))
            {
                fs.Write($"MapsCollection{Environment.NewLine}");
                foreach (var storage in _mapStorages)
                {
                    fs.Write($"{storage.Key}{separatorDict}{storage.Value.GetData(separatorDict, separatorData)}{Environment.NewLine}");
                }
            }
        }

        /// <summary>
        /// Загрузка нформации по локомотивам в депо из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Файл не найден");
            }
            using (StreamReader fs = new(filename))
            {
                string str = fs.ReadLine();
                if (!str.Contains("MapsCollection"))
                {
                    //если нет такой записи, то это не те данные
                    throw new FileFormatException("Формат данных в файле не правильный");
                }
                //очищаем записи
                _mapStorages.Clear();
                str = fs.ReadLine();
                while (str != null)
                {
                    var elem = str.Split(separatorDict);
                    AbstractMap map = null;
                    switch (elem[1])
                    {
                        case "SimpleMap":
                            map = new SimpleMap();
                            break;
                        case "DesertMap":
                            map = new DesertMap();
                            break;
                        case "LawnMap":
                            map = new LawnMap();
                            break;
                    }
                    _mapStorages.Add(elem[0], new MapWithSetLocomotivesGeneric<IDrawningObject, AbstractMap>(_pictureWidth, _pictureHeight, map));
                    _mapStorages[elem[0]].LoadData(elem[2].Split(separatorData, StringSplitOptions.RemoveEmptyEntries));
                    str = fs.ReadLine();
                }
            }
        }
    }
}