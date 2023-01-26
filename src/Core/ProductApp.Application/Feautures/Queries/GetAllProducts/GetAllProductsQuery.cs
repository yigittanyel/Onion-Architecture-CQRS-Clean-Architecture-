using AutoMapper;
using MediatR;
using ProductApp.Application.Abstraction.Repository;
using ProductApp.Application.DTOs;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Feautures.Queries.GetAllProducts
{
    public class GetAllProductsQuery:IRequest<ServiceResponse<List<ProductDto>>>
    {


        public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductDto>>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetAllProductsHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();
                var dto = _mapper.Map<List<ProductDto>>(products);
                return new ServiceResponse<List<ProductDto>>(dto);
            }
        }
    }
}
