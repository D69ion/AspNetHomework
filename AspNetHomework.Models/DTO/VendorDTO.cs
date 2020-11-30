using AspNetHomework.Database.Domain;

namespace AspNetHomework.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Vendor"/>.
    /// </summary>
    public class VendorDto : BaseDto
    {
        /// <summary>
        /// Название поставщика.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }
    }
}
