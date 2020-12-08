using AspNetHomework.Database.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetHomework.Database.Fluent
{
    /// <summary>
    /// Конфигурация миграций для <see cref="Availability"/>.
    /// </summary>
    public class AvailabilityConfig : IEntityTypeConfiguration<Availability>
    {
        /// <summary>
        /// Конфигурирование сущности <see cref="Availability"/>.
        /// </summary>
        /// <param name="builder">Билдер сущности.</param>
        public void Configure(EntityTypeBuilder<Availability> builder)
        {
            builder.BaseEntityWithLinksConfig<Availability, Product, Shop>(e => e.Availabilities, e => e.Availabilities);
            builder.Property(x => x.Count).IsRequired();
            builder.ToTable("Availabilities");
        }
    }
}
