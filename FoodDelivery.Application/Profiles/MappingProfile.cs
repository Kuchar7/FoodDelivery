using AutoMapper;
using FoodDelivery.Application.DTOs;
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
            CreateMap<CreateRestaurantDto, Restaurant>();
         
            CreateMap<UpdateRestaurantDto, Restaurant>();
            #endregion

            #region CuisineType
            CreateMap<CuisineType, CuisineTypeDto>().ReverseMap();
            #endregion

            #region Dish
            CreateMap<Dish, DishDto>().ReverseMap();
            CreateMap<CreateDishDto, Dish>();
            #endregion

            #region DishType
            CreateMap<DishType, DishTypeDto>().ReverseMap();
            #endregion


        }
    }
}
