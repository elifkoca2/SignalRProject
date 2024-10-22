using AutoMapper;
using SignalR.EntityLayer.Entities;
using SinalR.DtoLayer.AboutDto;
using SinalR.DtoLayer.BookingDto;

namespace SignalRApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();

        }
    }
}
