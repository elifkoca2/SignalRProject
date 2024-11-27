﻿using AutoMapper;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;
using SinalR.DtoLayer.NotificationDto;

namespace SignalRApi.Mapping
{
    public class NotificationMapping:Profile
    {
        public NotificationMapping()
        {
            CreateMap<ResultNotificationDto, Notification>().ReverseMap();
            CreateMap<CreateNotificationDto, Notification>().ReverseMap();
            CreateMap<GetByIdNotificationDto, Notification>().ReverseMap();
            CreateMap<UpdateNotificationDto, Notification>().ReverseMap();
        }
    }
}
