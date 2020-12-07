namespace AspNetHomework.Models.Responses.Shop
{
    /// <summary>
    /// Ответ на запросы для списка магазинов.
    /// </summary>
    public class ShopResponse
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название магазина.
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// Адрес магазина.
        /// </summary>
        public string Address { get; set; }

    }
}
