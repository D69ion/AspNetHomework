namespace AspNetHomework.Models.DTO
{
    /// <summary>
    /// Базовый класс для DTO.
    /// </summary>
    public abstract class BaseDTO
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }
    }
}
