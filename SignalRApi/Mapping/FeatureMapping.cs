using AutoMapper;
using SignalR.EntityLayer.Entities;
using SinalR.DtoLayer.AboutDto;
using SinalR.DtoLayer.FeatureDto;

namespace SignalRApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();

        }
    }
}
