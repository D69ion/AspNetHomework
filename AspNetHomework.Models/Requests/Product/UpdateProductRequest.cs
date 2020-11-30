using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Models.Requests.Product
{
    /// <summary>
    /// Запрос на изменение позиции товара.
    /// </summary>
    public class UpdateProductRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
