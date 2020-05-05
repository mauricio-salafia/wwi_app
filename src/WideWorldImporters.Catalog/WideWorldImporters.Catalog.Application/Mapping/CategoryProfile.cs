using AutoMapper;
using WideWorldImporters.Catalog.Application.Categories.Commands;
using WideWorldImporters.Catalog.Domain.Entities;

namespace WideWorldImporters.Catalog.Application.Mapping
{
    /// <summary>
    /// Create a profile for automapper
    /// </summary>
    public class CategoryProfile : Profile
    {
        /// <summary>
        /// Constructor
        /// Map the command to the domain entity
        /// </summary>
        public CategoryProfile()
        {
            CreateMap<CreateCategoryCommand, Category>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Enable, opt => opt.MapFrom(src => src.Enable))
                .ForAllOtherMembers(dest => dest.Ignore());

            CreateMap<UpdateCategoryCommand, Category>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Enable, opt => opt.MapFrom(src => src.Enable))
                .ForAllOtherMembers(dest => dest.Ignore());
        }
    }
}
