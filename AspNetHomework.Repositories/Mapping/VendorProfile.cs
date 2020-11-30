using AspNetHomework.Database.Domain;
using AspNetHomework.Models.DTO;
using AutoMapper;

namespace AspNetHomework.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (поставщик).
    /// </summary>
    public class VendorProfile : Profile
    {
        /// <summary>
        /// Инициализарует экземпляр <see cref="VendorProfile"/>.
        /// </summary>
        public VendorProfile()
        {
            CreateMap<Vendor, VendorDto>().ReverseMap();
        }
    }
}
