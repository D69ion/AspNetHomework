namespace AspNetHomework.Models.Responses.Product
{
    /// <summary>
    /// Ответ на запросы для списка товаров.
    /// </summary>
    public class ProductResponse
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Артикул.
        /// </summary>
        public string VendorCode { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Вес в кг.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public string VendorName { get; set; }
    }
}
