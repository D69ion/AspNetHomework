using AspNetHomework.Database.Domain;

namespace AspNetHomework.Models.DTO
{
    /// <summary>
    /// DTO для <see cref="Availability"/>.
    /// </summary>
    public class AvailabilityDto : BaseDto
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        public long Shop { get; set; }

        /// <summary>
        /// Товар.
        /// </summary>
        public long Product { get; set; }

        /// <summary>
        /// Кол-во оставшегося товара.
        /// </summary>
        public long Count { get; set; }
    }
}
