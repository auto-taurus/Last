using System;
using AutoMapper;
using Master.Data.Entities;
using Master.Domain.Models;

namespace Master.Domain.Mapping
{
    public partial class WebNewsProfile
        : AutoMapper.Profile
    {
        public WebNewsProfile()
        {
            CreateMap<Master.Data.Entities.WebNews, Master.Domain.Models.WebNewsReadModel>();
            CreateMap<Master.Domain.Models.WebNewsCreateModel, Master.Data.Entities.WebNews>();
            CreateMap<Master.Data.Entities.WebNews, Master.Domain.Models.WebNewsUpdateModel>();
            CreateMap<Master.Domain.Models.WebNewsUpdateModel, Master.Data.Entities.WebNews>();
        }

    }
}
