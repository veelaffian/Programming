namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации ID
    /// </summary>
    public static class IdGenerator
    {
        private static int _id = 0;

        /// <summary>
        /// Возвращает следующий уникальный ID
        /// </summary>
        public static int GetNextId()
        {
            return ++_id;
        }
    }
}