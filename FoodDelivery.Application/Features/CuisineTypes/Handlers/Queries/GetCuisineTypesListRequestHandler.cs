using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.Features.CuisineTypes.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.CuisineTypes.Handlers.Queries
{

    public class GetCuisineTypesListRequestHandler : IRequestHandler<GetCuisineTypesListRequest, List<CuisineTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public GetCuisineTypesListRequestHandler(IMapper mapper, ICuisineTypeRepository cuisineTypeRepository)
        {
            _mapper = mapper;
            _cuisineTypeRepository = cuisineTypeRepository;
        }

        public async Task<List<CuisineTypeDto>> Handle(GetCuisineTypesListRequest request, CancellationToken cancellationToken)
        {
            var cuisineTypes = await _cuisineTypeRepository.GetAll();
            return _mapper.Map<List<CuisineTypeDto>>(cuisineTypes);
        }
    }
}
