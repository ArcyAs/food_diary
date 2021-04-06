using AutoMapper;
using FoodDiary.Data;
using FoodDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDiary.MapperProfiles
{
    public class DataCalculatorMapperProfile : Profile
    {
        public DataCalculatorMapperProfile()
        {
            CreateMap<DataCalculator, DataCalculatorDto>();
        }
    }
}
