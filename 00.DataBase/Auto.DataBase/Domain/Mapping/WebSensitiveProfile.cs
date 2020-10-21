using System;
using AutoMapper;
using AutoNews.Data.Entities;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Mapping
{
    public partial class WebSensitiveProfile
        : AutoMapper.Profile
    {
        public WebSensitiveProfile()
        {
            CreateMap<AutoNews.Data.Entities.WebSensitive, AutoNews.Domain.Models.WebSensitiveReadModel>();
            CreateMap<AutoNews.Domain.Models.WebSensitiveCreateModel, AutoNews.Data.Entities.WebSensitive>();
            CreateMap<AutoNews.Data.Entities.WebSensitive, AutoNews.Domain.Models.WebSensitiveUpdateModel>();
            CreateMap<AutoNews.Domain.Models.WebSensitiveUpdateModel, AutoNews.Data.Entities.WebSensitive>();
        }

    }
}
