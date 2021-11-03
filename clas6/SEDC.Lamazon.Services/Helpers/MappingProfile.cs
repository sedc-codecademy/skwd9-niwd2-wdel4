using AutoMapper;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.OrderId, src => src.Ignore())
                .ForMember(dest => dest.Quantity, src => src.Ignore())
                .ReverseMap();
        }
    }
}
