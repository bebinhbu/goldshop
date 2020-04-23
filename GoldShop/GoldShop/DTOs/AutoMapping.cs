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
                .ForMember(dest => dest.CreatedDate, opt =>
                {
                    opt.PreCondition(src => (src.Id == null));
                    opt.MapFrom(s => DateTime.Now);
                })
                .ForMember(dest => dest.Active, opt =>
                {
                    opt.PreCondition(src => (src.Id == null));
                    opt.MapFrom(s => true);
                })
                .ForMember(dest => dest.UpdatedDate, opt =>
                {
                    opt.PreCondition(src => (src.Id != null));
                    opt.MapFrom(s => DateTime.Now);
                });
        }
    }
}
