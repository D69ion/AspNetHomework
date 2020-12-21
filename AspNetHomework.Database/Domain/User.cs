using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database.Domain
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Логин пользователя.
        /// </summary>
        [Required]
        [StringLength(30)]
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        /// <summary>
        /// Роли пользователя.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
