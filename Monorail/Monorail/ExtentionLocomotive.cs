namespace Monorail
{
    /// <summary>
    /// Расширение для класса DrawningLocomotive
    /// </summary>
    internal static class ExtentionLocomotive
    {
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        private static readonly char _separatorForObject = ':';
        /// <summary>
        /// Создание объекта из строки
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static DrawningLocomotive CreateDrawningLocomotive(this string info)
        {
            string[] strs = info.Split(_separatorForObject);
            if (strs.Length == 3)
            {
                return new DrawningLocomotive(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]));
            }
            if (strs.Length == 6)
            {
                return new DrawningMonorail(Convert.ToInt32(strs[0]),
                    Convert.ToInt32(strs[1]), Color.FromName(strs[2]),
                    Color.FromName(strs[3]), Convert.ToBoolean(strs[4]),
                    Convert.ToBoolean(strs[5]));
            }
            return null;
        }
        /// <summary>
        /// Получение данных для сохранения в файл
        /// </summary>
        /// <param name="drawningLocomotive"></param>
        /// <returns></returns>
        public static string GetDataForSave(this DrawningLocomotive drawningLocomotive)
        {
            var locomotive = drawningLocomotive.Locomotive;
            var str = $"{locomotive.Speed}{_separatorForObject}{locomotive.Weight}{_separatorForObject}{locomotive.BodyColor.Name}";
            if (locomotive is not EntityMonorail monorail)
            {
                return str;
            }
            return $"{str}{_separatorForObject}{monorail.DopColor.Name}{_separatorForObject}{monorail.MagneticRail}{_separatorForObject}{monorail.SecondCabin}";
        }
    }
}