using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetHomework.Database.Domain
{
    /// <summary>
    /// Роль.
    /// </summary>
    public class Role : BaseEntity
    {
        /// <summary>
        /// Название.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Роли пользователя.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
