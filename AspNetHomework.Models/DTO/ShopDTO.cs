using AspNetHomework.Database.Domain;

namespace AspNetHomework.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Shop"/>.
    /// </summary>
    public class ShopDTO : BaseDTO
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
