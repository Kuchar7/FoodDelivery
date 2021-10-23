using AutoMapper;
using FoodDelivery.Application.DTOs;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<Adresse, AdresseDto>().ReverseMap();
            CreateMap<Dish, DishDto>().ReverseMap();
            CreateMap<CuisineType, CuisineDto>().ReverseMap();
            CreateMap<DishType, DishTypeDto>().ReverseMap();
        }
    }
}
