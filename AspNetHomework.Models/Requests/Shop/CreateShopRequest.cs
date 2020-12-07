namespace AspNetHomework.Models.Requests.Shop
{
    /// <summary>
    /// Запрос на создание записи о магазине.
    /// </summary>
    public class CreateShopRequest
    {
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
