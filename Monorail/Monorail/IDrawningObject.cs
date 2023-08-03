using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
	/// <summary>
	/// Интерфейс для работы с объектом, прорисовываемым на форме
	/// </summary>
	internal interface IDrawningObject : IEquatable<IDrawningObject>
	{
		/// <summary>
		/// Шаг перемещения объекта
		/// </summary>
		public float Step { get; }
		/// <summary>
		/// Установка позиции объекта
		/// </summary>
		/// <param name="x">Координата X</param>
		/// <param name="y">Координата Y</param>
		/// <param name="width">Ширина полотна</param>
		/// <param name="height">Высота полотна</param>
		void SetObject(int x, int y, int width, int height);
		/// <summary>
		/// Изменение направления пермещения объекта
		/// </summary>
		/// <param name="direction">Направление</param>
		/// <returns></returns>
		void MoveObject(Direction direction);
		/// <summary>
		/// Отрисовка объекта
		/// </summary>
		/// <param name="g"></param>
		void DrawningObject(Graphics g);
		/// <summary>
		/// Получение текущей позиции объекта
		/// </summary>
		/// <returns></returns>
		(float Left, float Right, float Top, float Bottom) GetCurrentPosition();
		/// <summary>
		/// Получение информации по объекту
		/// </summary>
		/// <returns></returns>
		string GetInfo();
	}
}
