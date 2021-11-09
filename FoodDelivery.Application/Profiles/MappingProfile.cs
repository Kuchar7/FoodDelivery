using AutoMapper;
using FoodDelivery.Application.DTOs;
using FoodDelivery.Application.DTOs.Adresse;
using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.DTOs.Dish;
using FoodDelivery.Application.DTOs.DishType;
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
            #region Restaurant
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            #endregion
            CreateMap<Adresse, AdresseDto>().ReverseMap();
            CreateMap<Dish, DishDto>().ReverseMap();
            CreateMap<CuisineType, CuisineDto>().ReverseMap();
            CreateMap<DishType, DishTypeDto>().ReverseMap();
            CreateMap<CreateRestaurantDto, RestaurantDto>();
        }
    }
}
