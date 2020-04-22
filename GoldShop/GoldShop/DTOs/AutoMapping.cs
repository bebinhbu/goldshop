using AutoMapper;
using GoldShop.Models;

namespace GoldShop.DTOs
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ProductCategory, ProductCategoryDTO>();
        }
    }
}
