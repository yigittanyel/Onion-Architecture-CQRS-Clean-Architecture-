using AutoMapper;
using ProductApp.Application.Feautures.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.Product,DTOs.ProductDto>().ReverseMap();
            CreateMap<Domain.Entities.Product,CreateProductCommand>().ReverseMap();
        }
    }
}
