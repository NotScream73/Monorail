using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    internal abstract class AbstractMap : IEquatable<AbstractMap>
    {
        private IDrawningObject _drawningObject = null;
        protected int[,] _map = null;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;

        public Bitmap CreateMap(int width, int height, IDrawningObject drawningObject)
        {
            _width = width;
            _height = height;
            _drawningObject = drawningObject;
            GenerateMap();
            while (!SetObjectOnMap())
            {
                GenerateMap();
            }
            return DrawMapWithObject();
        }
        public Bitmap MoveObject(Direction direction)
        {
            (float Left, float Top, float Right, float Down) = _drawningObject.GetCurrentPosition();
            int leftCell = (int)(Left / _size_x);
            int upCell = (int)(Top / _size_y);
            int downCell = (int)(Down / _size_y);
            int rightCell = (int)(Right / _size_x);
            int step = (int)_drawningObject.Step;
            bool canMove = true;
            switch (direction)
            {
                case Direction.Left:
                    for (int i = leftCell - (int)(step / _size_x) - 1 >= 0 ? leftCell - (int)(step / _size_x) - 1 : leftCell; i < leftCell; i++)
                    {
                        for (int j = upCell; j < downCell; j++)
                        {
                            if (_map[i, j] == _barrier)
                            {
                                canMove = false;
                            }
                        }
                    }
                    break;
                case Direction.Up:
                    for (int i = leftCell; i <= rightCell; i++)
                    {
                        for (int j = upCell - (int)(step / _size_x) - 1 >= 0 ? upCell - (int)(step / _size_x) - 1 : downCell - (int)(step / _size_x); j < downCell - (int)(step / _size_x); j++)
                        {
                            if (_map[i, j] == _barrier)
                            {
                                canMove = false;
                            }
                        }
                    }
                    break;
                case Direction.Down:
                    for (int i = leftCell; i <= rightCell; i++)
                    {
                        for (int j = downCell + (int)(step / _size_x) + 1 <= _map.GetLength(0) - 1 ? downCell + (int)(step / _size_x) + 1 : upCell; j > upCell; j--)
                        {
                            if (_map[i, j] == _barrier)
                            {
                                canMove = false;
                            }
                        }
                    }
                    break;
                case Direction.Right:
                    for (int i = rightCell + (int)(step / _size_x) + 1 <= _map.GetLength(0) - 1 ? rightCell + (int)(step / _size_x) + 1 : rightCell; i > rightCell; i--)
                    {
                        for (int j = upCell; j < downCell; j++)
                        {
                            if (_map[i, j] == _barrier)
                            {
                                canMove = false;
                            }
                        }
                    }
                    break;
            }
            if (canMove)
            {
                _drawningObject.MoveObject(direction);
            }
            return DrawMapWithObject();
        }
        private bool SetObjectOnMap()
        {
            if (_drawningObject == null || _map == null)
            {
                return false;
            }
            int x = _random.Next(0, 10);
            int y = _random.Next(0, 10);
            _drawningObject.SetObject(x, y, _width, _height);
            (float Left, float Top, float  Right,float Down) = _drawningObject.GetCurrentPosition();
            int leftCell = (int)(Left / _size_x);
            int upCell = (int)(Top / _size_y);
            int downCell = (int)(Down / _size_y);
            int rightCell = (int)(Right / _size_x);
            for (int i = leftCell; i < rightCell; i++)
            {
                for (int j = upCell; j < downCell; j++)
                {
                    if (_map[i,j] == _barrier)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private Bitmap DrawMapWithObject()
        {
            Bitmap bmp = new(_width, _height);
            if (_drawningObject == null || _map == null)
            {
                return bmp;
            }
            Graphics gr = Graphics.FromImage(bmp);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _freeRoad)
                    {
                        DrawRoadPart(gr, i, j);
                    }
                    else if (_map[i, j] == _barrier)
                    {
                        DrawBarrierPart(gr, i, j);
                    }
                }
            }
            _drawningObject.DrawningObject(gr);
            return bmp;
        }

        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);

        public bool Equals(AbstractMap? other)
        {
            if (other == null)
            {
                return false;
            }
            var otherMap = other as AbstractMap;
            if (otherMap == null)
            {
                return false;
            }
            if (_width != otherMap._width)
            {
                return false;
            }
            if (_height != otherMap._height)
            {
                return false;
            }
            if (_size_x != otherMap._size_x)
            {
                return false;
            }
            if (_size_y != otherMap._size_y)
            {
                return false;
            }
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    if (_map[i, j] != otherMap._map[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}
