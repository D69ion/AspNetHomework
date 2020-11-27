using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database.Domain
{
    /// <summary>
    /// Поставщик.
    /// </summary>
    public class Vendor : BaseEntity
    {
        /// <summary>
        /// Название поставщика.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Address { get; set; }
    }
}
