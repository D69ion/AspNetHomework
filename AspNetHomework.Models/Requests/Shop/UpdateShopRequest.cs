using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Models.Requests.Shop
{
    /// <summary>
    /// Запрос на изменение данных магазина.
    /// </summary>
    public class UpdateShopRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }
    }
}
