using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
	/// <summary>
	/// Параметризованный набор объектов
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal class SetLocomotivesGeneric<T>
		where T : class, IEquatable<T>
	{
		/// <summary>
		/// Список объектов, которые храним
		/// </summary>
		private readonly List<T> _places;
		/// <summary>
		/// Количество объектов в списке
		/// </summary>
		public int Count => _places.Count;

		private readonly int _maxCount;
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="count"></param>
		public SetLocomotivesGeneric(int count)
		{
			_maxCount = count;
			_places = new List<T>();
		}
		/// <summary>
		/// Добавление объекта в набор
		/// </summary>
		/// <param name="locomotive">Добавляемый локомотив</param>
		/// <returns></returns>
		public int Insert(T locomotive)
		{
            return Count + 1 <= _maxCount ? Insert(locomotive, 0) : -1;
        }
        /// <summary>
        /// Добавление объекта в набор на конкретную позицию
        /// </summary>
        /// <param name="locomotive">Добавляемый локомотив</param>
        /// <param name="position">Позиция</param>
        /// <returns></returns>
        public int Insert(T locomotive, int position)
		{
			if (_places.Contains(locomotive))
			{
				return -1;
			}
			if (Count == _maxCount)
			{
				throw new StorageOverflowException(_maxCount);
			}
			if (position >= _maxCount || position < 0)
            {
                return -1;
            }
            _places.Insert(position, locomotive);
            return position;
        }
		/// <summary>
		/// Удаление объекта из набора с конкретной позиции
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public T Remove(int position)
		{
            if (position < 0 || position >= Count)
            {
                return null;
            }
            T result = _places.ElementAt(position);
			if (result == null)
			{
				throw new LocomotiveNotFoundException(position);
			}
			_places.RemoveAt(position);
            return result;
        }
		/// <summary>
		/// Получение объекта из набора по позиции
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		public T this[int position]
		{
            get
            {
                if (position < 0 || position >= Count)
                {
                    return null;
                }
                return _places.ElementAt(position);
            }
            set
            {
                if (position < _maxCount && position >= 0)
                {
                    Insert(this[position], position);
                }
            }
        }
		/// <summary>
		/// Проход по набору до первого пустого
		/// </summary>
		/// <returns></returns>
		public IEnumerable<T> GetLocomotives()
		{
			foreach (var locomotive in _places)
			{
				if (locomotive != null)
				{
					yield return locomotive;
				}
				else
				{
					yield break;
				}
			}
		}
		/// <summary>
		/// Сортировка набора объектов
		/// </summary>
		/// <param name="comparer"></param>
		public void SortSet(IComparer<T> comparer)
		{
			if (comparer == null)
			{
				return;
			}
			_places.Sort(comparer);
		}

	}
}
