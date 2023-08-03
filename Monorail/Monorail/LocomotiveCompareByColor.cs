namespace Monorail
{
    internal class LocomotiveCompareByColor : IComparer<IDrawningObject>
    {
        public int Compare(IDrawningObject? x, IDrawningObject? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null && y != null)
            {
                return 1;
            }
            if (x != null && y == null)
            {
                return -1;
            }
            var xLocomotive = x as DrawningObjectLocomotive;
            var yLocomotive = y as DrawningObjectLocomotive;
            if (xLocomotive == null && yLocomotive == null)
            {
                return 0;
            }
            if (xLocomotive == null && yLocomotive != null)
            {
                return 1;
            }
            if (xLocomotive != null && yLocomotive == null)
            {
                return -1;
            }
            string xLocomotiveColor = xLocomotive.GetLocomotive.Locomotive.BodyColor.Name;
            string yLocomotiveColor = yLocomotive.GetLocomotive.Locomotive.BodyColor.Name;
            if (xLocomotiveColor != yLocomotiveColor)
            {
                return xLocomotiveColor.CompareTo(yLocomotiveColor);
            }
            if (xLocomotive.GetLocomotive.GetType().Name != yLocomotive.GetLocomotive.GetType().Name)
            {
                if (xLocomotive.GetLocomotive.GetType().Name == "DrawningLocomotive")
                {
                    return -1;
                }
                return 1;
            }
            if (xLocomotive.GetLocomotive.Locomotive is EntityMonorail xMonorail && yLocomotive.GetLocomotive.Locomotive is EntityMonorail yMonorail)
            {
                string xLocomotiveDopColor = xMonorail.DopColor.Name;
                string yLocomotiveDopColor = yMonorail.DopColor.Name;
                var dopColorCompare = xLocomotiveColor.CompareTo(yLocomotiveColor);
                if (dopColorCompare != 0)
                {
                    return dopColorCompare;
                }
            }
            var speedCompare = xLocomotive.GetLocomotive.Locomotive.Speed.CompareTo(yLocomotive.GetLocomotive.Locomotive.Speed);
            if (speedCompare != 0)
            {
                return speedCompare;
            }
            return xLocomotive.GetLocomotive.Locomotive.Weight.CompareTo(yLocomotive.GetLocomotive.Locomotive.Weight);
        }
    }
}