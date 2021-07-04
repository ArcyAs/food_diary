using AutoMapper;
using FoodDiary.Data;
using FoodDiary.Models;

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