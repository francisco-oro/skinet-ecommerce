using API.DTO;
using AutoMapper;
using Core.Entities;

namespace API.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Product, ProductToReturnDto>()
            .ForMember(d => d.Category,
                o => o
                    .MapFrom(s => s.Category.CategoryName))
            .ForMember(d => d.ProductBrand,
                o => o
                    .MapFrom(s => s.ProductBrand.Name))
            .ForMember(d => d.ProductType,
                o => o
                    .MapFrom(s => s.ProductType.Name))
            .ForMember(d => d.Colors,
                o => o
                    .MapFrom(s => s.Colors.Select(color => color.ColorName).ToList()))
            .ForMember(d => d.Tags,
                o => o
                    .MapFrom(s => s.Tags.Select(tag => tag.TagName).ToList()))
            .ForMember(d => d.Sizes,
                o => o
                    .MapFrom(s => s.Sizes.Select(size => size.SizeName).ToList()))
            .ForMember(d => d.PictureUrl, 
                o => o
                    .MapFrom<ProductUrlResolver>());
    }
}