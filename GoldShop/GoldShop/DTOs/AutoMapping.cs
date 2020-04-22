using System;
using AutoMapper;
using GoldShop.Models;

namespace GoldShop.DTOs
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ProductCategory, ProductCategoryDTO>();
            CreateMap<ProductCategoryRequest, ProductCategory>()
                    .ForMember(d => d.CreatedDate, o => o.MapFrom(s => DateTime.Now))
                    .ForMember(d => d.Active, o => o.MapFrom(s => true));
        }
    }
}
