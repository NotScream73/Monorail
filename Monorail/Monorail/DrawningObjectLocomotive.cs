using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monorail
{
    internal class DrawningObjectLocomotive : IDrawningObject
    {
        private DrawningLocomotive _locomotive;
        public DrawningObjectLocomotive(DrawningLocomotive locomotive)
        {
            _locomotive = locomotive;
        }
        public float Step => _locomotive?.Locomotive?.Step ?? 0;

        public DrawningLocomotive GetLocomotive => _locomotive;

        public void DrawningObject(Graphics g)
        {
            _locomotive.DrawTransport(g);
        }

        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return _locomotive?.GetCurrentPosition() ?? default;
        }

        public string GetInfo() => _locomotive?.GetDataForSave();

        public void MoveObject(Direction direction)
        {
            _locomotive?.MoveTransport(direction);
        }

        public void SetObject(int x, int y, int width, int height)
        {
            _locomotive.SetPosition(x, y, width, height);
        }

        public static IDrawningObject Create(string data) => new DrawningObjectLocomotive(data.CreateDrawningLocomotive());

        public bool Equals(IDrawningObject? other)
        {
            if (other == null)
            {
                return false;
            }
            var otherLocomotive = other as DrawningObjectLocomotive;
            if (otherLocomotive == null)
            {
                return false;
            }
            var locomotive = _locomotive.Locomotive;
            var otherLocomotiveLocomotive = otherLocomotive._locomotive.Locomotive;
            if (locomotive.GetType().Name != otherLocomotiveLocomotive.GetType().Name)
            {
                return false;
            }
            if (locomotive.Speed != otherLocomotiveLocomotive.Speed)
            {
                return false;
            }
            if (locomotive.Weight != otherLocomotiveLocomotive.Weight)
            {
                return false;
            }
            if (locomotive.BodyColor != otherLocomotiveLocomotive.BodyColor)
            {
                return false;
            }
            if (locomotive is EntityMonorail monorail && otherLocomotiveLocomotive is EntityMonorail otherMonorail)
            {
                if (monorail.DopColor != otherMonorail.DopColor)
                {
                    return false;
                }
                if (monorail.MagneticRail != otherMonorail.MagneticRail)
                {
                    return false;
                }
                if (monorail.SecondCabin != otherMonorail.SecondCabin)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
