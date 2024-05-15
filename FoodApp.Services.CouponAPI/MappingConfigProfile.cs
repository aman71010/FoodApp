using AutoMapper;
using FoodApp.Services.CouponAPI.Models;
using FoodApp.Services.CouponAPI.Models.Dto;

namespace FoodApp.Services.CouponAPI
{
    public class MappingConfigProfile: Profile
    {
        public MappingConfigProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
