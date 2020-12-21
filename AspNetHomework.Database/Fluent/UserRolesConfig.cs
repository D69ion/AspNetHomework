using AspNetHomework.Database.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetHomework.Database.Fluent
{
    /// <summary>
    /// Конфигурация миграций для <see cref="UserRole"/>.
    /// </summary>
    public class UserRolesConfig : IEntityTypeConfiguration<UserRole>
    {
        /// <summary>
        /// Конфигурирование сущности <see cref="UserRole"/>.
        /// </summary>
        /// <param name="builder">Билдер сущности.</param>
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.BaseEntityWithLinksConfig<UserRole, User, Role>(e => e.UserRoles, e => e.UserRoles);
        }
    }
}
