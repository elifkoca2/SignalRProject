using AutoMapper;
using SignalR.EntityLayer.Entities;
using SinalR.DtoLayer.AboutDto;
using SinalR.DtoLayer.ContactDto;

namespace SignalRApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();

        }
    }
}
