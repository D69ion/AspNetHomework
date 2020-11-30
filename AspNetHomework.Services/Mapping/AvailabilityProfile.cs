using AspNetHomework.Database.Domain;
using AspNetHomework.Models.DTO;
using AutoMapper;

namespace AspNetHomework.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (наличие).
    /// </summary>
    public class AvailabilityProfile : Profile
    {
        /// <summary>
        /// Инициализарует экземпляр <see cref="AvailabilityProfile"/>.
        /// </summary>
        public AvailabilityProfile()
        {
            CreateMap<Availability, AvailabilityDto>().ReverseMap();

        }
    }
}
